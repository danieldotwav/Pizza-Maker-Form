namespace LAB_11._2_DANIEL_RIVAS
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
            this.Header = new System.Windows.Forms.GroupBox();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.PizzaSize = new System.Windows.Forms.ComboBox();
            this.CrustType = new System.Windows.Forms.ComboBox();
            this.groupBoxSizeAndCrustContainer = new System.Windows.Forms.GroupBox();
            this.CrustLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.groupBoxToppingsContainer = new System.Windows.Forms.GroupBox();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.JalepenosLabel = new System.Windows.Forms.Label();
            this.MushroomsLabel = new System.Windows.Forms.Label();
            this.SausageLabel = new System.Windows.Forms.Label();
            this.HamLabel = new System.Windows.Forms.Label();
            this.PepperoniLabel = new System.Windows.Forms.Label();
            this.ToppingsLabel = new System.Windows.Forms.Label();
            this.groupBoxTopping1 = new System.Windows.Forms.GroupBox();
            this.radioButtonPepperoniRight = new System.Windows.Forms.RadioButton();
            this.radioButtonPepperoniCenter = new System.Windows.Forms.RadioButton();
            this.radioButtonPepperoniLeft = new System.Windows.Forms.RadioButton();
            this.groupBoxTopping2 = new System.Windows.Forms.GroupBox();
            this.radioButtonHamCenter = new System.Windows.Forms.RadioButton();
            this.radioButtonHamRight = new System.Windows.Forms.RadioButton();
            this.radioButtonHamLeft = new System.Windows.Forms.RadioButton();
            this.groupBoxTopping3 = new System.Windows.Forms.GroupBox();
            this.radioButtonSausageCenter = new System.Windows.Forms.RadioButton();
            this.radioButtonSausageRight = new System.Windows.Forms.RadioButton();
            this.radioButtonSausageLeft = new System.Windows.Forms.RadioButton();
            this.groupBoxTopping4 = new System.Windows.Forms.GroupBox();
            this.radioButtonMushroomsCenter = new System.Windows.Forms.RadioButton();
            this.radioButtonMushroomsRight = new System.Windows.Forms.RadioButton();
            this.radioButtonMushroomsLeft = new System.Windows.Forms.RadioButton();
            this.groupBoxTopping5 = new System.Windows.Forms.GroupBox();
            this.radioButtonJalepenosCenter = new System.Windows.Forms.RadioButton();
            this.radioButtonJalepenosRight = new System.Windows.Forms.RadioButton();
            this.radioButtonJalepenosLeft = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Header.SuspendLayout();
            this.groupBoxSizeAndCrustContainer.SuspendLayout();
            this.groupBoxToppingsContainer.SuspendLayout();
            this.groupBoxTopping1.SuspendLayout();
            this.groupBoxTopping2.SuspendLayout();
            this.groupBoxTopping3.SuspendLayout();
            this.groupBoxTopping4.SuspendLayout();
            this.groupBoxTopping5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Header.BackColor = System.Drawing.Color.Black;
            this.Header.Controls.Add(this.HeaderLabel);
            this.Header.Location = new System.Drawing.Point(-7, -6);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(920, 89);
            this.Header.TabIndex = 0;
            this.Header.TabStop = false;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HeaderLabel.Font = new System.Drawing.Font("Pleatures Demo", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.Snow;
            this.HeaderLabel.Location = new System.Drawing.Point(154, 32);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(604, 38);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Build A Pizza by Slice Slice Baby";
            // 
            // PizzaSize
            // 
            this.PizzaSize.AllowDrop = true;
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
            this.CrustType.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrustType.FormattingEnabled = true;
            this.CrustType.Location = new System.Drawing.Point(138, 66);
            this.CrustType.Name = "CrustType";
            this.CrustType.Size = new System.Drawing.Size(70, 24);
            this.CrustType.TabIndex = 2;
            this.CrustType.SelectedIndexChanged += new System.EventHandler(this.CrustType_SelectedIndexChanged);
            // 
            // groupBoxSizeAndCrustContainer
            // 
            this.groupBoxSizeAndCrustContainer.Controls.Add(this.CrustLabel);
            this.groupBoxSizeAndCrustContainer.Controls.Add(this.SizeLabel);
            this.groupBoxSizeAndCrustContainer.Controls.Add(this.CrustType);
            this.groupBoxSizeAndCrustContainer.Controls.Add(this.PizzaSize);
            this.groupBoxSizeAndCrustContainer.Location = new System.Drawing.Point(30, 99);
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
            this.groupBoxToppingsContainer.Controls.Add(this.JalepenosLabel);
            this.groupBoxToppingsContainer.Controls.Add(this.MushroomsLabel);
            this.groupBoxToppingsContainer.Controls.Add(this.SausageLabel);
            this.groupBoxToppingsContainer.Controls.Add(this.HamLabel);
            this.groupBoxToppingsContainer.Controls.Add(this.PepperoniLabel);
            this.groupBoxToppingsContainer.Controls.Add(this.ToppingsLabel);
            this.groupBoxToppingsContainer.Controls.Add(this.groupBoxTopping1);
            this.groupBoxToppingsContainer.Controls.Add(this.groupBoxTopping2);
            this.groupBoxToppingsContainer.Controls.Add(this.groupBoxTopping3);
            this.groupBoxToppingsContainer.Controls.Add(this.groupBoxTopping4);
            this.groupBoxToppingsContainer.Controls.Add(this.groupBoxTopping5);
            this.groupBoxToppingsContainer.Location = new System.Drawing.Point(30, 220);
            this.groupBoxToppingsContainer.Name = "groupBoxToppingsContainer";
            this.groupBoxToppingsContainer.Size = new System.Drawing.Size(259, 227);
            this.groupBoxToppingsContainer.TabIndex = 4;
            this.groupBoxToppingsContainer.TabStop = false;
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Sitka Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceLabel.Location = new System.Drawing.Point(40, 448);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(71, 28);
            this.TotalPriceLabel.TabIndex = 5;
            this.TotalPriceLabel.Text = "Total: ";
            // 
            // JalepenosLabel
            // 
            this.JalepenosLabel.AutoEllipsis = true;
            this.JalepenosLabel.AutoSize = true;
            this.JalepenosLabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JalepenosLabel.Location = new System.Drawing.Point(15, 173);
            this.JalepenosLabel.Name = "JalepenosLabel";
            this.JalepenosLabel.Size = new System.Drawing.Size(81, 23);
            this.JalepenosLabel.TabIndex = 15;
            this.JalepenosLabel.Text = "Jalepenos";
            this.JalepenosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MushroomsLabel
            // 
            this.MushroomsLabel.AutoSize = true;
            this.MushroomsLabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MushroomsLabel.Location = new System.Drawing.Point(15, 150);
            this.MushroomsLabel.Name = "MushroomsLabel";
            this.MushroomsLabel.Size = new System.Drawing.Size(97, 23);
            this.MushroomsLabel.TabIndex = 13;
            this.MushroomsLabel.Text = "Mushrooms";
            this.MushroomsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SausageLabel
            // 
            this.SausageLabel.AutoSize = true;
            this.SausageLabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SausageLabel.Location = new System.Drawing.Point(15, 127);
            this.SausageLabel.Name = "SausageLabel";
            this.SausageLabel.Size = new System.Drawing.Size(71, 23);
            this.SausageLabel.TabIndex = 7;
            this.SausageLabel.Text = "Sausage";
            this.SausageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HamLabel
            // 
            this.HamLabel.AutoSize = true;
            this.HamLabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HamLabel.Location = new System.Drawing.Point(15, 104);
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
            this.PepperoniLabel.Location = new System.Drawing.Point(15, 81);
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
            this.ToppingsLabel.Location = new System.Drawing.Point(15, 24);
            this.ToppingsLabel.Name = "ToppingsLabel";
            this.ToppingsLabel.Size = new System.Drawing.Size(173, 23);
            this.ToppingsLabel.TabIndex = 5;
            this.ToppingsLabel.Text = "Toppings ($2.00 ea.)";
            this.ToppingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxTopping1
            // 
            this.groupBoxTopping1.Controls.Add(this.radioButtonPepperoniRight);
            this.groupBoxTopping1.Controls.Add(this.radioButtonPepperoniCenter);
            this.groupBoxTopping1.Controls.Add(this.radioButtonPepperoniLeft);
            this.groupBoxTopping1.Location = new System.Drawing.Point(123, 77);
            this.groupBoxTopping1.Name = "groupBoxTopping1";
            this.groupBoxTopping1.Size = new System.Drawing.Size(75, 30);
            this.groupBoxTopping1.TabIndex = 9;
            this.groupBoxTopping1.TabStop = false;
            // 
            // radioButtonPepperoniRight
            // 
            this.radioButtonPepperoniRight.AutoSize = true;
            this.radioButtonPepperoniRight.Location = new System.Drawing.Point(55, 11);
            this.radioButtonPepperoniRight.Name = "radioButtonPepperoniRight";
            this.radioButtonPepperoniRight.Size = new System.Drawing.Size(14, 13);
            this.radioButtonPepperoniRight.TabIndex = 10;
            this.radioButtonPepperoniRight.TabStop = true;
            this.radioButtonPepperoniRight.UseVisualStyleBackColor = true;
            // 
            // radioButtonPepperoniCenter
            // 
            this.radioButtonPepperoniCenter.AutoSize = true;
            this.radioButtonPepperoniCenter.Location = new System.Drawing.Point(30, 11);
            this.radioButtonPepperoniCenter.Name = "radioButtonPepperoniCenter";
            this.radioButtonPepperoniCenter.Size = new System.Drawing.Size(14, 13);
            this.radioButtonPepperoniCenter.TabIndex = 9;
            this.radioButtonPepperoniCenter.TabStop = true;
            this.radioButtonPepperoniCenter.UseVisualStyleBackColor = true;
            // 
            // radioButtonPepperoniLeft
            // 
            this.radioButtonPepperoniLeft.AutoSize = true;
            this.radioButtonPepperoniLeft.Location = new System.Drawing.Point(5, 11);
            this.radioButtonPepperoniLeft.Name = "radioButtonPepperoniLeft";
            this.radioButtonPepperoniLeft.Size = new System.Drawing.Size(14, 13);
            this.radioButtonPepperoniLeft.TabIndex = 8;
            this.radioButtonPepperoniLeft.TabStop = true;
            this.radioButtonPepperoniLeft.UseVisualStyleBackColor = true;
            // 
            // groupBoxTopping2
            // 
            this.groupBoxTopping2.Controls.Add(this.radioButtonHamCenter);
            this.groupBoxTopping2.Controls.Add(this.radioButtonHamRight);
            this.groupBoxTopping2.Controls.Add(this.radioButtonHamLeft);
            this.groupBoxTopping2.Location = new System.Drawing.Point(123, 100);
            this.groupBoxTopping2.Name = "groupBoxTopping2";
            this.groupBoxTopping2.Size = new System.Drawing.Size(75, 30);
            this.groupBoxTopping2.TabIndex = 11;
            this.groupBoxTopping2.TabStop = false;
            // 
            // radioButtonHamCenter
            // 
            this.radioButtonHamCenter.AutoSize = true;
            this.radioButtonHamCenter.Location = new System.Drawing.Point(30, 11);
            this.radioButtonHamCenter.Name = "radioButtonHamCenter";
            this.radioButtonHamCenter.Size = new System.Drawing.Size(14, 13);
            this.radioButtonHamCenter.TabIndex = 9;
            this.radioButtonHamCenter.TabStop = true;
            this.radioButtonHamCenter.UseVisualStyleBackColor = true;
            // 
            // radioButtonHamRight
            // 
            this.radioButtonHamRight.AutoSize = true;
            this.radioButtonHamRight.Location = new System.Drawing.Point(55, 11);
            this.radioButtonHamRight.Name = "radioButtonHamRight";
            this.radioButtonHamRight.Size = new System.Drawing.Size(14, 13);
            this.radioButtonHamRight.TabIndex = 10;
            this.radioButtonHamRight.TabStop = true;
            this.radioButtonHamRight.UseVisualStyleBackColor = true;
            // 
            // radioButtonHamLeft
            // 
            this.radioButtonHamLeft.AutoSize = true;
            this.radioButtonHamLeft.Location = new System.Drawing.Point(5, 11);
            this.radioButtonHamLeft.Name = "radioButtonHamLeft";
            this.radioButtonHamLeft.Size = new System.Drawing.Size(14, 13);
            this.radioButtonHamLeft.TabIndex = 8;
            this.radioButtonHamLeft.TabStop = true;
            this.radioButtonHamLeft.UseVisualStyleBackColor = true;
            // 
            // groupBoxTopping3
            // 
            this.groupBoxTopping3.Controls.Add(this.radioButtonSausageCenter);
            this.groupBoxTopping3.Controls.Add(this.radioButtonSausageRight);
            this.groupBoxTopping3.Controls.Add(this.radioButtonSausageLeft);
            this.groupBoxTopping3.Location = new System.Drawing.Point(123, 123);
            this.groupBoxTopping3.Name = "groupBoxTopping3";
            this.groupBoxTopping3.Size = new System.Drawing.Size(75, 30);
            this.groupBoxTopping3.TabIndex = 12;
            this.groupBoxTopping3.TabStop = false;
            // 
            // radioButtonSausageCenter
            // 
            this.radioButtonSausageCenter.AutoSize = true;
            this.radioButtonSausageCenter.Location = new System.Drawing.Point(30, 11);
            this.radioButtonSausageCenter.Name = "radioButtonSausageCenter";
            this.radioButtonSausageCenter.Size = new System.Drawing.Size(14, 13);
            this.radioButtonSausageCenter.TabIndex = 9;
            this.radioButtonSausageCenter.TabStop = true;
            this.radioButtonSausageCenter.UseVisualStyleBackColor = true;
            // 
            // radioButtonSausageRight
            // 
            this.radioButtonSausageRight.AutoSize = true;
            this.radioButtonSausageRight.Location = new System.Drawing.Point(55, 11);
            this.radioButtonSausageRight.Name = "radioButtonSausageRight";
            this.radioButtonSausageRight.Size = new System.Drawing.Size(14, 13);
            this.radioButtonSausageRight.TabIndex = 10;
            this.radioButtonSausageRight.TabStop = true;
            this.radioButtonSausageRight.UseVisualStyleBackColor = true;
            // 
            // radioButtonSausageLeft
            // 
            this.radioButtonSausageLeft.AutoSize = true;
            this.radioButtonSausageLeft.Location = new System.Drawing.Point(5, 11);
            this.radioButtonSausageLeft.Name = "radioButtonSausageLeft";
            this.radioButtonSausageLeft.Size = new System.Drawing.Size(14, 13);
            this.radioButtonSausageLeft.TabIndex = 8;
            this.radioButtonSausageLeft.TabStop = true;
            this.radioButtonSausageLeft.UseVisualStyleBackColor = true;
            // 
            // groupBoxTopping4
            // 
            this.groupBoxTopping4.Controls.Add(this.radioButtonMushroomsCenter);
            this.groupBoxTopping4.Controls.Add(this.radioButtonMushroomsRight);
            this.groupBoxTopping4.Controls.Add(this.radioButtonMushroomsLeft);
            this.groupBoxTopping4.Location = new System.Drawing.Point(123, 146);
            this.groupBoxTopping4.Name = "groupBoxTopping4";
            this.groupBoxTopping4.Size = new System.Drawing.Size(75, 30);
            this.groupBoxTopping4.TabIndex = 14;
            this.groupBoxTopping4.TabStop = false;
            // 
            // radioButtonMushroomsCenter
            // 
            this.radioButtonMushroomsCenter.AutoSize = true;
            this.radioButtonMushroomsCenter.Location = new System.Drawing.Point(30, 11);
            this.radioButtonMushroomsCenter.Name = "radioButtonMushroomsCenter";
            this.radioButtonMushroomsCenter.Size = new System.Drawing.Size(14, 13);
            this.radioButtonMushroomsCenter.TabIndex = 9;
            this.radioButtonMushroomsCenter.TabStop = true;
            this.radioButtonMushroomsCenter.UseVisualStyleBackColor = true;
            // 
            // radioButtonMushroomsRight
            // 
            this.radioButtonMushroomsRight.AutoSize = true;
            this.radioButtonMushroomsRight.Location = new System.Drawing.Point(55, 11);
            this.radioButtonMushroomsRight.Name = "radioButtonMushroomsRight";
            this.radioButtonMushroomsRight.Size = new System.Drawing.Size(14, 13);
            this.radioButtonMushroomsRight.TabIndex = 10;
            this.radioButtonMushroomsRight.TabStop = true;
            this.radioButtonMushroomsRight.UseVisualStyleBackColor = true;
            // 
            // radioButtonMushroomsLeft
            // 
            this.radioButtonMushroomsLeft.AutoSize = true;
            this.radioButtonMushroomsLeft.Location = new System.Drawing.Point(5, 11);
            this.radioButtonMushroomsLeft.Name = "radioButtonMushroomsLeft";
            this.radioButtonMushroomsLeft.Size = new System.Drawing.Size(14, 13);
            this.radioButtonMushroomsLeft.TabIndex = 8;
            this.radioButtonMushroomsLeft.TabStop = true;
            this.radioButtonMushroomsLeft.UseVisualStyleBackColor = true;
            // 
            // groupBoxTopping5
            // 
            this.groupBoxTopping5.Controls.Add(this.radioButtonJalepenosCenter);
            this.groupBoxTopping5.Controls.Add(this.radioButtonJalepenosRight);
            this.groupBoxTopping5.Controls.Add(this.radioButtonJalepenosLeft);
            this.groupBoxTopping5.Location = new System.Drawing.Point(123, 169);
            this.groupBoxTopping5.Name = "groupBoxTopping5";
            this.groupBoxTopping5.Size = new System.Drawing.Size(75, 30);
            this.groupBoxTopping5.TabIndex = 15;
            this.groupBoxTopping5.TabStop = false;
            // 
            // radioButtonJalepenosCenter
            // 
            this.radioButtonJalepenosCenter.AutoSize = true;
            this.radioButtonJalepenosCenter.Location = new System.Drawing.Point(30, 11);
            this.radioButtonJalepenosCenter.Name = "radioButtonJalepenosCenter";
            this.radioButtonJalepenosCenter.Size = new System.Drawing.Size(14, 13);
            this.radioButtonJalepenosCenter.TabIndex = 9;
            this.radioButtonJalepenosCenter.TabStop = true;
            this.radioButtonJalepenosCenter.UseVisualStyleBackColor = true;
            // 
            // radioButtonJalepenosRight
            // 
            this.radioButtonJalepenosRight.AutoSize = true;
            this.radioButtonJalepenosRight.Location = new System.Drawing.Point(55, 11);
            this.radioButtonJalepenosRight.Name = "radioButtonJalepenosRight";
            this.radioButtonJalepenosRight.Size = new System.Drawing.Size(14, 13);
            this.radioButtonJalepenosRight.TabIndex = 10;
            this.radioButtonJalepenosRight.TabStop = true;
            this.radioButtonJalepenosRight.UseVisualStyleBackColor = true;
            // 
            // radioButtonJalepenosLeft
            // 
            this.radioButtonJalepenosLeft.AutoSize = true;
            this.radioButtonJalepenosLeft.Location = new System.Drawing.Point(5, 11);
            this.radioButtonJalepenosLeft.Name = "radioButtonJalepenosLeft";
            this.radioButtonJalepenosLeft.Size = new System.Drawing.Size(14, 13);
            this.radioButtonJalepenosLeft.TabIndex = 8;
            this.radioButtonJalepenosLeft.TabStop = true;
            this.radioButtonJalepenosLeft.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 484);
            this.Controls.Add(this.TotalPriceLabel);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Header;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.ComboBox PizzaSize;
        private System.Windows.Forms.ComboBox CrustType;
        private System.Windows.Forms.GroupBox groupBoxSizeAndCrustContainer;
        private System.Windows.Forms.GroupBox groupBoxToppingsContainer;
        private System.Windows.Forms.Label CrustLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label ToppingsLabel;
        private System.Windows.Forms.Label SausageLabel;
        private System.Windows.Forms.Label HamLabel;
        private System.Windows.Forms.Label PepperoniLabel;
        private System.Windows.Forms.RadioButton radioButtonPepperoniLeft;
        private System.Windows.Forms.GroupBox groupBoxTopping1;
        private System.Windows.Forms.RadioButton radioButtonPepperoniCenter;
        private System.Windows.Forms.RadioButton radioButtonPepperoniRight;
        private System.Windows.Forms.GroupBox groupBoxTopping3;
        private System.Windows.Forms.RadioButton radioButtonSausageCenter;
        private System.Windows.Forms.RadioButton radioButtonSausageRight;
        private System.Windows.Forms.RadioButton radioButtonSausageLeft;
        private System.Windows.Forms.GroupBox groupBoxTopping2;
        private System.Windows.Forms.RadioButton radioButtonHamCenter;
        private System.Windows.Forms.RadioButton radioButtonHamRight;
        private System.Windows.Forms.RadioButton radioButtonHamLeft;
        private System.Windows.Forms.Label MushroomsLabel;
        private System.Windows.Forms.GroupBox groupBoxTopping4;
        private System.Windows.Forms.RadioButton radioButtonMushroomsCenter;
        private System.Windows.Forms.RadioButton radioButtonMushroomsRight;
        private System.Windows.Forms.RadioButton radioButtonMushroomsLeft;
        private System.Windows.Forms.Label JalepenosLabel;
        private System.Windows.Forms.GroupBox groupBoxTopping5;
        private System.Windows.Forms.RadioButton radioButtonJalepenosCenter;
        private System.Windows.Forms.RadioButton radioButtonJalepenosRight;
        private System.Windows.Forms.RadioButton radioButtonJalepenosLeft;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.ImageList imageList1;
    }
}

