namespace PizzaMakerForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Header = new System.Windows.Forms.GroupBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.PizzaSize = new System.Windows.Forms.ComboBox();
            this.CrustType = new System.Windows.Forms.ComboBox();
            this.groupBoxSizeAndCrustContainer = new System.Windows.Forms.GroupBox();
            this.CrustLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.groupBoxToppingsContainer = new System.Windows.Forms.GroupBox();
            this.filledButtonRight = new System.Windows.Forms.PictureBox();
            this.filledButtonLeft = new System.Windows.Forms.PictureBox();
            this.filledButtonCenter = new System.Windows.Forms.PictureBox();
            this.radioButtonEmptyToppingDisplay = new System.Windows.Forms.RadioButton();
            this.JalapenosLabel = new System.Windows.Forms.Label();
            this.MushroomsLabel = new System.Windows.Forms.Label();
            this.OnionsLabel = new System.Windows.Forms.Label();
            this.HamLabel = new System.Windows.Forms.Label();
            this.PepperoniLabel = new System.Windows.Forms.Label();
            this.ToppingsLabel = new System.Windows.Forms.Label();
            this.groupBoxTopping1 = new System.Windows.Forms.GroupBox();
            this.radioButtonPepperoniNone = new System.Windows.Forms.RadioButton();
            this.radioButtonPepperoniRight = new System.Windows.Forms.RadioButton();
            this.radioButtonPepperoniCenter = new System.Windows.Forms.RadioButton();
            this.radioButtonPepperoniLeft = new System.Windows.Forms.RadioButton();
            this.groupBoxTopping2 = new System.Windows.Forms.GroupBox();
            this.radioButtonHamNone = new System.Windows.Forms.RadioButton();
            this.radioButtonHamCenter = new System.Windows.Forms.RadioButton();
            this.radioButtonHamRight = new System.Windows.Forms.RadioButton();
            this.radioButtonHamLeft = new System.Windows.Forms.RadioButton();
            this.groupBoxTopping3 = new System.Windows.Forms.GroupBox();
            this.radioButtonOnionsNone = new System.Windows.Forms.RadioButton();
            this.radioButtonOnionsCenter = new System.Windows.Forms.RadioButton();
            this.radioButtonOnionsRight = new System.Windows.Forms.RadioButton();
            this.radioButtonOnionsLeft = new System.Windows.Forms.RadioButton();
            this.groupBoxTopping4 = new System.Windows.Forms.GroupBox();
            this.radioButtonMushroomsNone = new System.Windows.Forms.RadioButton();
            this.radioButtonMushroomsCenter = new System.Windows.Forms.RadioButton();
            this.radioButtonMushroomsRight = new System.Windows.Forms.RadioButton();
            this.radioButtonMushroomsLeft = new System.Windows.Forms.RadioButton();
            this.groupBoxTopping5 = new System.Windows.Forms.GroupBox();
            this.radioButtonJalapenosNone = new System.Windows.Forms.RadioButton();
            this.radioButtonJalapenosCenter = new System.Windows.Forms.RadioButton();
            this.radioButtonJalapenosRight = new System.Windows.Forms.RadioButton();
            this.radioButtonJalapenosLeft = new System.Windows.Forms.RadioButton();
            this.PizzaTotalLabel = new System.Windows.Forms.Label();
            this.toppingImageList = new System.Windows.Forms.ImageList(this.components);
            this.pbPizza = new System.Windows.Forms.PictureBox();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.itemsInCartLabel = new System.Windows.Forms.Label();
            this.ordersListBox = new System.Windows.Forms.ListBox();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.groupBoxItemsInCartText = new System.Windows.Forms.GroupBox();
            this.groupBoxGrandTotal = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Header.SuspendLayout();
            this.groupBoxSizeAndCrustContainer.SuspendLayout();
            this.groupBoxToppingsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filledButtonRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filledButtonLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filledButtonCenter)).BeginInit();
            this.groupBoxTopping1.SuspendLayout();
            this.groupBoxTopping2.SuspendLayout();
            this.groupBoxTopping3.SuspendLayout();
            this.groupBoxTopping4.SuspendLayout();
            this.groupBoxTopping5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPizza)).BeginInit();
            this.groupBoxItemsInCartText.SuspendLayout();
            this.groupBoxGrandTotal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Header.BackColor = System.Drawing.Color.Black;
            this.Header.Controls.Add(this.ExitButton);
            this.Header.Controls.Add(this.HeaderLabel);
            this.Header.Location = new System.Drawing.Point(-7, -6);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(920, 89);
            this.Header.TabIndex = 0;
            this.Header.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Gainsboro;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Sitka Subheading", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.Location = new System.Drawing.Point(845, 19);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(50, 25);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HeaderLabel.Font = new System.Drawing.Font("Pleatures Demo", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.Snow;
            this.HeaderLabel.Location = new System.Drawing.Point(183, 29);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(604, 38);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Build A Pizza by Slice Slice Baby";
            // 
            // PizzaSize
            // 
            this.PizzaSize.AllowDrop = true;
            this.PizzaSize.BackColor = System.Drawing.Color.Snow;
            this.PizzaSize.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PizzaSize.FormattingEnabled = true;
            this.PizzaSize.Location = new System.Drawing.Point(138, 30);
            this.PizzaSize.Name = "PizzaSize";
            this.PizzaSize.Size = new System.Drawing.Size(59, 24);
            this.PizzaSize.TabIndex = 1;
            // 
            // CrustType
            // 
            this.CrustType.AllowDrop = true;
            this.CrustType.BackColor = System.Drawing.Color.Snow;
            this.CrustType.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrustType.FormattingEnabled = true;
            this.CrustType.Location = new System.Drawing.Point(138, 66);
            this.CrustType.Name = "CrustType";
            this.CrustType.Size = new System.Drawing.Size(70, 24);
            this.CrustType.TabIndex = 2;
            // 
            // groupBoxSizeAndCrustContainer
            // 
            this.groupBoxSizeAndCrustContainer.Controls.Add(this.CrustLabel);
            this.groupBoxSizeAndCrustContainer.Controls.Add(this.SizeLabel);
            this.groupBoxSizeAndCrustContainer.Controls.Add(this.CrustType);
            this.groupBoxSizeAndCrustContainer.Controls.Add(this.PizzaSize);
            this.groupBoxSizeAndCrustContainer.Location = new System.Drawing.Point(30, 91);
            this.groupBoxSizeAndCrustContainer.Name = "groupBoxSizeAndCrustContainer";
            this.groupBoxSizeAndCrustContainer.Size = new System.Drawing.Size(259, 113);
            this.groupBoxSizeAndCrustContainer.TabIndex = 3;
            this.groupBoxSizeAndCrustContainer.TabStop = false;
            // 
            // CrustLabel
            // 
            this.CrustLabel.AutoSize = true;
            this.CrustLabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrustLabel.Location = new System.Drawing.Point(15, 66);
            this.CrustLabel.Name = "CrustLabel";
            this.CrustLabel.Size = new System.Drawing.Size(94, 23);
            this.CrustLabel.TabIndex = 4;
            this.CrustLabel.Text = "Pizza Crust";
            this.CrustLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLabel.Location = new System.Drawing.Point(15, 29);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(78, 23);
            this.SizeLabel.TabIndex = 3;
            this.SizeLabel.Text = "Size (in.)";
            this.SizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxToppingsContainer
            // 
            this.groupBoxToppingsContainer.Controls.Add(this.filledButtonRight);
            this.groupBoxToppingsContainer.Controls.Add(this.filledButtonLeft);
            this.groupBoxToppingsContainer.Controls.Add(this.filledButtonCenter);
            this.groupBoxToppingsContainer.Controls.Add(this.radioButtonEmptyToppingDisplay);
            this.groupBoxToppingsContainer.Controls.Add(this.JalapenosLabel);
            this.groupBoxToppingsContainer.Controls.Add(this.MushroomsLabel);
            this.groupBoxToppingsContainer.Controls.Add(this.OnionsLabel);
            this.groupBoxToppingsContainer.Controls.Add(this.HamLabel);
            this.groupBoxToppingsContainer.Controls.Add(this.PepperoniLabel);
            this.groupBoxToppingsContainer.Controls.Add(this.ToppingsLabel);
            this.groupBoxToppingsContainer.Controls.Add(this.groupBoxTopping1);
            this.groupBoxToppingsContainer.Controls.Add(this.groupBoxTopping2);
            this.groupBoxToppingsContainer.Controls.Add(this.groupBoxTopping3);
            this.groupBoxToppingsContainer.Controls.Add(this.groupBoxTopping4);
            this.groupBoxToppingsContainer.Controls.Add(this.groupBoxTopping5);
            this.groupBoxToppingsContainer.Location = new System.Drawing.Point(30, 210);
            this.groupBoxToppingsContainer.Name = "groupBoxToppingsContainer";
            this.groupBoxToppingsContainer.Size = new System.Drawing.Size(259, 207);
            this.groupBoxToppingsContainer.TabIndex = 4;
            this.groupBoxToppingsContainer.TabStop = false;
            // 
            // filledButtonRight
            // 
            this.filledButtonRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filledButtonRight.BackColor = System.Drawing.Color.Transparent;
            this.filledButtonRight.Location = new System.Drawing.Point(177, 57);
            this.filledButtonRight.Name = "filledButtonRight";
            this.filledButtonRight.Size = new System.Drawing.Size(15, 15);
            this.filledButtonRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.filledButtonRight.TabIndex = 21;
            this.filledButtonRight.TabStop = false;
            // 
            // filledButtonLeft
            // 
            this.filledButtonLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filledButtonLeft.BackColor = System.Drawing.Color.Transparent;
            this.filledButtonLeft.Location = new System.Drawing.Point(127, 57);
            this.filledButtonLeft.Name = "filledButtonLeft";
            this.filledButtonLeft.Size = new System.Drawing.Size(15, 15);
            this.filledButtonLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.filledButtonLeft.TabIndex = 20;
            this.filledButtonLeft.TabStop = false;
            // 
            // filledButtonCenter
            // 
            this.filledButtonCenter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filledButtonCenter.BackColor = System.Drawing.Color.Transparent;
            this.filledButtonCenter.Location = new System.Drawing.Point(152, 57);
            this.filledButtonCenter.Name = "filledButtonCenter";
            this.filledButtonCenter.Size = new System.Drawing.Size(15, 15);
            this.filledButtonCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.filledButtonCenter.TabIndex = 19;
            this.filledButtonCenter.TabStop = false;
            // 
            // radioButtonEmptyToppingDisplay
            // 
            this.radioButtonEmptyToppingDisplay.AutoSize = true;
            this.radioButtonEmptyToppingDisplay.Location = new System.Drawing.Point(203, 58);
            this.radioButtonEmptyToppingDisplay.Name = "radioButtonEmptyToppingDisplay";
            this.radioButtonEmptyToppingDisplay.Size = new System.Drawing.Size(14, 13);
            this.radioButtonEmptyToppingDisplay.TabIndex = 18;
            this.radioButtonEmptyToppingDisplay.UseVisualStyleBackColor = true;
            // 
            // JalapenosLabel
            // 
            this.JalapenosLabel.AutoEllipsis = true;
            this.JalapenosLabel.AutoSize = true;
            this.JalapenosLabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JalapenosLabel.Location = new System.Drawing.Point(15, 167);
            this.JalapenosLabel.Name = "JalapenosLabel";
            this.JalapenosLabel.Size = new System.Drawing.Size(82, 23);
            this.JalapenosLabel.TabIndex = 15;
            this.JalapenosLabel.Text = "Jalapenos";
            this.JalapenosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MushroomsLabel
            // 
            this.MushroomsLabel.AutoSize = true;
            this.MushroomsLabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MushroomsLabel.Location = new System.Drawing.Point(15, 144);
            this.MushroomsLabel.Name = "MushroomsLabel";
            this.MushroomsLabel.Size = new System.Drawing.Size(97, 23);
            this.MushroomsLabel.TabIndex = 13;
            this.MushroomsLabel.Text = "Mushrooms";
            this.MushroomsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OnionsLabel
            // 
            this.OnionsLabel.AutoSize = true;
            this.OnionsLabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnionsLabel.Location = new System.Drawing.Point(15, 121);
            this.OnionsLabel.Name = "OnionsLabel";
            this.OnionsLabel.Size = new System.Drawing.Size(61, 23);
            this.OnionsLabel.TabIndex = 7;
            this.OnionsLabel.Text = "Onions";
            this.OnionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HamLabel
            // 
            this.HamLabel.AutoSize = true;
            this.HamLabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HamLabel.Location = new System.Drawing.Point(15, 98);
            this.HamLabel.Name = "HamLabel";
            this.HamLabel.Size = new System.Drawing.Size(45, 23);
            this.HamLabel.TabIndex = 6;
            this.HamLabel.Text = "Ham";
            this.HamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PepperoniLabel
            // 
            this.PepperoniLabel.AutoSize = true;
            this.PepperoniLabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PepperoniLabel.Location = new System.Drawing.Point(15, 75);
            this.PepperoniLabel.Name = "PepperoniLabel";
            this.PepperoniLabel.Size = new System.Drawing.Size(83, 23);
            this.PepperoniLabel.TabIndex = 5;
            this.PepperoniLabel.Text = "Pepperoni";
            this.PepperoniLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ToppingsLabel
            // 
            this.ToppingsLabel.AutoSize = true;
            this.ToppingsLabel.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToppingsLabel.Location = new System.Drawing.Point(15, 18);
            this.ToppingsLabel.Name = "ToppingsLabel";
            this.ToppingsLabel.Size = new System.Drawing.Size(173, 23);
            this.ToppingsLabel.TabIndex = 5;
            this.ToppingsLabel.Text = "Toppings ($2.00 ea.)";
            this.ToppingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxTopping1
            // 
            this.groupBoxTopping1.Controls.Add(this.radioButtonPepperoniNone);
            this.groupBoxTopping1.Controls.Add(this.radioButtonPepperoniRight);
            this.groupBoxTopping1.Controls.Add(this.radioButtonPepperoniCenter);
            this.groupBoxTopping1.Controls.Add(this.radioButtonPepperoniLeft);
            this.groupBoxTopping1.Location = new System.Drawing.Point(123, 71);
            this.groupBoxTopping1.Name = "groupBoxTopping1";
            this.groupBoxTopping1.Size = new System.Drawing.Size(100, 30);
            this.groupBoxTopping1.TabIndex = 9;
            this.groupBoxTopping1.TabStop = false;
            // 
            // radioButtonPepperoniNone
            // 
            this.radioButtonPepperoniNone.AutoSize = true;
            this.radioButtonPepperoniNone.Location = new System.Drawing.Point(80, 11);
            this.radioButtonPepperoniNone.Name = "radioButtonPepperoniNone";
            this.radioButtonPepperoniNone.Size = new System.Drawing.Size(14, 13);
            this.radioButtonPepperoniNone.TabIndex = 11;
            this.radioButtonPepperoniNone.UseVisualStyleBackColor = true;
            // 
            // radioButtonPepperoniRight
            // 
            this.radioButtonPepperoniRight.AutoSize = true;
            this.radioButtonPepperoniRight.Location = new System.Drawing.Point(55, 11);
            this.radioButtonPepperoniRight.Name = "radioButtonPepperoniRight";
            this.radioButtonPepperoniRight.Size = new System.Drawing.Size(14, 13);
            this.radioButtonPepperoniRight.TabIndex = 10;
            this.radioButtonPepperoniRight.UseVisualStyleBackColor = true;
            // 
            // radioButtonPepperoniCenter
            // 
            this.radioButtonPepperoniCenter.AutoSize = true;
            this.radioButtonPepperoniCenter.Location = new System.Drawing.Point(30, 11);
            this.radioButtonPepperoniCenter.Name = "radioButtonPepperoniCenter";
            this.radioButtonPepperoniCenter.Size = new System.Drawing.Size(14, 13);
            this.radioButtonPepperoniCenter.TabIndex = 9;
            this.radioButtonPepperoniCenter.UseVisualStyleBackColor = true;
            // 
            // radioButtonPepperoniLeft
            // 
            this.radioButtonPepperoniLeft.AutoSize = true;
            this.radioButtonPepperoniLeft.Location = new System.Drawing.Point(5, 11);
            this.radioButtonPepperoniLeft.Name = "radioButtonPepperoniLeft";
            this.radioButtonPepperoniLeft.Size = new System.Drawing.Size(14, 13);
            this.radioButtonPepperoniLeft.TabIndex = 8;
            this.radioButtonPepperoniLeft.UseVisualStyleBackColor = true;
            // 
            // groupBoxTopping2
            // 
            this.groupBoxTopping2.Controls.Add(this.radioButtonHamNone);
            this.groupBoxTopping2.Controls.Add(this.radioButtonHamCenter);
            this.groupBoxTopping2.Controls.Add(this.radioButtonHamRight);
            this.groupBoxTopping2.Controls.Add(this.radioButtonHamLeft);
            this.groupBoxTopping2.Location = new System.Drawing.Point(123, 94);
            this.groupBoxTopping2.Name = "groupBoxTopping2";
            this.groupBoxTopping2.Size = new System.Drawing.Size(100, 30);
            this.groupBoxTopping2.TabIndex = 11;
            this.groupBoxTopping2.TabStop = false;
            // 
            // radioButtonHamNone
            // 
            this.radioButtonHamNone.AutoSize = true;
            this.radioButtonHamNone.Location = new System.Drawing.Point(80, 11);
            this.radioButtonHamNone.Name = "radioButtonHamNone";
            this.radioButtonHamNone.Size = new System.Drawing.Size(14, 13);
            this.radioButtonHamNone.TabIndex = 12;
            this.radioButtonHamNone.UseVisualStyleBackColor = true;
            // 
            // radioButtonHamCenter
            // 
            this.radioButtonHamCenter.AutoSize = true;
            this.radioButtonHamCenter.Location = new System.Drawing.Point(30, 11);
            this.radioButtonHamCenter.Name = "radioButtonHamCenter";
            this.radioButtonHamCenter.Size = new System.Drawing.Size(14, 13);
            this.radioButtonHamCenter.TabIndex = 9;
            this.radioButtonHamCenter.UseVisualStyleBackColor = true;
            // 
            // radioButtonHamRight
            // 
            this.radioButtonHamRight.AutoSize = true;
            this.radioButtonHamRight.Location = new System.Drawing.Point(55, 11);
            this.radioButtonHamRight.Name = "radioButtonHamRight";
            this.radioButtonHamRight.Size = new System.Drawing.Size(14, 13);
            this.radioButtonHamRight.TabIndex = 10;
            this.radioButtonHamRight.UseVisualStyleBackColor = true;
            // 
            // radioButtonHamLeft
            // 
            this.radioButtonHamLeft.AutoSize = true;
            this.radioButtonHamLeft.Location = new System.Drawing.Point(5, 11);
            this.radioButtonHamLeft.Name = "radioButtonHamLeft";
            this.radioButtonHamLeft.Size = new System.Drawing.Size(14, 13);
            this.radioButtonHamLeft.TabIndex = 8;
            this.radioButtonHamLeft.UseVisualStyleBackColor = true;
            // 
            // groupBoxTopping3
            // 
            this.groupBoxTopping3.Controls.Add(this.radioButtonOnionsNone);
            this.groupBoxTopping3.Controls.Add(this.radioButtonOnionsCenter);
            this.groupBoxTopping3.Controls.Add(this.radioButtonOnionsRight);
            this.groupBoxTopping3.Controls.Add(this.radioButtonOnionsLeft);
            this.groupBoxTopping3.Location = new System.Drawing.Point(123, 117);
            this.groupBoxTopping3.Name = "groupBoxTopping3";
            this.groupBoxTopping3.Size = new System.Drawing.Size(100, 30);
            this.groupBoxTopping3.TabIndex = 12;
            this.groupBoxTopping3.TabStop = false;
            // 
            // radioButtonOnionsNone
            // 
            this.radioButtonOnionsNone.AutoSize = true;
            this.radioButtonOnionsNone.Location = new System.Drawing.Point(80, 11);
            this.radioButtonOnionsNone.Name = "radioButtonOnionsNone";
            this.radioButtonOnionsNone.Size = new System.Drawing.Size(14, 13);
            this.radioButtonOnionsNone.TabIndex = 13;
            this.radioButtonOnionsNone.UseVisualStyleBackColor = true;
            // 
            // radioButtonOnionsCenter
            // 
            this.radioButtonOnionsCenter.AutoSize = true;
            this.radioButtonOnionsCenter.Location = new System.Drawing.Point(30, 11);
            this.radioButtonOnionsCenter.Name = "radioButtonOnionsCenter";
            this.radioButtonOnionsCenter.Size = new System.Drawing.Size(14, 13);
            this.radioButtonOnionsCenter.TabIndex = 9;
            this.radioButtonOnionsCenter.UseVisualStyleBackColor = true;
            // 
            // radioButtonOnionsRight
            // 
            this.radioButtonOnionsRight.AutoSize = true;
            this.radioButtonOnionsRight.Location = new System.Drawing.Point(55, 11);
            this.radioButtonOnionsRight.Name = "radioButtonOnionsRight";
            this.radioButtonOnionsRight.Size = new System.Drawing.Size(14, 13);
            this.radioButtonOnionsRight.TabIndex = 10;
            this.radioButtonOnionsRight.UseVisualStyleBackColor = true;
            // 
            // radioButtonOnionsLeft
            // 
            this.radioButtonOnionsLeft.AutoSize = true;
            this.radioButtonOnionsLeft.Location = new System.Drawing.Point(5, 11);
            this.radioButtonOnionsLeft.Name = "radioButtonOnionsLeft";
            this.radioButtonOnionsLeft.Size = new System.Drawing.Size(14, 13);
            this.radioButtonOnionsLeft.TabIndex = 8;
            this.radioButtonOnionsLeft.UseVisualStyleBackColor = true;
            // 
            // groupBoxTopping4
            // 
            this.groupBoxTopping4.Controls.Add(this.radioButtonMushroomsNone);
            this.groupBoxTopping4.Controls.Add(this.radioButtonMushroomsCenter);
            this.groupBoxTopping4.Controls.Add(this.radioButtonMushroomsRight);
            this.groupBoxTopping4.Controls.Add(this.radioButtonMushroomsLeft);
            this.groupBoxTopping4.Location = new System.Drawing.Point(123, 140);
            this.groupBoxTopping4.Name = "groupBoxTopping4";
            this.groupBoxTopping4.Size = new System.Drawing.Size(100, 30);
            this.groupBoxTopping4.TabIndex = 14;
            this.groupBoxTopping4.TabStop = false;
            // 
            // radioButtonMushroomsNone
            // 
            this.radioButtonMushroomsNone.AutoSize = true;
            this.radioButtonMushroomsNone.Location = new System.Drawing.Point(80, 11);
            this.radioButtonMushroomsNone.Name = "radioButtonMushroomsNone";
            this.radioButtonMushroomsNone.Size = new System.Drawing.Size(14, 13);
            this.radioButtonMushroomsNone.TabIndex = 14;
            this.radioButtonMushroomsNone.UseVisualStyleBackColor = true;
            // 
            // radioButtonMushroomsCenter
            // 
            this.radioButtonMushroomsCenter.AutoSize = true;
            this.radioButtonMushroomsCenter.Location = new System.Drawing.Point(30, 11);
            this.radioButtonMushroomsCenter.Name = "radioButtonMushroomsCenter";
            this.radioButtonMushroomsCenter.Size = new System.Drawing.Size(14, 13);
            this.radioButtonMushroomsCenter.TabIndex = 9;
            this.radioButtonMushroomsCenter.UseVisualStyleBackColor = true;
            // 
            // radioButtonMushroomsRight
            // 
            this.radioButtonMushroomsRight.AutoSize = true;
            this.radioButtonMushroomsRight.Location = new System.Drawing.Point(55, 11);
            this.radioButtonMushroomsRight.Name = "radioButtonMushroomsRight";
            this.radioButtonMushroomsRight.Size = new System.Drawing.Size(14, 13);
            this.radioButtonMushroomsRight.TabIndex = 10;
            this.radioButtonMushroomsRight.UseVisualStyleBackColor = true;
            // 
            // radioButtonMushroomsLeft
            // 
            this.radioButtonMushroomsLeft.AutoSize = true;
            this.radioButtonMushroomsLeft.Location = new System.Drawing.Point(5, 11);
            this.radioButtonMushroomsLeft.Name = "radioButtonMushroomsLeft";
            this.radioButtonMushroomsLeft.Size = new System.Drawing.Size(14, 13);
            this.radioButtonMushroomsLeft.TabIndex = 8;
            this.radioButtonMushroomsLeft.UseVisualStyleBackColor = true;
            // 
            // groupBoxTopping5
            // 
            this.groupBoxTopping5.Controls.Add(this.radioButtonJalapenosNone);
            this.groupBoxTopping5.Controls.Add(this.radioButtonJalapenosCenter);
            this.groupBoxTopping5.Controls.Add(this.radioButtonJalapenosRight);
            this.groupBoxTopping5.Controls.Add(this.radioButtonJalapenosLeft);
            this.groupBoxTopping5.Location = new System.Drawing.Point(123, 163);
            this.groupBoxTopping5.Name = "groupBoxTopping5";
            this.groupBoxTopping5.Size = new System.Drawing.Size(100, 30);
            this.groupBoxTopping5.TabIndex = 15;
            this.groupBoxTopping5.TabStop = false;
            // 
            // radioButtonJalapenosNone
            // 
            this.radioButtonJalapenosNone.AutoSize = true;
            this.radioButtonJalapenosNone.Location = new System.Drawing.Point(80, 11);
            this.radioButtonJalapenosNone.Name = "radioButtonJalapenosNone";
            this.radioButtonJalapenosNone.Size = new System.Drawing.Size(14, 13);
            this.radioButtonJalapenosNone.TabIndex = 15;
            this.radioButtonJalapenosNone.UseVisualStyleBackColor = true;
            // 
            // radioButtonJalapenosCenter
            // 
            this.radioButtonJalapenosCenter.AutoSize = true;
            this.radioButtonJalapenosCenter.Location = new System.Drawing.Point(30, 11);
            this.radioButtonJalapenosCenter.Name = "radioButtonJalapenosCenter";
            this.radioButtonJalapenosCenter.Size = new System.Drawing.Size(14, 13);
            this.radioButtonJalapenosCenter.TabIndex = 9;
            this.radioButtonJalapenosCenter.UseVisualStyleBackColor = true;
            // 
            // radioButtonJalapenosRight
            // 
            this.radioButtonJalapenosRight.AutoSize = true;
            this.radioButtonJalapenosRight.Location = new System.Drawing.Point(55, 11);
            this.radioButtonJalapenosRight.Name = "radioButtonJalapenosRight";
            this.radioButtonJalapenosRight.Size = new System.Drawing.Size(14, 13);
            this.radioButtonJalapenosRight.TabIndex = 10;
            this.radioButtonJalapenosRight.UseVisualStyleBackColor = true;
            // 
            // radioButtonJalapenosLeft
            // 
            this.radioButtonJalapenosLeft.AutoSize = true;
            this.radioButtonJalapenosLeft.Location = new System.Drawing.Point(5, 11);
            this.radioButtonJalapenosLeft.Name = "radioButtonJalapenosLeft";
            this.radioButtonJalapenosLeft.Size = new System.Drawing.Size(14, 13);
            this.radioButtonJalapenosLeft.TabIndex = 8;
            this.radioButtonJalapenosLeft.UseVisualStyleBackColor = true;
            // 
            // PizzaTotalLabel
            // 
            this.PizzaTotalLabel.AutoSize = true;
            this.PizzaTotalLabel.Font = new System.Drawing.Font("Sitka Text", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PizzaTotalLabel.Location = new System.Drawing.Point(9, 12);
            this.PizzaTotalLabel.Name = "PizzaTotalLabel";
            this.PizzaTotalLabel.Size = new System.Drawing.Size(114, 24);
            this.PizzaTotalLabel.TabIndex = 5;
            this.PizzaTotalLabel.Text = "Pizza Total: ";
            // 
            // toppingImageList
            // 
            this.toppingImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toppingImageList.ImageStream")));
            this.toppingImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.toppingImageList.Images.SetKeyName(0, "crust.png");
            this.toppingImageList.Images.SetKeyName(1, "chicken.png");
            this.toppingImageList.Images.SetKeyName(2, "doublecheese.png");
            this.toppingImageList.Images.SetKeyName(3, "doublesauce.png");
            this.toppingImageList.Images.SetKeyName(4, "full.png");
            this.toppingImageList.Images.SetKeyName(5, "greenpepper.png");
            this.toppingImageList.Images.SetKeyName(6, "ham.png");
            this.toppingImageList.Images.SetKeyName(7, "jalapeno.png");
            this.toppingImageList.Images.SetKeyName(8, "left.png");
            this.toppingImageList.Images.SetKeyName(9, "mushroom.png");
            this.toppingImageList.Images.SetKeyName(10, "none.png");
            this.toppingImageList.Images.SetKeyName(11, "onion.png");
            this.toppingImageList.Images.SetKeyName(12, "pepperoni.png");
            // 
            // pbPizza
            // 
            this.pbPizza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPizza.Location = new System.Drawing.Point(364, 117);
            this.pbPizza.Name = "pbPizza";
            this.pbPizza.Size = new System.Drawing.Size(250, 250);
            this.pbPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPizza.TabIndex = 6;
            this.pbPizza.TabStop = false;
            // 
            // addToCartButton
            // 
            this.addToCartButton.BackColor = System.Drawing.Color.Gainsboro;
            this.addToCartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToCartButton.Font = new System.Drawing.Font("Sitka Subheading", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCartButton.ForeColor = System.Drawing.Color.Black;
            this.addToCartButton.Location = new System.Drawing.Point(442, 398);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(100, 25);
            this.addToCartButton.TabIndex = 7;
            this.addToCartButton.Text = "ADD TO CART";
            this.addToCartButton.UseVisualStyleBackColor = false;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // itemsInCartLabel
            // 
            this.itemsInCartLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.itemsInCartLabel.AutoSize = true;
            this.itemsInCartLabel.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsInCartLabel.Location = new System.Drawing.Point(42, 8);
            this.itemsInCartLabel.Name = "itemsInCartLabel";
            this.itemsInCartLabel.Size = new System.Drawing.Size(126, 30);
            this.itemsInCartLabel.TabIndex = 8;
            this.itemsInCartLabel.Text = "Items in Cart";
            this.itemsInCartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ordersListBox
            // 
            this.ordersListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ordersListBox.BackColor = System.Drawing.Color.RosyBrown;
            this.ordersListBox.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersListBox.FormattingEnabled = true;
            this.ordersListBox.HorizontalScrollbar = true;
            this.ordersListBox.ItemHeight = 23;
            this.ordersListBox.Location = new System.Drawing.Point(681, 141);
            this.ordersListBox.Name = "ordersListBox";
            this.ordersListBox.Size = new System.Drawing.Size(206, 280);
            this.ordersListBox.TabIndex = 9;
            this.ordersListBox.Click += new System.EventHandler(this.ordersListBox_Click);
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Font = new System.Drawing.Font("Sitka Text", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotalLabel.Location = new System.Drawing.Point(3, 12);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(120, 24);
            this.GrandTotalLabel.TabIndex = 10;
            this.GrandTotalLabel.Text = "Grand Total: ";
            // 
            // groupBoxItemsInCartText
            // 
            this.groupBoxItemsInCartText.Controls.Add(this.itemsInCartLabel);
            this.groupBoxItemsInCartText.Location = new System.Drawing.Point(681, 91);
            this.groupBoxItemsInCartText.Name = "groupBoxItemsInCartText";
            this.groupBoxItemsInCartText.Size = new System.Drawing.Size(206, 44);
            this.groupBoxItemsInCartText.TabIndex = 11;
            this.groupBoxItemsInCartText.TabStop = false;
            // 
            // groupBoxGrandTotal
            // 
            this.groupBoxGrandTotal.Controls.Add(this.GrandTotalLabel);
            this.groupBoxGrandTotal.Location = new System.Drawing.Point(681, 422);
            this.groupBoxGrandTotal.Name = "groupBoxGrandTotal";
            this.groupBoxGrandTotal.Size = new System.Drawing.Size(206, 44);
            this.groupBoxGrandTotal.TabIndex = 12;
            this.groupBoxGrandTotal.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PizzaTotalLabel);
            this.groupBox1.Location = new System.Drawing.Point(30, 421);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 44);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(900, 484);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxGrandTotal);
            this.Controls.Add(this.groupBoxItemsInCartText);
            this.Controls.Add(this.ordersListBox);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.pbPizza);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.groupBoxSizeAndCrustContainer);
            this.Controls.Add(this.groupBoxToppingsContainer);
            this.Name = "Form1";
            this.Text = "Build A Pizza";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.groupBoxSizeAndCrustContainer.ResumeLayout(false);
            this.groupBoxSizeAndCrustContainer.PerformLayout();
            this.groupBoxToppingsContainer.ResumeLayout(false);
            this.groupBoxToppingsContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filledButtonRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filledButtonLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filledButtonCenter)).EndInit();
            this.groupBoxTopping1.ResumeLayout(false);
            this.groupBoxTopping1.PerformLayout();
            this.groupBoxTopping2.ResumeLayout(false);
            this.groupBoxTopping2.PerformLayout();
            this.groupBoxTopping3.ResumeLayout(false);
            this.groupBoxTopping3.PerformLayout();
            this.groupBoxTopping4.ResumeLayout(false);
            this.groupBoxTopping4.PerformLayout();
            this.groupBoxTopping5.ResumeLayout(false);
            this.groupBoxTopping5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPizza)).EndInit();
            this.groupBoxItemsInCartText.ResumeLayout(false);
            this.groupBoxItemsInCartText.PerformLayout();
            this.groupBoxGrandTotal.ResumeLayout(false);
            this.groupBoxGrandTotal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Header;
        private System.Windows.Forms.ComboBox PizzaSize;
        private System.Windows.Forms.ComboBox CrustType;
        private System.Windows.Forms.GroupBox groupBoxSizeAndCrustContainer;
        private System.Windows.Forms.GroupBox groupBoxToppingsContainer;
        private System.Windows.Forms.Label CrustLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label ToppingsLabel;
        private System.Windows.Forms.Label OnionsLabel;
        private System.Windows.Forms.Label HamLabel;
        private System.Windows.Forms.Label PepperoniLabel;
        private System.Windows.Forms.RadioButton radioButtonPepperoniLeft;
        private System.Windows.Forms.GroupBox groupBoxTopping1;
        private System.Windows.Forms.RadioButton radioButtonPepperoniCenter;
        private System.Windows.Forms.RadioButton radioButtonPepperoniRight;
        private System.Windows.Forms.GroupBox groupBoxTopping3;
        private System.Windows.Forms.RadioButton radioButtonOnionsCenter;
        private System.Windows.Forms.RadioButton radioButtonOnionsRight;
        private System.Windows.Forms.RadioButton radioButtonOnionsLeft;
        private System.Windows.Forms.GroupBox groupBoxTopping2;
        private System.Windows.Forms.RadioButton radioButtonHamCenter;
        private System.Windows.Forms.RadioButton radioButtonHamRight;
        private System.Windows.Forms.RadioButton radioButtonHamLeft;
        private System.Windows.Forms.Label MushroomsLabel;
        private System.Windows.Forms.GroupBox groupBoxTopping4;
        private System.Windows.Forms.RadioButton radioButtonMushroomsCenter;
        private System.Windows.Forms.RadioButton radioButtonMushroomsRight;
        private System.Windows.Forms.RadioButton radioButtonMushroomsLeft;
        private System.Windows.Forms.Label JalapenosLabel;
        private System.Windows.Forms.GroupBox groupBoxTopping5;
        private System.Windows.Forms.RadioButton radioButtonJalapenosCenter;
        private System.Windows.Forms.RadioButton radioButtonJalapenosRight;
        private System.Windows.Forms.RadioButton radioButtonJalapenosLeft;
        private System.Windows.Forms.Label PizzaTotalLabel;
        private System.Windows.Forms.ImageList toppingImageList;
        private System.Windows.Forms.PictureBox pbPizza;
        private System.Windows.Forms.RadioButton radioButtonPepperoniNone;
        private System.Windows.Forms.RadioButton radioButtonHamNone;
        private System.Windows.Forms.RadioButton radioButtonOnionsNone;
        private System.Windows.Forms.RadioButton radioButtonMushroomsNone;
        private System.Windows.Forms.RadioButton radioButtonJalapenosNone;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Label itemsInCartLabel;
        private System.Windows.Forms.ListBox ordersListBox;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.RadioButton radioButtonEmptyToppingDisplay;
        private System.Windows.Forms.PictureBox filledButtonCenter;
        private System.Windows.Forms.PictureBox filledButtonLeft;
        private System.Windows.Forms.PictureBox filledButtonRight;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox groupBoxItemsInCartText;
        private System.Windows.Forms.GroupBox groupBoxGrandTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label HeaderLabel;
    }
}

