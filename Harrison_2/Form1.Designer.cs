namespace Harrison_2
{
    partial class languageOrderEntryForm
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
            this.languagePictureBox = new System.Windows.Forms.PictureBox();
            this.termGroupBox = new System.Windows.Forms.GroupBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.termLabel = new System.Windows.Forms.Label();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.springRadioButton = new System.Windows.Forms.RadioButton();
            this.fallRadioButton = new System.Windows.Forms.RadioButton();
            this.studentGroupBox = new System.Windows.Forms.GroupBox();
            this.outOfStateRadioButton = new System.Windows.Forms.RadioButton();
            this.residencyLabel = new System.Windows.Forms.Label();
            this.inStateRadioButton = new System.Windows.Forms.RadioButton();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.studentIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.courseOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.coursesLabel = new System.Windows.Forms.Label();
            this.spanishCheckBox = new System.Windows.Forms.CheckBox();
            this.russianCheckBox = new System.Windows.Forms.CheckBox();
            this.italianCheckBox = new System.Windows.Forms.CheckBox();
            this.germanCheckBox = new System.Windows.Forms.CheckBox();
            this.frenchCheckBox = new System.Windows.Forms.CheckBox();
            this.paymentGroupBox = new System.Windows.Forms.GroupBox();
            this.totalPriceOutPutLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.courseNumberOutPutLabel = new System.Windows.Forms.Label();
            this.courseNumberLabel = new System.Windows.Forms.Label();
            this.coursePriceOutPutLabel = new System.Windows.Forms.Label();
            this.coursePriceLabel = new System.Windows.Forms.Label();
            this.cardExpirationMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cardExpirationLabel = new System.Windows.Forms.Label();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.cardNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.visaRadioButton = new System.Windows.Forms.RadioButton();
            this.creditCardLabel = new System.Windows.Forms.Label();
            this.masterCardRadioButton = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.clearButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exitButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.languagePictureBox)).BeginInit();
            this.termGroupBox.SuspendLayout();
            this.studentGroupBox.SuspendLayout();
            this.courseOrderGroupBox.SuspendLayout();
            this.paymentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // languagePictureBox
            // 
            this.languagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.languagePictureBox.Image = global::Harrison_2.Properties.Resources.languageTwo;
            this.languagePictureBox.Location = new System.Drawing.Point(104, 12);
            this.languagePictureBox.Name = "languagePictureBox";
            this.languagePictureBox.Size = new System.Drawing.Size(193, 80);
            this.languagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.languagePictureBox.TabIndex = 0;
            this.languagePictureBox.TabStop = false;
            // 
            // termGroupBox
            // 
            this.termGroupBox.Controls.Add(this.yearLabel);
            this.termGroupBox.Controls.Add(this.termLabel);
            this.termGroupBox.Controls.Add(this.yearComboBox);
            this.termGroupBox.Controls.Add(this.springRadioButton);
            this.termGroupBox.Controls.Add(this.fallRadioButton);
            this.termGroupBox.Location = new System.Drawing.Point(12, 106);
            this.termGroupBox.Name = "termGroupBox";
            this.termGroupBox.Size = new System.Drawing.Size(376, 60);
            this.termGroupBox.TabIndex = 0;
            this.termGroupBox.TabStop = false;
            this.termGroupBox.Text = "Term Information";
            // 
            // yearLabel
            // 
            this.yearLabel.Location = new System.Drawing.Point(240, 23);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(33, 23);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Year:";
            this.yearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // termLabel
            // 
            this.termLabel.Location = new System.Drawing.Point(36, 23);
            this.termLabel.Name = "termLabel";
            this.termLabel.Size = new System.Drawing.Size(40, 23);
            this.termLabel.TabIndex = 0;
            this.termLabel.Text = "Term:";
            this.termLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // yearComboBox
            // 
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.yearComboBox.Location = new System.Drawing.Point(295, 25);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(52, 21);
            this.yearComboBox.TabIndex = 4;
            // 
            // springRadioButton
            // 
            this.springRadioButton.Location = new System.Drawing.Point(163, 26);
            this.springRadioButton.Name = "springRadioButton";
            this.springRadioButton.Size = new System.Drawing.Size(56, 17);
            this.springRadioButton.TabIndex = 2;
            this.springRadioButton.Text = "Spring";
            this.springRadioButton.UseVisualStyleBackColor = true;
            // 
            // fallRadioButton
            // 
            this.fallRadioButton.Checked = true;
            this.fallRadioButton.Location = new System.Drawing.Point(98, 26);
            this.fallRadioButton.Name = "fallRadioButton";
            this.fallRadioButton.Size = new System.Drawing.Size(42, 17);
            this.fallRadioButton.TabIndex = 1;
            this.fallRadioButton.TabStop = true;
            this.fallRadioButton.Text = "Fall";
            this.fallRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentGroupBox
            // 
            this.studentGroupBox.Controls.Add(this.outOfStateRadioButton);
            this.studentGroupBox.Controls.Add(this.residencyLabel);
            this.studentGroupBox.Controls.Add(this.inStateRadioButton);
            this.studentGroupBox.Controls.Add(this.emailTextBox);
            this.studentGroupBox.Controls.Add(this.emailLabel);
            this.studentGroupBox.Controls.Add(this.lastNameTextBox);
            this.studentGroupBox.Controls.Add(this.lastNameLabel);
            this.studentGroupBox.Controls.Add(this.firstNameTextBox);
            this.studentGroupBox.Controls.Add(this.firstNameLabel);
            this.studentGroupBox.Controls.Add(this.studentIDMaskedTextBox);
            this.studentGroupBox.Controls.Add(this.studentIDLabel);
            this.studentGroupBox.Location = new System.Drawing.Point(12, 172);
            this.studentGroupBox.Name = "studentGroupBox";
            this.studentGroupBox.Size = new System.Drawing.Size(376, 135);
            this.studentGroupBox.TabIndex = 1;
            this.studentGroupBox.TabStop = false;
            this.studentGroupBox.Text = "Student Information";
            // 
            // outOfStateRadioButton
            // 
            this.outOfStateRadioButton.Location = new System.Drawing.Point(282, 73);
            this.outOfStateRadioButton.Name = "outOfStateRadioButton";
            this.outOfStateRadioButton.Size = new System.Drawing.Size(87, 17);
            this.outOfStateRadioButton.TabIndex = 10;
            this.outOfStateRadioButton.Text = "Out-Of-State";
            this.outOfStateRadioButton.UseVisualStyleBackColor = true;
            this.outOfStateRadioButton.CheckedChanged += new System.EventHandler(this.outOfStateRadioButton_CheckedChanged);
            // 
            // residencyLabel
            // 
            this.residencyLabel.Location = new System.Drawing.Point(279, 21);
            this.residencyLabel.Name = "residencyLabel";
            this.residencyLabel.Size = new System.Drawing.Size(61, 21);
            this.residencyLabel.TabIndex = 8;
            this.residencyLabel.Text = "Residency:";
            this.residencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inStateRadioButton
            // 
            this.inStateRadioButton.Checked = true;
            this.inStateRadioButton.Location = new System.Drawing.Point(282, 43);
            this.inStateRadioButton.Name = "inStateRadioButton";
            this.inStateRadioButton.Size = new System.Drawing.Size(62, 17);
            this.inStateRadioButton.TabIndex = 9;
            this.inStateRadioButton.TabStop = true;
            this.inStateRadioButton.Text = "In-State";
            this.inStateRadioButton.UseVisualStyleBackColor = true;
            this.inStateRadioButton.CheckedChanged += new System.EventHandler(this.inStateRadioButton_CheckedChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(96, 100);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(189, 20);
            this.emailTextBox.TabIndex = 7;
            // 
            // emailLabel
            // 
            this.emailLabel.Location = new System.Drawing.Point(10, 102);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(77, 14);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email Address: ";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(96, 74);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(110, 20);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Location = new System.Drawing.Point(26, 73);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 21);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name:";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(96, 48);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(110, 20);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Location = new System.Drawing.Point(26, 47);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(61, 21);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name:";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // studentIDMaskedTextBox
            // 
            this.studentIDMaskedTextBox.Location = new System.Drawing.Point(96, 22);
            this.studentIDMaskedTextBox.Mask = "000-00-0000";
            this.studentIDMaskedTextBox.Name = "studentIDMaskedTextBox";
            this.studentIDMaskedTextBox.Size = new System.Drawing.Size(71, 20);
            this.studentIDMaskedTextBox.TabIndex = 1;
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.Location = new System.Drawing.Point(26, 21);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(61, 21);
            this.studentIDLabel.TabIndex = 0;
            this.studentIDLabel.Text = "Student ID:";
            this.studentIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // courseOrderGroupBox
            // 
            this.courseOrderGroupBox.Controls.Add(this.coursesLabel);
            this.courseOrderGroupBox.Controls.Add(this.spanishCheckBox);
            this.courseOrderGroupBox.Controls.Add(this.russianCheckBox);
            this.courseOrderGroupBox.Controls.Add(this.italianCheckBox);
            this.courseOrderGroupBox.Controls.Add(this.germanCheckBox);
            this.courseOrderGroupBox.Controls.Add(this.frenchCheckBox);
            this.courseOrderGroupBox.Location = new System.Drawing.Point(12, 313);
            this.courseOrderGroupBox.Name = "courseOrderGroupBox";
            this.courseOrderGroupBox.Size = new System.Drawing.Size(376, 100);
            this.courseOrderGroupBox.TabIndex = 2;
            this.courseOrderGroupBox.TabStop = false;
            this.courseOrderGroupBox.Text = "Course Order Information";
            // 
            // coursesLabel
            // 
            this.coursesLabel.Location = new System.Drawing.Point(5, 18);
            this.coursesLabel.Name = "coursesLabel";
            this.coursesLabel.Size = new System.Drawing.Size(155, 16);
            this.coursesLabel.TabIndex = 0;
            this.coursesLabel.Text = "Courses (Maximum of Three):";
            this.coursesLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // spanishCheckBox
            // 
            this.spanishCheckBox.Location = new System.Drawing.Point(131, 70);
            this.spanishCheckBox.Name = "spanishCheckBox";
            this.spanishCheckBox.Size = new System.Drawing.Size(123, 24);
            this.spanishCheckBox.TabIndex = 4;
            this.spanishCheckBox.Text = "Beginning Spanish";
            this.spanishCheckBox.UseVisualStyleBackColor = true;
            this.spanishCheckBox.CheckedChanged += new System.EventHandler(this.frenchCheckBox_CheckedChanged);
            // 
            // russianCheckBox
            // 
            this.russianCheckBox.Location = new System.Drawing.Point(131, 40);
            this.russianCheckBox.Name = "russianCheckBox";
            this.russianCheckBox.Size = new System.Drawing.Size(123, 24);
            this.russianCheckBox.TabIndex = 3;
            this.russianCheckBox.Text = "Beginning Russian";
            this.russianCheckBox.UseVisualStyleBackColor = true;
            this.russianCheckBox.CheckedChanged += new System.EventHandler(this.frenchCheckBox_CheckedChanged);
            // 
            // italianCheckBox
            // 
            this.italianCheckBox.Location = new System.Drawing.Point(259, 40);
            this.italianCheckBox.Name = "italianCheckBox";
            this.italianCheckBox.Size = new System.Drawing.Size(112, 24);
            this.italianCheckBox.TabIndex = 5;
            this.italianCheckBox.Text = "Beginning Italian";
            this.italianCheckBox.UseVisualStyleBackColor = true;
            this.italianCheckBox.CheckedChanged += new System.EventHandler(this.frenchCheckBox_CheckedChanged);
            // 
            // germanCheckBox
            // 
            this.germanCheckBox.Location = new System.Drawing.Point(13, 70);
            this.germanCheckBox.Name = "germanCheckBox";
            this.germanCheckBox.Size = new System.Drawing.Size(123, 24);
            this.germanCheckBox.TabIndex = 2;
            this.germanCheckBox.Text = "Beginning German";
            this.germanCheckBox.UseVisualStyleBackColor = true;
            this.germanCheckBox.CheckedChanged += new System.EventHandler(this.frenchCheckBox_CheckedChanged);
            // 
            // frenchCheckBox
            // 
            this.frenchCheckBox.Location = new System.Drawing.Point(13, 40);
            this.frenchCheckBox.Name = "frenchCheckBox";
            this.frenchCheckBox.Size = new System.Drawing.Size(112, 24);
            this.frenchCheckBox.TabIndex = 1;
            this.frenchCheckBox.Text = "Beginning French";
            this.frenchCheckBox.UseVisualStyleBackColor = true;
            this.frenchCheckBox.CheckedChanged += new System.EventHandler(this.frenchCheckBox_CheckedChanged);
            // 
            // paymentGroupBox
            // 
            this.paymentGroupBox.Controls.Add(this.totalPriceOutPutLabel);
            this.paymentGroupBox.Controls.Add(this.totalPriceLabel);
            this.paymentGroupBox.Controls.Add(this.courseNumberOutPutLabel);
            this.paymentGroupBox.Controls.Add(this.courseNumberLabel);
            this.paymentGroupBox.Controls.Add(this.coursePriceOutPutLabel);
            this.paymentGroupBox.Controls.Add(this.coursePriceLabel);
            this.paymentGroupBox.Controls.Add(this.cardExpirationMaskedTextBox);
            this.paymentGroupBox.Controls.Add(this.cardExpirationLabel);
            this.paymentGroupBox.Controls.Add(this.cardNumberLabel);
            this.paymentGroupBox.Controls.Add(this.cardNumberMaskedTextBox);
            this.paymentGroupBox.Controls.Add(this.visaRadioButton);
            this.paymentGroupBox.Controls.Add(this.creditCardLabel);
            this.paymentGroupBox.Controls.Add(this.masterCardRadioButton);
            this.paymentGroupBox.Location = new System.Drawing.Point(12, 419);
            this.paymentGroupBox.Name = "paymentGroupBox";
            this.paymentGroupBox.Size = new System.Drawing.Size(376, 165);
            this.paymentGroupBox.TabIndex = 3;
            this.paymentGroupBox.TabStop = false;
            this.paymentGroupBox.Text = "Payment Information";
            // 
            // totalPriceOutPutLabel
            // 
            this.totalPriceOutPutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceOutPutLabel.Location = new System.Drawing.Point(291, 123);
            this.totalPriceOutPutLabel.Name = "totalPriceOutPutLabel";
            this.totalPriceOutPutLabel.Size = new System.Drawing.Size(64, 26);
            this.totalPriceOutPutLabel.TabIndex = 12;
            this.totalPriceOutPutLabel.Text = "PRICE";
            this.totalPriceOutPutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.Location = new System.Drawing.Point(281, 106);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(87, 16);
            this.totalPriceLabel.TabIndex = 11;
            this.totalPriceLabel.Text = "TOTAL PRICE:";
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // courseNumberOutPutLabel
            // 
            this.courseNumberOutPutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.courseNumberOutPutLabel.Location = new System.Drawing.Point(23, 123);
            this.courseNumberOutPutLabel.Name = "courseNumberOutPutLabel";
            this.courseNumberOutPutLabel.Size = new System.Drawing.Size(64, 26);
            this.courseNumberOutPutLabel.TabIndex = 8;
            this.courseNumberOutPutLabel.Text = "NUMBER";
            this.courseNumberOutPutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // courseNumberLabel
            // 
            this.courseNumberLabel.Location = new System.Drawing.Point(9, 106);
            this.courseNumberLabel.Name = "courseNumberLabel";
            this.courseNumberLabel.Size = new System.Drawing.Size(103, 16);
            this.courseNumberLabel.TabIndex = 7;
            this.courseNumberLabel.Text = "Number of Courses:";
            this.courseNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coursePriceOutPutLabel
            // 
            this.coursePriceOutPutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coursePriceOutPutLabel.Location = new System.Drawing.Point(157, 123);
            this.coursePriceOutPutLabel.Name = "coursePriceOutPutLabel";
            this.coursePriceOutPutLabel.Size = new System.Drawing.Size(64, 26);
            this.coursePriceOutPutLabel.TabIndex = 10;
            this.coursePriceOutPutLabel.Text = "PRICE";
            this.coursePriceOutPutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // coursePriceLabel
            // 
            this.coursePriceLabel.Location = new System.Drawing.Point(149, 107);
            this.coursePriceLabel.Name = "coursePriceLabel";
            this.coursePriceLabel.Size = new System.Drawing.Size(89, 16);
            this.coursePriceLabel.TabIndex = 9;
            this.coursePriceLabel.Text = "Price per Course:  ";
            this.coursePriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardExpirationMaskedTextBox
            // 
            this.cardExpirationMaskedTextBox.Location = new System.Drawing.Point(96, 75);
            this.cardExpirationMaskedTextBox.Mask = "00/00/0000";
            this.cardExpirationMaskedTextBox.Name = "cardExpirationMaskedTextBox";
            this.cardExpirationMaskedTextBox.Size = new System.Drawing.Size(71, 20);
            this.cardExpirationMaskedTextBox.TabIndex = 6;
            this.cardExpirationMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // cardExpirationLabel
            // 
            this.cardExpirationLabel.Location = new System.Drawing.Point(9, 76);
            this.cardExpirationLabel.Name = "cardExpirationLabel";
            this.cardExpirationLabel.Size = new System.Drawing.Size(81, 16);
            this.cardExpirationLabel.TabIndex = 5;
            this.cardExpirationLabel.Text = "Card Expiration:";
            this.cardExpirationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.Location = new System.Drawing.Point(15, 48);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(79, 16);
            this.cardNumberLabel.TabIndex = 3;
            this.cardNumberLabel.Text = "Card Number:";
            this.cardNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardNumberMaskedTextBox
            // 
            this.cardNumberMaskedTextBox.Location = new System.Drawing.Point(96, 47);
            this.cardNumberMaskedTextBox.Mask = "0000000000000000";
            this.cardNumberMaskedTextBox.Name = "cardNumberMaskedTextBox";
            this.cardNumberMaskedTextBox.Size = new System.Drawing.Size(104, 20);
            this.cardNumberMaskedTextBox.TabIndex = 4;
            // 
            // visaRadioButton
            // 
            this.visaRadioButton.Location = new System.Drawing.Point(192, 20);
            this.visaRadioButton.Name = "visaRadioButton";
            this.visaRadioButton.Size = new System.Drawing.Size(45, 17);
            this.visaRadioButton.TabIndex = 2;
            this.visaRadioButton.Text = "Visa";
            this.visaRadioButton.UseVisualStyleBackColor = true;
            // 
            // creditCardLabel
            // 
            this.creditCardLabel.Location = new System.Drawing.Point(25, 20);
            this.creditCardLabel.Name = "creditCardLabel";
            this.creditCardLabel.Size = new System.Drawing.Size(69, 16);
            this.creditCardLabel.TabIndex = 0;
            this.creditCardLabel.Text = "Credit Card:";
            this.creditCardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // masterCardRadioButton
            // 
            this.masterCardRadioButton.Checked = true;
            this.masterCardRadioButton.Location = new System.Drawing.Point(97, 20);
            this.masterCardRadioButton.Name = "masterCardRadioButton";
            this.masterCardRadioButton.Size = new System.Drawing.Size(79, 17);
            this.masterCardRadioButton.TabIndex = 1;
            this.masterCardRadioButton.TabStop = true;
            this.masterCardRadioButton.Text = "MasterCard";
            this.masterCardRadioButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Location = new System.Drawing.Point(37, 599);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(65, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "&Save";
            this.saveButtonToolTip.SetToolTip(this.saveButton, "Click to Save the Order");
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Location = new System.Drawing.Point(168, 599);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(65, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clea&r";
            this.clearButtonToolTip.SetToolTip(this.clearButton, "Click to Empty the Order");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Location = new System.Drawing.Point(299, 599);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(65, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.exitButtonToolTip.SetToolTip(this.exitButton, "Click to Exit the Order-Entry");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // languageOrderEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 634);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.paymentGroupBox);
            this.Controls.Add(this.courseOrderGroupBox);
            this.Controls.Add(this.studentGroupBox);
            this.Controls.Add(this.termGroupBox);
            this.Controls.Add(this.languagePictureBox);
            this.Name = "languageOrderEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAI Software Order-Entry";
            this.Load += new System.EventHandler(this.languageOrderEntryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.languagePictureBox)).EndInit();
            this.termGroupBox.ResumeLayout(false);
            this.studentGroupBox.ResumeLayout(false);
            this.studentGroupBox.PerformLayout();
            this.courseOrderGroupBox.ResumeLayout(false);
            this.paymentGroupBox.ResumeLayout(false);
            this.paymentGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox languagePictureBox;
        private System.Windows.Forms.GroupBox termGroupBox;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.RadioButton springRadioButton;
        private System.Windows.Forms.RadioButton fallRadioButton;
        private System.Windows.Forms.Label termLabel;
        private System.Windows.Forms.GroupBox studentGroupBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.MaskedTextBox studentIDMaskedTextBox;
        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.RadioButton outOfStateRadioButton;
        private System.Windows.Forms.Label residencyLabel;
        private System.Windows.Forms.RadioButton inStateRadioButton;
        private System.Windows.Forms.GroupBox courseOrderGroupBox;
        private System.Windows.Forms.CheckBox germanCheckBox;
        private System.Windows.Forms.CheckBox frenchCheckBox;
        private System.Windows.Forms.CheckBox russianCheckBox;
        private System.Windows.Forms.CheckBox italianCheckBox;
        private System.Windows.Forms.Label coursesLabel;
        private System.Windows.Forms.CheckBox spanishCheckBox;
        private System.Windows.Forms.GroupBox paymentGroupBox;
        private System.Windows.Forms.MaskedTextBox cardNumberMaskedTextBox;
        private System.Windows.Forms.RadioButton visaRadioButton;
        private System.Windows.Forms.Label creditCardLabel;
        private System.Windows.Forms.RadioButton masterCardRadioButton;
        private System.Windows.Forms.Label cardNumberLabel;
        private System.Windows.Forms.MaskedTextBox cardExpirationMaskedTextBox;
        private System.Windows.Forms.Label cardExpirationLabel;
        private System.Windows.Forms.Label totalPriceOutPutLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label courseNumberOutPutLabel;
        private System.Windows.Forms.Label courseNumberLabel;
        private System.Windows.Forms.Label coursePriceOutPutLabel;
        private System.Windows.Forms.Label coursePriceLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolTip saveButtonToolTip;
        private System.Windows.Forms.ToolTip clearButtonToolTip;
        private System.Windows.Forms.ToolTip exitButtonToolTip;
    }
}

