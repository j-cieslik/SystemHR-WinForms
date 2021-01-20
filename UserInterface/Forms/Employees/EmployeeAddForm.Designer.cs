
namespace SystemHR.UserInterface.Forms.Employees
{
    partial class EmployeeAddForm
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
            this.lblEmployee = new System.Windows.Forms.Label();
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.txtPesel = new System.Windows.Forms.TextBox();
            this.lblPesel = new System.Windows.Forms.Label();
            this.dtpDateBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDateBirth = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.bsGender = new System.Windows.Forms.BindingSource(this.components);
            this.lblGender = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.pbEmployee = new System.Windows.Forms.PictureBox();
            this.gbContact = new System.Windows.Forms.GroupBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.gbIdentityCard = new System.Windows.Forms.GroupBox();
            this.dtpExpirationDateIdentityCard = new System.Windows.Forms.DateTimePicker();
            this.lblExpirationDateIdentityCard = new System.Windows.Forms.Label();
            this.dtpIssueDateIdentityCard = new System.Windows.Forms.DateTimePicker();
            this.lblIssueDateIdentityCard = new System.Windows.Forms.Label();
            this.txtIdentityCardNumber = new System.Windows.Forms.TextBox();
            this.lblIdentityCardNumber = new System.Windows.Forms.Label();
            this.gbPassport = new System.Windows.Forms.GroupBox();
            this.dtpExpirationDatePassport = new System.Windows.Forms.DateTimePicker();
            this.lblExpirationDatePassport = new System.Windows.Forms.Label();
            this.dtpIssueDatePassport = new System.Windows.Forms.DateTimePicker();
            this.lblIssueDatePassport = new System.Windows.Forms.Label();
            this.txtPassportNumber = new System.Windows.Forms.TextBox();
            this.lblPasswordNumber = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.epLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPESEL = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            this.gbContact.SuspendLayout();
            this.gbIdentityCard.SuspendLayout();
            this.gbPassport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPESEL)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmployee.Location = new System.Drawing.Point(25, 39);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(206, 30);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "Dane identyfikacyjne";
            // 
            // gbGeneral
            // 
            this.gbGeneral.Controls.Add(this.txtPesel);
            this.gbGeneral.Controls.Add(this.lblPesel);
            this.gbGeneral.Controls.Add(this.dtpDateBirth);
            this.gbGeneral.Controls.Add(this.lblDateBirth);
            this.gbGeneral.Controls.Add(this.cbGender);
            this.gbGeneral.Controls.Add(this.lblGender);
            this.gbGeneral.Controls.Add(this.txtFirstName);
            this.gbGeneral.Controls.Add(this.txtLastName);
            this.gbGeneral.Controls.Add(this.lblFirstName);
            this.gbGeneral.Controls.Add(this.lblLastName);
            this.gbGeneral.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbGeneral.Location = new System.Drawing.Point(27, 111);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(387, 240);
            this.gbGeneral.TabIndex = 1;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = "Ogólne";
            // 
            // txtPesel
            // 
            this.txtPesel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPesel.Location = new System.Drawing.Point(187, 188);
            this.txtPesel.Name = "txtPesel";
            this.txtPesel.Size = new System.Drawing.Size(165, 25);
            this.txtPesel.TabIndex = 9;
            this.txtPesel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesel_KeyPress);
            this.txtPesel.Validated += new System.EventHandler(this.txtPesel_Validated);
            // 
            // lblPesel
            // 
            this.lblPesel.AutoSize = true;
            this.lblPesel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPesel.Location = new System.Drawing.Point(13, 192);
            this.lblPesel.Name = "lblPesel";
            this.lblPesel.Size = new System.Drawing.Size(42, 17);
            this.lblPesel.TabIndex = 8;
            this.lblPesel.Text = "PESEL";
            // 
            // dtpDateBirth
            // 
            this.dtpDateBirth.CustomFormat = " ";
            this.dtpDateBirth.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateBirth.Location = new System.Drawing.Point(187, 148);
            this.dtpDateBirth.Name = "dtpDateBirth";
            this.dtpDateBirth.Size = new System.Drawing.Size(165, 27);
            this.dtpDateBirth.TabIndex = 7;
            this.dtpDateBirth.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // lblDateBirth
            // 
            this.lblDateBirth.AutoSize = true;
            this.lblDateBirth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDateBirth.Location = new System.Drawing.Point(13, 151);
            this.lblDateBirth.Name = "lblDateBirth";
            this.lblDateBirth.Size = new System.Drawing.Size(97, 17);
            this.lblDateBirth.TabIndex = 6;
            this.lblDateBirth.Text = "Data urodzenia";
            // 
            // cbGender
            // 
            this.cbGender.DataSource = this.bsGender;
            this.cbGender.DisplayMember = "Value";
            this.cbGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(187, 110);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(165, 25);
            this.cbGender.TabIndex = 5;
            this.cbGender.ValueMember = "Id";
            // 
            // bsGender
            // 
            this.bsGender.DataSource = typeof(SystemHR.DataAccessLayer.Models.Dictionaries.GenderModel);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGender.Location = new System.Drawing.Point(13, 113);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(31, 17);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Płeć";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtFirstName.Location = new System.Drawing.Point(187, 71);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(165, 25);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLastName.Location = new System.Drawing.Point(187, 33);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(165, 25);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFirstName.Location = new System.Drawing.Point(13, 75);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(35, 17);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Imię";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLastName.Location = new System.Drawing.Point(13, 37);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(66, 17);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Nazwisko";
            // 
            // pbEmployee
            // 
            this.pbEmployee.Image = global::SystemHR.UserInterface.Properties.Resources.close;
            this.pbEmployee.Location = new System.Drawing.Point(735, 15);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.Size = new System.Drawing.Size(16, 16);
            this.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbEmployee.TabIndex = 2;
            this.pbEmployee.TabStop = false;
            // 
            // gbContact
            // 
            this.gbContact.Controls.Add(this.txtEmailAddress);
            this.gbContact.Controls.Add(this.lblEmailAddress);
            this.gbContact.Controls.Add(this.txtPhoneNumber);
            this.gbContact.Controls.Add(this.lblPhoneNumber);
            this.gbContact.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbContact.Location = new System.Drawing.Point(27, 358);
            this.gbContact.Name = "gbContact";
            this.gbContact.Size = new System.Drawing.Size(387, 121);
            this.gbContact.TabIndex = 3;
            this.gbContact.TabStop = false;
            this.gbContact.Text = "Kontakt";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEmailAddress.Location = new System.Drawing.Point(187, 71);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(165, 25);
            this.txtEmailAddress.TabIndex = 3;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmailAddress.Location = new System.Drawing.Point(13, 75);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(82, 17);
            this.lblEmailAddress.TabIndex = 2;
            this.lblEmailAddress.Text = "Adres e-mail";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(187, 33);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(165, 25);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(13, 37);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(74, 17);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "Nr telefonu";
            // 
            // gbIdentityCard
            // 
            this.gbIdentityCard.Controls.Add(this.dtpExpirationDateIdentityCard);
            this.gbIdentityCard.Controls.Add(this.lblExpirationDateIdentityCard);
            this.gbIdentityCard.Controls.Add(this.dtpIssueDateIdentityCard);
            this.gbIdentityCard.Controls.Add(this.lblIssueDateIdentityCard);
            this.gbIdentityCard.Controls.Add(this.txtIdentityCardNumber);
            this.gbIdentityCard.Controls.Add(this.lblIdentityCardNumber);
            this.gbIdentityCard.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbIdentityCard.Location = new System.Drawing.Point(447, 111);
            this.gbIdentityCard.Name = "gbIdentityCard";
            this.gbIdentityCard.Size = new System.Drawing.Size(373, 158);
            this.gbIdentityCard.TabIndex = 4;
            this.gbIdentityCard.TabStop = false;
            this.gbIdentityCard.Text = "Dowód osobisty";
            // 
            // dtpExpirationDateIdentityCard
            // 
            this.dtpExpirationDateIdentityCard.CustomFormat = " ";
            this.dtpExpirationDateIdentityCard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpExpirationDateIdentityCard.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpirationDateIdentityCard.Location = new System.Drawing.Point(187, 110);
            this.dtpExpirationDateIdentityCard.Name = "dtpExpirationDateIdentityCard";
            this.dtpExpirationDateIdentityCard.Size = new System.Drawing.Size(165, 27);
            this.dtpExpirationDateIdentityCard.TabIndex = 5;
            this.dtpExpirationDateIdentityCard.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // lblExpirationDateIdentityCard
            // 
            this.lblExpirationDateIdentityCard.AutoSize = true;
            this.lblExpirationDateIdentityCard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblExpirationDateIdentityCard.Location = new System.Drawing.Point(13, 113);
            this.lblExpirationDateIdentityCard.Name = "lblExpirationDateIdentityCard";
            this.lblExpirationDateIdentityCard.Size = new System.Drawing.Size(91, 17);
            this.lblExpirationDateIdentityCard.TabIndex = 4;
            this.lblExpirationDateIdentityCard.Text = "Data ważności";
            // 
            // dtpIssueDateIdentityCard
            // 
            this.dtpIssueDateIdentityCard.CustomFormat = " ";
            this.dtpIssueDateIdentityCard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpIssueDateIdentityCard.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueDateIdentityCard.Location = new System.Drawing.Point(187, 71);
            this.dtpIssueDateIdentityCard.Name = "dtpIssueDateIdentityCard";
            this.dtpIssueDateIdentityCard.Size = new System.Drawing.Size(165, 27);
            this.dtpIssueDateIdentityCard.TabIndex = 3;
            this.dtpIssueDateIdentityCard.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // lblIssueDateIdentityCard
            // 
            this.lblIssueDateIdentityCard.AutoSize = true;
            this.lblIssueDateIdentityCard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIssueDateIdentityCard.Location = new System.Drawing.Point(13, 75);
            this.lblIssueDateIdentityCard.Name = "lblIssueDateIdentityCard";
            this.lblIssueDateIdentityCard.Size = new System.Drawing.Size(86, 17);
            this.lblIssueDateIdentityCard.TabIndex = 2;
            this.lblIssueDateIdentityCard.Text = "Data wydania";
            // 
            // txtIdentityCardNumber
            // 
            this.txtIdentityCardNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIdentityCardNumber.Location = new System.Drawing.Point(187, 33);
            this.txtIdentityCardNumber.Name = "txtIdentityCardNumber";
            this.txtIdentityCardNumber.Size = new System.Drawing.Size(165, 25);
            this.txtIdentityCardNumber.TabIndex = 1;
            // 
            // lblIdentityCardNumber
            // 
            this.lblIdentityCardNumber.AutoSize = true;
            this.lblIdentityCardNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIdentityCardNumber.Location = new System.Drawing.Point(13, 37);
            this.lblIdentityCardNumber.Name = "lblIdentityCardNumber";
            this.lblIdentityCardNumber.Size = new System.Drawing.Size(75, 17);
            this.lblIdentityCardNumber.TabIndex = 0;
            this.lblIdentityCardNumber.Text = "Nr dowodu";
            // 
            // gbPassport
            // 
            this.gbPassport.Controls.Add(this.dtpExpirationDatePassport);
            this.gbPassport.Controls.Add(this.lblExpirationDatePassport);
            this.gbPassport.Controls.Add(this.dtpIssueDatePassport);
            this.gbPassport.Controls.Add(this.lblIssueDatePassport);
            this.gbPassport.Controls.Add(this.txtPassportNumber);
            this.gbPassport.Controls.Add(this.lblPasswordNumber);
            this.gbPassport.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPassport.Location = new System.Drawing.Point(447, 321);
            this.gbPassport.Name = "gbPassport";
            this.gbPassport.Size = new System.Drawing.Size(373, 158);
            this.gbPassport.TabIndex = 5;
            this.gbPassport.TabStop = false;
            this.gbPassport.Text = "Paszport";
            // 
            // dtpExpirationDatePassport
            // 
            this.dtpExpirationDatePassport.CustomFormat = " ";
            this.dtpExpirationDatePassport.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpExpirationDatePassport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpirationDatePassport.Location = new System.Drawing.Point(187, 110);
            this.dtpExpirationDatePassport.Name = "dtpExpirationDatePassport";
            this.dtpExpirationDatePassport.Size = new System.Drawing.Size(165, 27);
            this.dtpExpirationDatePassport.TabIndex = 5;
            this.dtpExpirationDatePassport.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // lblExpirationDatePassport
            // 
            this.lblExpirationDatePassport.AutoSize = true;
            this.lblExpirationDatePassport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblExpirationDatePassport.Location = new System.Drawing.Point(13, 113);
            this.lblExpirationDatePassport.Name = "lblExpirationDatePassport";
            this.lblExpirationDatePassport.Size = new System.Drawing.Size(91, 17);
            this.lblExpirationDatePassport.TabIndex = 4;
            this.lblExpirationDatePassport.Text = "Data ważności";
            // 
            // dtpIssueDatePassport
            // 
            this.dtpIssueDatePassport.CustomFormat = " ";
            this.dtpIssueDatePassport.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpIssueDatePassport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueDatePassport.Location = new System.Drawing.Point(187, 71);
            this.dtpIssueDatePassport.Name = "dtpIssueDatePassport";
            this.dtpIssueDatePassport.Size = new System.Drawing.Size(165, 27);
            this.dtpIssueDatePassport.TabIndex = 3;
            this.dtpIssueDatePassport.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // lblIssueDatePassport
            // 
            this.lblIssueDatePassport.AutoSize = true;
            this.lblIssueDatePassport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIssueDatePassport.Location = new System.Drawing.Point(13, 75);
            this.lblIssueDatePassport.Name = "lblIssueDatePassport";
            this.lblIssueDatePassport.Size = new System.Drawing.Size(86, 17);
            this.lblIssueDatePassport.TabIndex = 2;
            this.lblIssueDatePassport.Text = "Data wydania";
            // 
            // txtPassportNumber
            // 
            this.txtPassportNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPassportNumber.Location = new System.Drawing.Point(187, 33);
            this.txtPassportNumber.Name = "txtPassportNumber";
            this.txtPassportNumber.Size = new System.Drawing.Size(165, 25);
            this.txtPassportNumber.TabIndex = 1;
            // 
            // lblPasswordNumber
            // 
            this.lblPasswordNumber.AutoSize = true;
            this.lblPasswordNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPasswordNumber.Location = new System.Drawing.Point(13, 37);
            this.lblPasswordNumber.Name = "lblPasswordNumber";
            this.lblPasswordNumber.Size = new System.Drawing.Size(86, 17);
            this.lblPasswordNumber.TabIndex = 0;
            this.lblPasswordNumber.Text = "Nr paszportu";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(560, 492);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 49);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Location = new System.Drawing.Point(693, 492);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 49);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // epLastName
            // 
            this.epLastName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epLastName.ContainerControl = this;
            // 
            // epFirstName
            // 
            this.epFirstName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epFirstName.ContainerControl = this;
            // 
            // epPESEL
            // 
            this.epPESEL.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epPESEL.ContainerControl = this;
            // 
            // EmployeeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 563);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbPassport);
            this.Controls.Add(this.gbIdentityCard);
            this.Controls.Add(this.gbContact);
            this.Controls.Add(this.pbEmployee);
            this.Controls.Add(this.gbGeneral);
            this.Controls.Add(this.lblEmployee);
            this.KeyPreview = true;
            this.Name = "EmployeeAddForm";
            this.Text = "Dodaj pracownika";
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            this.gbContact.ResumeLayout(false);
            this.gbContact.PerformLayout();
            this.gbIdentityCard.ResumeLayout(false);
            this.gbIdentityCard.PerformLayout();
            this.gbPassport.ResumeLayout(false);
            this.gbPassport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPESEL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.TextBox txtPesel;
        private System.Windows.Forms.Label lblPesel;
        private System.Windows.Forms.DateTimePicker dtpDateBirth;
        private System.Windows.Forms.Label lblDateBirth;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.PictureBox pbEmployee;
        private System.Windows.Forms.GroupBox gbContact;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.GroupBox gbIdentityCard;
        private System.Windows.Forms.DateTimePicker dtpExpirationDateIdentityCard;
        private System.Windows.Forms.Label lblExpirationDateIdentityCard;
        private System.Windows.Forms.DateTimePicker dtpIssueDateIdentityCard;
        private System.Windows.Forms.Label lblIssueDateIdentityCard;
        private System.Windows.Forms.TextBox txtIdentityCardNumber;
        private System.Windows.Forms.Label lblIdentityCardNumber;
        private System.Windows.Forms.GroupBox gbPassport;
        private System.Windows.Forms.DateTimePicker dtpExpirationDatePassport;
        private System.Windows.Forms.Label lblExpirationDatePassport;
        private System.Windows.Forms.DateTimePicker dtpIssueDatePassport;
        private System.Windows.Forms.Label lblIssueDatePassport;
        private System.Windows.Forms.TextBox txtPassportNumber;
        private System.Windows.Forms.Label lblPasswordNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource bsGender;
        private System.Windows.Forms.ErrorProvider epLastName;
        private System.Windows.Forms.ErrorProvider epFirstName;
        private System.Windows.Forms.ErrorProvider epPESEL;
    }
}