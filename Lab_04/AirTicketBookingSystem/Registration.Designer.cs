namespace AirTicketBookingSystem
{
    partial class Registration
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
            InputCustomerName = new TextBox();
            InputPassportNo = new TextBox();
            InputNationality = new TextBox();
            RegistrationLabel = new Label();
            Birthday = new DateTimePicker();
            RegisterBtn = new Button();
            CancelBtn = new Button();
            RegistrationPanel = new Panel();
            FemaleBtn = new RadioButton();
            MaleBtn = new RadioButton();
            GenderLabel = new Label();
            EyeIcon2 = new PictureBox();
            EyeIcon1 = new PictureBox();
            InputUsername = new TextBox();
            ClearBtn = new Button();
            ConfirmPassword = new TextBox();
            InputPassword = new TextBox();
            RemoveBtn = new Button();
            AvatarBox = new PictureBox();
            StatusLabel = new Label();
            UploadAvatarBtn = new Button();
            RegistrationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EyeIcon2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EyeIcon1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AvatarBox).BeginInit();
            SuspendLayout();
            // 
            // InputCustomerName
            // 
            InputCustomerName.Location = new Point(137, 133);
            InputCustomerName.Name = "InputCustomerName";
            InputCustomerName.Size = new Size(430, 39);
            InputCustomerName.TabIndex = 3;
            InputCustomerName.Text = "Name";
            InputCustomerName.Click += InputCustomerName_TextChanged;
            InputCustomerName.TextChanged += InputCustomerName_TextChanged;
            // 
            // InputPassportNo
            // 
            InputPassportNo.Location = new Point(137, 358);
            InputPassportNo.Name = "InputPassportNo";
            InputPassportNo.Size = new Size(430, 39);
            InputPassportNo.TabIndex = 7;
            InputPassportNo.Text = "Passport No.";
            InputPassportNo.Click += InputPassportNo_TextChanged;
            InputPassportNo.TextChanged += InputPassportNo_TextChanged;
            // 
            // InputNationality
            // 
            InputNationality.Location = new Point(137, 438);
            InputNationality.Name = "InputNationality";
            InputNationality.Size = new Size(430, 39);
            InputNationality.TabIndex = 9;
            InputNationality.Text = "Nationality";
            InputNationality.Click += InputNationality_TextChanged;
            InputNationality.TextChanged += InputNationality_TextChanged;
            // 
            // RegistrationLabel
            // 
            RegistrationLabel.AutoSize = true;
            RegistrationLabel.Font = new Font("Segoe UI", 16F);
            RegistrationLabel.ForeColor = Color.DodgerBlue;
            RegistrationLabel.Location = new Point(220, 19);
            RegistrationLabel.Name = "RegistrationLabel";
            RegistrationLabel.Size = new Size(251, 59);
            RegistrationLabel.TabIndex = 10;
            RegistrationLabel.Text = "Registration";
            // 
            // Birthday
            // 
            Birthday.CustomFormat = "'Please Select Your Birthday '";
            Birthday.Format = DateTimePickerFormat.Custom;
            Birthday.Location = new Point(137, 275);
            Birthday.Name = "Birthday";
            Birthday.Size = new Size(430, 39);
            Birthday.TabIndex = 11;
            Birthday.Value = new DateTime(2025, 12, 12, 0, 0, 0, 0);
            Birthday.ValueChanged += Birthday_ValueChanged;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.SkyBlue;
            RegisterBtn.Location = new Point(655, 628);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(150, 99);
            RegisterBtn.TabIndex = 12;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.SkyBlue;
            CancelBtn.Location = new Point(1034, 628);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(150, 99);
            CancelBtn.TabIndex = 13;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // RegistrationPanel
            // 
            RegistrationPanel.Anchor = AnchorStyles.None;
            RegistrationPanel.BackColor = SystemColors.GradientActiveCaption;
            RegistrationPanel.Controls.Add(FemaleBtn);
            RegistrationPanel.Controls.Add(MaleBtn);
            RegistrationPanel.Controls.Add(GenderLabel);
            RegistrationPanel.Controls.Add(EyeIcon2);
            RegistrationPanel.Controls.Add(EyeIcon1);
            RegistrationPanel.Controls.Add(InputUsername);
            RegistrationPanel.Controls.Add(ClearBtn);
            RegistrationPanel.Controls.Add(ConfirmPassword);
            RegistrationPanel.Controls.Add(InputPassword);
            RegistrationPanel.Controls.Add(RemoveBtn);
            RegistrationPanel.Controls.Add(AvatarBox);
            RegistrationPanel.Controls.Add(StatusLabel);
            RegistrationPanel.Controls.Add(UploadAvatarBtn);
            RegistrationPanel.Controls.Add(CancelBtn);
            RegistrationPanel.Controls.Add(RegisterBtn);
            RegistrationPanel.Controls.Add(Birthday);
            RegistrationPanel.Controls.Add(RegistrationLabel);
            RegistrationPanel.Controls.Add(InputNationality);
            RegistrationPanel.Controls.Add(InputPassportNo);
            RegistrationPanel.Controls.Add(InputCustomerName);
            RegistrationPanel.Location = new Point(232, 148);
            RegistrationPanel.Name = "RegistrationPanel";
            RegistrationPanel.Size = new Size(1273, 789);
            RegistrationPanel.TabIndex = 0;
            RegistrationPanel.Paint += RegistrationPanel_Paint;
            // 
            // FemaleBtn
            // 
            FemaleBtn.AutoSize = true;
            FemaleBtn.Location = new Point(383, 208);
            FemaleBtn.Name = "FemaleBtn";
            FemaleBtn.Size = new Size(122, 36);
            FemaleBtn.TabIndex = 26;
            FemaleBtn.TabStop = true;
            FemaleBtn.Text = "Female";
            FemaleBtn.UseVisualStyleBackColor = true;
            // 
            // MaleBtn
            // 
            MaleBtn.AutoSize = true;
            MaleBtn.Location = new Point(270, 204);
            MaleBtn.Name = "MaleBtn";
            MaleBtn.Size = new Size(98, 36);
            MaleBtn.TabIndex = 25;
            MaleBtn.TabStop = true;
            MaleBtn.Text = "Male";
            MaleBtn.UseVisualStyleBackColor = true;
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.BackColor = SystemColors.Window;
            GenderLabel.Location = new Point(137, 208);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(92, 32);
            GenderLabel.TabIndex = 24;
            GenderLabel.Text = "Gender";
            // 
            // EyeIcon2
            // 
            EyeIcon2.BackColor = SystemColors.Window;
            EyeIcon2.Image = Properties.Resources.eye_icon;
            EyeIcon2.Location = new Point(481, 688);
            EyeIcon2.Name = "EyeIcon2";
            EyeIcon2.Size = new Size(86, 39);
            EyeIcon2.SizeMode = PictureBoxSizeMode.Zoom;
            EyeIcon2.TabIndex = 23;
            EyeIcon2.TabStop = false;
            EyeIcon2.Click += EyeIcon2_Click;
            // 
            // EyeIcon1
            // 
            EyeIcon1.BackColor = SystemColors.Window;
            EyeIcon1.Image = Properties.Resources.eye_icon;
            EyeIcon1.Location = new Point(481, 596);
            EyeIcon1.Name = "EyeIcon1";
            EyeIcon1.Size = new Size(86, 39);
            EyeIcon1.SizeMode = PictureBoxSizeMode.Zoom;
            EyeIcon1.TabIndex = 22;
            EyeIcon1.TabStop = false;
            EyeIcon1.Click += EyeIcon1_Click;
            // 
            // InputUsername
            // 
            InputUsername.Location = new Point(137, 509);
            InputUsername.Name = "InputUsername";
            InputUsername.Size = new Size(430, 39);
            InputUsername.TabIndex = 21;
            InputUsername.Text = "Username";
            InputUsername.Click += InputUsername_TextChanged;
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = Color.SkyBlue;
            ClearBtn.Location = new Point(846, 628);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(150, 99);
            ClearBtn.TabIndex = 20;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // ConfirmPassword
            // 
            ConfirmPassword.Location = new Point(137, 688);
            ConfirmPassword.Name = "ConfirmPassword";
            ConfirmPassword.Size = new Size(430, 39);
            ConfirmPassword.TabIndex = 19;
            ConfirmPassword.Text = "Confirm Password";
            ConfirmPassword.Click += ConfirmPassword_TextChanged;
            // 
            // InputPassword
            // 
            InputPassword.Location = new Point(137, 596);
            InputPassword.Name = "InputPassword";
            InputPassword.Size = new Size(430, 39);
            InputPassword.TabIndex = 18;
            InputPassword.Text = "Password";
            InputPassword.Click += InputPassword_TextChanged;
            // 
            // RemoveBtn
            // 
            RemoveBtn.Location = new Point(960, 469);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(150, 82);
            RemoveBtn.TabIndex = 17;
            RemoveBtn.Text = "Remove Avatar";
            RemoveBtn.UseVisualStyleBackColor = true;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // AvatarBox
            // 
            AvatarBox.BackColor = SystemColors.ButtonHighlight;
            AvatarBox.Location = new Point(799, 115);
            AvatarBox.Name = "AvatarBox";
            AvatarBox.Size = new Size(261, 282);
            AvatarBox.SizeMode = PictureBoxSizeMode.Zoom;
            AvatarBox.TabIndex = 16;
            AvatarBox.TabStop = false;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(816, 417);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(0, 32);
            StatusLabel.TabIndex = 15;
            // 
            // UploadAvatarBtn
            // 
            UploadAvatarBtn.Location = new Point(723, 469);
            UploadAvatarBtn.Name = "UploadAvatarBtn";
            UploadAvatarBtn.Size = new Size(150, 79);
            UploadAvatarBtn.TabIndex = 14;
            UploadAvatarBtn.Text = "Upload Avatar";
            UploadAvatarBtn.UseVisualStyleBackColor = true;
            UploadAvatarBtn.Click += UploadAvatarBtn_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.airplane;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1671, 1089);
            Controls.Add(RegistrationPanel);
            Name = "Registration";
            Text = "Registration";
            FormClosed += Registration_FormClosed;
            Load += Registration_Load;
            RegistrationPanel.ResumeLayout(false);
            RegistrationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EyeIcon2).EndInit();
            ((System.ComponentModel.ISupportInitialize)EyeIcon1).EndInit();
            ((System.ComponentModel.ISupportInitialize)AvatarBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox InputCustomerName;
        private TextBox InputPassportNo;
        private TextBox InputNationality;
        private Label RegistrationLabel;
        private DateTimePicker Birthday;
        private Button RegisterBtn;
        private Button CancelBtn;
        private Panel RegistrationPanel;
        private Button UploadAvatarBtn;
        private Label StatusLabel;
        private PictureBox AvatarBox;
        private Button RemoveBtn;
        private TextBox ConfirmPassword;
        private TextBox InputPassword;
        private Button ClearBtn;
        private TextBox InputUsername;
        private PictureBox EyeIcon1;
        private PictureBox EyeIcon2;
        private Label GenderLabel;
        private RadioButton FemaleBtn;
        private RadioButton MaleBtn;
    }
}