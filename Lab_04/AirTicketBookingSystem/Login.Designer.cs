namespace AirTicketBookingSystem
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginPanel = new Panel();
            panel1 = new Panel();
            EyeIcon = new PictureBox();
            InputPassword = new TextBox();
            label2 = new Label();
            label1 = new Label();
            linkLblRegister = new LinkLabel();
            LoginButton = new Button();
            LoginLabel = new Label();
            InputUsername = new TextBox();
            LoginPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EyeIcon).BeginInit();
            SuspendLayout();
            // 
            // LoginPanel
            // 
            LoginPanel.Anchor = AnchorStyles.None;
            LoginPanel.BackColor = SystemColors.GradientActiveCaption;
            LoginPanel.Controls.Add(panel1);
            LoginPanel.Controls.Add(label2);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Controls.Add(linkLblRegister);
            LoginPanel.Controls.Add(LoginButton);
            LoginPanel.Controls.Add(LoginLabel);
            LoginPanel.Controls.Add(InputUsername);
            LoginPanel.Location = new Point(514, 227);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(595, 639);
            LoginPanel.TabIndex = 7;
            LoginPanel.Paint += LoginPanel_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(EyeIcon);
            panel1.Controls.Add(InputPassword);
            panel1.Location = new Point(74, 316);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 58);
            panel1.TabIndex = 10;
            // 
            // EyeIcon
            // 
            EyeIcon.BackColor = SystemColors.ButtonHighlight;
            EyeIcon.Image = Properties.Resources.eye_icon;
            EyeIcon.Location = new Point(378, 0);
            EyeIcon.Name = "EyeIcon";
            EyeIcon.Size = new Size(73, 39);
            EyeIcon.SizeMode = PictureBoxSizeMode.Zoom;
            EyeIcon.TabIndex = 6;
            EyeIcon.TabStop = false;
            EyeIcon.Click += EyeIcon_Click;
            // 
            // InputPassword
            // 
            InputPassword.Dock = DockStyle.Left;
            InputPassword.Location = new Point(0, 0);
            InputPassword.Name = "InputPassword";
            InputPassword.ScrollBars = ScrollBars.Vertical;
            InputPassword.Size = new Size(451, 39);
            InputPassword.TabIndex = 5;
            InputPassword.Text = "Password";
            InputPassword.Click += inputPassword_TextChanged;
            InputPassword.TextChanged += inputPassword_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 524);
            label2.Name = "label2";
            label2.Size = new Size(325, 32);
            label2.TabIndex = 9;
            label2.Text = "if you don't have an account.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 524);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 8;
            label1.Text = "Let's";
            // 
            // linkLblRegister
            // 
            linkLblRegister.AutoSize = true;
            linkLblRegister.Font = new Font("Segoe UI", 11F);
            linkLblRegister.Location = new Point(118, 518);
            linkLblRegister.Name = "linkLblRegister";
            linkLblRegister.Size = new Size(118, 41);
            linkLblRegister.TabIndex = 7;
            linkLblRegister.TabStop = true;
            linkLblRegister.Text = "register";
            linkLblRegister.LinkClicked += linkLabel1_LinkClicked;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.SkyBlue;
            LoginButton.Font = new Font("Segoe UI", 14F);
            LoginButton.Location = new Point(204, 434);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(163, 58);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "LOG IN";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginLabel
            // 
            LoginLabel.BackColor = Color.Transparent;
            LoginLabel.Font = new Font("Segoe UI", 25F);
            LoginLabel.ForeColor = SystemColors.Highlight;
            LoginLabel.Location = new Point(162, 45);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(262, 116);
            LoginLabel.TabIndex = 0;
            LoginLabel.Text = "LOG IN";
            // 
            // InputUsername
            // 
            InputUsername.Location = new Point(74, 185);
            InputUsername.Name = "InputUsername";
            InputUsername.Size = new Size(454, 39);
            InputUsername.TabIndex = 2;
            InputUsername.Text = "Username";
            InputUsername.Click += inputUsername_TextChanged;
            InputUsername.TextChanged += inputUsername_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.airplane;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1671, 1089);
            Controls.Add(LoginPanel);
            Name = "Login";
            Text = "`";
            Load += Login_Load;
            VisibleChanged += Login_VisibleChanged;
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EyeIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginPanel;
        private TextBox InputUsername;
        private TextBox InputPassword;
        private Label LoginLabel;
        private Button LoginButton;
        private Label label1;
        private LinkLabel linkLblRegister;
        private Label label2;
        private Panel panel1;
        private PictureBox EyeIcon;
    }
}
