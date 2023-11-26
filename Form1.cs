using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PizzaMakerForm
{
    public partial class Form1 : Form
    {
        private decimal basePrice = 0;
        private decimal grandTotal = 0;
        private decimal halfToppingPrice = 1.00m;
        private decimal fullToppingPrice = 2.00m;
        private decimal stuffedCrustPriceModifier = 0.20m;

        private decimal TenInchPrice = 10m;
        private decimal TwelveInchPrice = 12m;
        private decimal FourteenInchPrice = 14m;

        private enum ToppingPosition
        {
            LeftHalf,
            RightHalf,
            Full
        }

        public Form1()
        {
            InitializeComponent();
            InitializePizzaSizeComboBox();
            InitializeCrustTypeComboBox();
            WireUpToppingRadioButtons();

            // Set the PictureBox to display the combined baseline pizza image with crust, sauce, and cheese
            pbPizza.Image = CreateBaselineImage();

            // Set the images to indicate topping placement
            filledButtonLeft.Image = CreateFilledButton(filledButtonLeft, Properties.Resources.FullRedCircle, "Left");
            filledButtonCenter.Image = CreateFilledButton(filledButtonCenter, Properties.Resources.FullRedCircle, "Center");
            filledButtonRight.Image = CreateFilledButton(filledButtonRight, Properties.Resources.FullRedCircle, "Right");

            // Subscribe to selected index changed events to update the price total when pizza size or crust is selected
            PizzaSize.SelectedIndexChanged += new EventHandler(UpdateBasePriceAndTotal);
            CrustType.SelectedIndexChanged += new EventHandler(UpdateCrustAndTotal);

            // Disable the radio button used for display purposes only, not for user interaction
            radioButtonEmptyToppingDisplay.Enabled = false;

            // Configure the ordersListBox to use custom drawing 
            ordersListBox.DrawMode = DrawMode.OwnerDrawFixed;
            ordersListBox.DrawItem += new DrawItemEventHandler(ordersListBox_DrawItem);

            // Update the list box's horizontal extent to ensure all content is visible
            UpdateHorizontalExtent();
        }

        // Custom-draws each item in a ListBox, rendering text and adding a separator line beneath each item.
        private void ordersListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();

            if (e.Index >= 0)
            {
                // Calculate the vertical position to center the text within the bounds
                SizeF textSize = e.Graphics.MeasureString(ordersListBox.Items[e.Index].ToString(), e.Font);
                float textY = e.Bounds.Y + (e.Bounds.Height - textSize.Height) / 2;

                e.Graphics.DrawString(ordersListBox.Items[e.Index].ToString(),
                                      e.Font,
                                      new SolidBrush(e.ForeColor),
                                      e.Bounds.X,
                                      textY); // Use the calculated Y-coordinate

                // Draw a line at the bottom of the item
                e.Graphics.DrawLine(Pens.Black,
                                    e.Bounds.X,
                                    e.Bounds.Bottom - 1, // Draw line at the bottom of the item
                                    e.Bounds.Right,
                                    e.Bounds.Bottom - 1);
            }
        }

        // Method to update the horizontal extent
        private void UpdateHorizontalExtent()
        {
            int maxWidth = 0;
            foreach (var item in ordersListBox.Items)
            {
                int itemWidth = TextRenderer.MeasureText(item.ToString(), ordersListBox.Font).Width;
                if (itemWidth > maxWidth)
                {
                    maxWidth = itemWidth;
                }
            }
            ordersListBox.HorizontalExtent = maxWidth;
        }

        private Image CreateFilledButton(PictureBox pictureBox, Image imageToDraw, string side)
        {
            Bitmap buttonImage = new Bitmap(pictureBox.Width, pictureBox.Height);
            Rectangle destinationRect;

            using (Graphics g = Graphics.FromImage(buttonImage))
            {
                // The source rectangle from the original image
                Rectangle sourceRect = new Rectangle(0, 0, imageToDraw.Width / 2, imageToDraw.Height);

                if (side == "Left")
                {
                    destinationRect = new Rectangle(0, 0, pictureBox.Width / 2, pictureBox.Height);
                }
                else if (side == "Right")
                {
                    sourceRect.X = imageToDraw.Width / 2;
                    destinationRect = new Rectangle(pictureBox.Width / 2, 0, pictureBox.Width / 2, pictureBox.Height);
                }
                else // "Center" or default
                {
                    sourceRect = new Rectangle(0, 0, imageToDraw.Width, imageToDraw.Height);
                    destinationRect = new Rectangle(0, 0, pictureBox.Width, pictureBox.Height);
                }

                // Draw the image onto the button using the source and destination rectangles
                g.DrawImage(imageToDraw, destinationRect, sourceRect, GraphicsUnit.Pixel);

                // Set the drawing quality
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            }

            return buttonImage;
        }

        private Image CreateBaselineImage()
        {
            var crust = Properties.Resources.crust;
            var sauce = Properties.Resources.doublesauce;
            var cheese = Properties.Resources.doublecheese;

            Bitmap baselineImage = new Bitmap(pbPizza.Width, pbPizza.Height);

            using (Graphics g = Graphics.FromImage(baselineImage))
            {
                // Draw the crust, scaling it to fit the new bitmap
                g.DrawImage(crust, new Rectangle(0, 0, pbPizza.Width, pbPizza.Height));

                // Layer the sauce on top, scaling it as well
                g.DrawImage(sauce, new Rectangle(0, 0, pbPizza.Width, pbPizza.Height));

                // Layer the cheese on top, scaling it as well
                g.DrawImage(cheese, new Rectangle(0, 0, pbPizza.Width, pbPizza.Height));

                // Set the drawing quality
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            }

            return baselineImage;
        }

        private void UpdatePizzaWithToppings()
        {
            // Start with the baseline image
            Bitmap pizzaWithToppings = new Bitmap(CreateBaselineImage());

            using (Graphics g = Graphics.FromImage(pizzaWithToppings))
            {
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                int width = pizzaWithToppings.Width;
                int height = pizzaWithToppings.Height;

                // Pepperoni
                if (!radioButtonPepperoniNone.Checked)
                {
                    if (radioButtonPepperoniLeft.Checked)
                    {
                        DrawTopping(g, radioButtonPepperoniLeft, Properties.Resources.pepperoni, ToppingPosition.LeftHalf, width, height);
                    }
                    else if (radioButtonPepperoniRight.Checked)
                    {
                        DrawTopping(g, radioButtonPepperoniRight, Properties.Resources.pepperoni, ToppingPosition.RightHalf, width, height);
                    }
                    else if (radioButtonPepperoniCenter.Checked)
                    {
                        DrawTopping(g, radioButtonPepperoniCenter, Properties.Resources.pepperoni, ToppingPosition.Full, width, height);
                    }
                }

                // Ham
                if (!radioButtonHamNone.Checked)
                {
                    if (radioButtonHamLeft.Checked)
                    {
                        DrawTopping(g, radioButtonHamLeft, Properties.Resources.ham, ToppingPosition.LeftHalf, width, height);
                    }
                    else if (radioButtonHamRight.Checked)
                    {
                        DrawTopping(g, radioButtonHamRight, Properties.Resources.ham, ToppingPosition.RightHalf, width, height);
                    }
                    else if (radioButtonHamCenter.Checked)
                    {
                        DrawTopping(g, radioButtonHamCenter, Properties.Resources.ham, ToppingPosition.Full, width, height);
                    }
                }

                // Onions
                if (!radioButtonOnionsNone.Checked)
                {
                    if (radioButtonOnionsLeft.Checked)
                    {
                        DrawTopping(g, radioButtonOnionsLeft, Properties.Resources.onion, ToppingPosition.LeftHalf, width, height);
                    }
                    else if (radioButtonOnionsRight.Checked)
                    {
                        DrawTopping(g, radioButtonOnionsRight, Properties.Resources.onion, ToppingPosition.RightHalf, width, height);
                    }
                    else if (radioButtonOnionsCenter.Checked)
                    {
                        DrawTopping(g, radioButtonOnionsCenter, Properties.Resources.onion, ToppingPosition.Full, width, height);
                    }
                }

                // Mushrooms
                if (!radioButtonMushroomsNone.Checked)
                {
                    if (radioButtonMushroomsLeft.Checked)
                    {
                        DrawTopping(g, radioButtonMushroomsLeft, Properties.Resources.mushroom, ToppingPosition.LeftHalf, width, height);
                    }
                    else if (radioButtonMushroomsRight.Checked)
                    {
                        DrawTopping(g, radioButtonMushroomsRight, Properties.Resources.mushroom, ToppingPosition.RightHalf, width, height);
                    }
                    else if (radioButtonMushroomsCenter.Checked)
                    {
                        DrawTopping(g, radioButtonMushroomsCenter, Properties.Resources.mushroom, ToppingPosition.Full, width, height);
                    }
                }

                // Jalapenos
                if (!radioButtonJalapenosNone.Checked)
                {
                    if (radioButtonJalapenosLeft.Checked)
                    {
                        DrawTopping(g, radioButtonJalapenosLeft, Properties.Resources.jalapeno, ToppingPosition.LeftHalf, width, height);
                    }
                    else if (radioButtonJalapenosRight.Checked)
                    {
                        DrawTopping(g, radioButtonJalapenosRight, Properties.Resources.jalapeno, ToppingPosition.RightHalf, width, height);
                    }
                    else if (radioButtonJalapenosCenter.Checked)
                    {
                        DrawTopping(g, radioButtonJalapenosCenter, Properties.Resources.jalapeno, ToppingPosition.Full, width, height);
                    }
                }
            }

            pbPizza.Image?.Dispose(); // Dispose of the previous image if it exists
            pbPizza.Image = pizzaWithToppings; // Update Pizza image
        }

        private void DrawTopping(Graphics g, RadioButton radioButton, Image toppingImage, ToppingPosition toppingPosition, int width, int height)
        {
            if (radioButton.Checked)
            {
                switch (toppingPosition)
                {
                    case ToppingPosition.Full:
                        g.DrawImage(toppingImage, new Rectangle(0, 0, width, height));
                        break;
                    case ToppingPosition.LeftHalf:
                        DrawHalfTopping(g, toppingImage, new Rectangle(0, 0, width / 2, height), new Rectangle(0, 0, toppingImage.Width / 2, toppingImage.Height));
                        break;
                    case ToppingPosition.RightHalf:
                        DrawHalfTopping(g, toppingImage, new Rectangle(width / 2, 0, width / 2, height), new Rectangle(toppingImage.Width / 2, 0, toppingImage.Width / 2, toppingImage.Height));
                        break;
                    default:
                        MessageBox.Show($"Unexpected topping position: {toppingPosition}. Please select a valid option.", "Invalid Topping Position", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }  
        }

        private void DrawHalfTopping(Graphics g, Image toppingImage, Rectangle destinationRect, Rectangle sourceRect)
        {
            g.DrawImage(toppingImage, destinationRect, sourceRect, GraphicsUnit.Pixel);
        }

        private void InitializePizzaSizeComboBox()
        {
            PizzaSize.Items.Add("10\"");
            PizzaSize.Items.Add("12\"");
            PizzaSize.Items.Add("14\"");
        }

        private void InitializeCrustTypeComboBox()
        {
            CrustType.Items.Add("Regular");
            CrustType.Items.Add("Thin");
            CrustType.Items.Add("Stuffed");
        }

        private void UpdateCrustAndTotal(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void ToppingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                CalculateTotalPrice();
                UpdatePizzaWithToppings();
            }
        }

        private void WireUpToppingRadioButtons()
        {
            var allToppingRadioButtons = new RadioButton[] {
                radioButtonPepperoniLeft, radioButtonPepperoniCenter, radioButtonPepperoniRight, radioButtonPepperoniNone,
                radioButtonHamLeft, radioButtonHamCenter, radioButtonHamRight, radioButtonHamNone,
                radioButtonOnionsLeft, radioButtonOnionsCenter, radioButtonOnionsRight, radioButtonOnionsNone,
                radioButtonMushroomsLeft, radioButtonMushroomsCenter, radioButtonMushroomsRight, radioButtonMushroomsNone,
                radioButtonJalapenosLeft, radioButtonJalapenosCenter, radioButtonJalapenosRight, radioButtonJalapenosNone
            };

            foreach (RadioButton rb in allToppingRadioButtons)
            {
                rb.CheckedChanged += ToppingRadioButton_CheckedChanged;
            }
        }

        private decimal GetCrustPriceAdjustment()
        {
            decimal updatedPrice = 0m;
            if (CrustType.SelectedItem.ToString() == "Stuffed")
            {
                updatedPrice = basePrice * stuffedCrustPriceModifier;
            }
            return updatedPrice;
        }

        private void CalculateTotalPrice()
        {
            if (PizzaSize.SelectedIndex != -1 && CrustType.SelectedIndex != -1)
            {
                decimal crustPriceAdjustment = GetCrustPriceAdjustment();
                int halfToppingCount = CountHalfToppings();
                int fullToppingCount = CountFullToppings();

                decimal toppingsPrice = (halfToppingCount * halfToppingPrice) + (fullToppingCount * fullToppingPrice);
                decimal totalPrice = basePrice + crustPriceAdjustment + toppingsPrice;

                PizzaTotalLabel.Text = $"Pizza Total: ${totalPrice.ToString("0.00")}";
            }
        }

        private int CountHalfToppings()
        {
            int count = 0;

            // Check left buttons
            count += radioButtonPepperoniLeft.Checked ? 1 : 0;
            count += radioButtonHamLeft.Checked ? 1 : 0;
            count += radioButtonOnionsLeft.Checked ? 1 : 0;
            count += radioButtonMushroomsLeft.Checked ? 1 : 0;
            count += radioButtonJalapenosLeft.Checked ? 1 : 0;

            // Check right buttons
            count += radioButtonPepperoniRight.Checked ? 1 : 0;
            count += radioButtonHamRight.Checked ? 1 : 0;
            count += radioButtonOnionsRight.Checked ? 1 : 0;
            count += radioButtonMushroomsRight.Checked ? 1 : 0;
            count += radioButtonJalapenosRight.Checked ? 1 : 0;

            return count;
        }

        private int CountFullToppings()
        {
            int count = 0;

            count += radioButtonPepperoniCenter.Checked ? 1 : 0;
            count += radioButtonHamCenter.Checked ? 1 : 0;
            count += radioButtonOnionsCenter.Checked ? 1 : 0;
            count += radioButtonMushroomsCenter.Checked ? 1 : 0;
            count += radioButtonJalapenosCenter.Checked ? 1 : 0;

            return count;
        }

        private void UpdateBasePriceAndTotal(object sender, EventArgs e)
        {
            switch (PizzaSize.SelectedItem.ToString())
            {
                case "10\"":
                    basePrice = TenInchPrice;
                    break;
                case "12\"":
                    basePrice = TwelveInchPrice;
                    break;
                case "14\"":
                    basePrice = FourteenInchPrice;
                    break;
                default:
                    basePrice = 0m;
                    break;
            }
            CalculateTotalPrice();
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            bool isValidSize = true;
            bool isValidCrust = true;

            if (PizzaSize.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a pizza size.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValidSize = false;
            }

            if (CrustType.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a crust type.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValidCrust = false;
            }

            if (isValidSize && isValidCrust)
            {
                CalculateTotalPrice(); // Ensure the total price is up to date
                string selectedSize = PizzaSize.SelectedItem.ToString();
                string selectedCrust = CrustType.SelectedItem.ToString();
                string orderDetails = $"Size: {selectedSize} || Crust: {selectedCrust} || ";

                // Include selected toppings in the order details
                orderDetails += "Toppings: " + GetSelectedToppings() + " || ";
                orderDetails += PizzaTotalLabel.Text;

                // Add this order detail to the ListBox
                ordersListBox.Items.Add(orderDetails);
                UpdateGrandTotal();
                UpdateHorizontalExtent();
            }
        }

        private string GetSelectedToppings()
        {
            List<string> toppings = new List<string>();

            if (radioButtonPepperoniCenter.Checked)
            {
                toppings.Add("Pepperoni");
            }
            else if (radioButtonPepperoniLeft.Checked)
            {
                toppings.Add("Pepperoni (Left Half)");
            }
            else if (radioButtonPepperoniRight.Checked)
            {
                toppings.Add("Pepperoni (Right Half)");
            }

            if (radioButtonHamCenter.Checked)
            {
                toppings.Add("Ham");
            }
            else if (radioButtonHamLeft.Checked)
            {
                toppings.Add("Ham (Left Half)");
            }
            else if (radioButtonHamRight.Checked)
            {
                toppings.Add("Ham (Right Half)");
            }

            if (radioButtonOnionsCenter.Checked)
            {
                toppings.Add("Onions");
            }
            else if (radioButtonOnionsLeft.Checked)
            {
                toppings.Add("Onions (Left Half)");
            }
            else if (radioButtonOnionsRight.Checked)
            {
                toppings.Add("Onions (Right Half)");
            }

            if (radioButtonMushroomsCenter.Checked)
            {
                toppings.Add("Mushrooms");
            }
            else if (radioButtonMushroomsLeft.Checked)
            {
                toppings.Add("Mushrooms (Left Half)");
            }
            else if (radioButtonMushroomsRight.Checked)
            {
                toppings.Add("Mushrooms (Right Half)");
            }

            if (radioButtonJalapenosCenter.Checked)
            {
                toppings.Add("Jalapenos");
            }
            else if (radioButtonJalapenosLeft.Checked)
            {
                toppings.Add("Jalapenos (Left Half)");
            }
            else if (radioButtonJalapenosRight.Checked)
            {
                toppings.Add("Jalapenos (Right Half)");
            }

            if (toppings.Count == 0)
            {
                return "None";
            }

            return string.Join(", ", toppings);
        }

        private void UpdateGrandTotal()
        {
            grandTotal = 0m; // Reset grandTotal before recalculating

            foreach (var item in ordersListBox.Items)
            {
                string itemString = item.ToString();
                string costString = itemString.Substring(itemString.LastIndexOf("$") + 1);
                if (decimal.TryParse(costString, out decimal itemCost))
                {
                    grandTotal += itemCost;
                }
            }
            GrandTotalLabel.Text = $"Grand Total: ${grandTotal:0.00}";
        }

        private void ordersListBox_Click(object sender, EventArgs e)
        {
            if (ordersListBox.SelectedIndex >= 0)
            {
                var result = MessageBox.Show("Would you like to remove this item from the cart?",
                                             "Remove Item",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ordersListBox.Items.RemoveAt(ordersListBox.SelectedIndex);
                    UpdateGrandTotal();
                }
            }
            else
            {
                MessageBox.Show("Please select an item to remove.",
                                "Select Item",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
