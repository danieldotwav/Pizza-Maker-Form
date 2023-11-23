using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_11._2_DANIEL_RIVAS
{
    public partial class Form1 : Form
    {
        private decimal basePrice = 0;
        private decimal halfToppingPrice = 1.00m;
        private decimal fullToppingPrice = 2.00m;

        public Form1()
        {
            InitializeComponent();
            InitializePizzaSizeComboBox();
            InitializeCrustTypeComboBox();

            WireUpToppingRadioButtons();

            PizzaSize.SelectedIndexChanged += new EventHandler(UpdateBasePriceAndTotal);
            CrustType.SelectedIndexChanged += new EventHandler(UpdateCrustAndTotal);
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

        private void UpdatePrice(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void UpdateCrustAndTotal(object sender, EventArgs e)
        {
            CalculateTotalPrice(); // The crust selection will affect the total price
        }

        private void ToppingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Cast the sender to a RadioButton
            RadioButton rb = sender as RadioButton;

            // When a RadioButton is checked, uncheck others in the same group
            if (rb != null && rb.Checked)
            {
                UncheckOtherToppingPositions(rb);
                CalculateTotalPrice();
            }
        }

        private void WireUpToppingRadioButtons()
        {
            var allToppingRadioButtons = new RadioButton[] {
                radioButtonPepperoniLeft, radioButtonPepperoniCenter, radioButtonPepperoniRight,
                radioButtonHamLeft, radioButtonHamCenter, radioButtonHamRight,
                radioButtonSausageLeft, radioButtonSausageCenter, radioButtonSausageRight,
                radioButtonMushroomsLeft, radioButtonMushroomsCenter, radioButtonMushroomsRight,
                radioButtonJalepenosLeft, radioButtonJalepenosCenter, radioButtonJalepenosRight
            };

            foreach (RadioButton rb in allToppingRadioButtons)
            {
                rb.CheckedChanged += ToppingRadioButton_CheckedChanged;
            }
        }

        private void UncheckOtherToppingPositions(RadioButton checkedRadioButton)
        {
            var toppingGroups = new Dictionary<string, RadioButton[]>() {
                { "Pepperoni", new[] { radioButtonPepperoniLeft, radioButtonPepperoniCenter, radioButtonPepperoniRight } },
                { "Ham", new[] { radioButtonHamLeft, radioButtonHamCenter, radioButtonHamRight } },
                { "Sausage", new[] { radioButtonSausageLeft, radioButtonSausageCenter, radioButtonSausageRight } },
                { "Mushrooms", new[] { radioButtonMushroomsLeft, radioButtonMushroomsCenter, radioButtonMushroomsRight } },
                { "Jalepenos", new[] { radioButtonJalepenosLeft, radioButtonJalepenosCenter, radioButtonJalepenosRight } }
            };

            string selectedTopping = toppingGroups.FirstOrDefault(g => g.Value.Contains(checkedRadioButton)).Key;

            if (selectedTopping != null)
            {
                foreach (var rb in toppingGroups[selectedTopping])
                {
                    if (rb != checkedRadioButton && rb.Checked)
                    {
                        rb.Checked = false;
                    }
                }
            }
        }

        private decimal GetCrustPriceAdjustment()
        {

            decimal updatedPrice = 0m;
            // Check if SelectedItem is not null before calling ToString
            if (CrustType.SelectedItem.ToString() == "Stuffed")
            {
                updatedPrice = basePrice * 0.20m; // 20% upcharge for deep dish
            }

            return updatedPrice; // No additional charge for Regular or Thin Crust
        }

        private void CalculateTotalPrice()
        {
            // Only calculate the total price if valid selections have been made
            if (PizzaSize.SelectedIndex != -1 && CrustType.SelectedIndex != -1)
            {
                decimal crustPriceAdjustment = GetCrustPriceAdjustment();
                int halfToppingCount = CountHalfToppings();
                int fullToppingCount = CountFullToppings();

                decimal toppingsPrice = (halfToppingCount * halfToppingPrice) + (fullToppingCount * fullToppingPrice);
                decimal totalPrice = basePrice + crustPriceAdjustment + toppingsPrice;

                TotalPriceLabel.Text = $"Total: ${totalPrice.ToString("0.00")}";
            }
        }

        private int CountHalfToppings()
        {
            int count = 0;

            // Check left buttons
            count += radioButtonPepperoniLeft.Checked ? 1 : 0;
            count += radioButtonHamLeft.Checked ? 1 : 0;
            count += radioButtonSausageLeft.Checked ? 1 : 0;
            count += radioButtonMushroomsLeft.Checked ? 1 : 0;
            count += radioButtonJalepenosLeft.Checked ? 1 : 0;

            // Check right buttons
            count += radioButtonPepperoniRight.Checked ? 1 : 0;
            count += radioButtonHamRight.Checked ? 1 : 0;
            count += radioButtonSausageRight.Checked ? 1 : 0;
            count += radioButtonMushroomsRight.Checked ? 1 : 0;
            count += radioButtonJalepenosRight.Checked ? 1 : 0;

            return count;
        }

        private int CountFullToppings()
        {
            int count = 0;

            // Check center buttons
            count += radioButtonPepperoniCenter.Checked ? 1 : 0;
            count += radioButtonHamCenter.Checked ? 1 : 0;
            count += radioButtonSausageCenter.Checked ? 1 : 0;
            count += radioButtonMushroomsCenter.Checked ? 1 : 0;
            count += radioButtonJalepenosCenter.Checked ? 1 : 0;

            return count;
        }

        private void UpdateBasePriceAndTotal(object sender, EventArgs e)
        {

            // Assuming the PizzaSize ComboBox has "10\"", "12\"", "14\"" as items
            switch (PizzaSize.SelectedItem.ToString())
            {
                case "10\"":
                    basePrice = 10m;
                    break;
                case "12\"":
                    basePrice = 12m;
                    break;
                case "14\"":
                    basePrice = 14m;
                    break;
                default:
                    basePrice = 0m; // Handle unexpected case
                    break;
            }

            CalculateTotalPrice();
        }

        private void CrustType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
