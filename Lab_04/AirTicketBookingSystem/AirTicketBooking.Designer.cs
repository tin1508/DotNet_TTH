namespace AirTicketBookingSystem
{
    partial class AirTicketBooking
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
            ConfirmBtn = new Button();
            HeaderPanel = new Panel();
            AvatarBox = new PictureBox();
            WelcomeLabel = new Label();
            FlightListLabel = new Label();
            RegistrationList = new Label();
            LogoutBtn = new Button();
            lsbFlightsList = new ListBox();
            BookedFlightInfo = new RichTextBox();
            AddBtn = new Button();
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AvatarBox).BeginInit();
            SuspendLayout();
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.Anchor = AnchorStyles.None;
            ConfirmBtn.Location = new Point(768, 996);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new Size(150, 46);
            ConfirmBtn.TabIndex = 2;
            ConfirmBtn.Text = "Confirm";
            ConfirmBtn.UseVisualStyleBackColor = true;
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // HeaderPanel
            // 
            HeaderPanel.Anchor = AnchorStyles.None;
            HeaderPanel.BackColor = SystemColors.Window;
            HeaderPanel.Controls.Add(AvatarBox);
            HeaderPanel.Controls.Add(WelcomeLabel);
            HeaderPanel.Location = new Point(0, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new Size(1671, 200);
            HeaderPanel.TabIndex = 3;
            HeaderPanel.Paint += HeaderPanel_Paint;
            // 
            // AvatarBox
            // 
            AvatarBox.Location = new Point(1414, 12);
            AvatarBox.Name = "AvatarBox";
            AvatarBox.Size = new Size(168, 162);
            AvatarBox.SizeMode = PictureBoxSizeMode.Zoom;
            AvatarBox.TabIndex = 1;
            AvatarBox.TabStop = false;
            AvatarBox.Click += AvatarBox_Click;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.BackColor = SystemColors.Window;
            WelcomeLabel.Font = new Font("Segoe UI", 18F);
            WelcomeLabel.Location = new Point(47, 69);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(482, 77);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "label1";
            WelcomeLabel.Click += WelcomeLabel_Click;
            // 
            // FlightListLabel
            // 
            FlightListLabel.Anchor = AnchorStyles.None;
            FlightListLabel.BackColor = Color.Transparent;
            FlightListLabel.Font = new Font("Segoe UI", 15F);
            FlightListLabel.ForeColor = Color.DeepSkyBlue;
            FlightListLabel.Location = new Point(47, 222);
            FlightListLabel.Name = "FlightListLabel";
            FlightListLabel.Size = new Size(405, 64);
            FlightListLabel.TabIndex = 0;
            FlightListLabel.Text = "label1";
            // 
            // RegistrationList
            // 
            RegistrationList.Anchor = AnchorStyles.None;
            RegistrationList.BackColor = Color.Transparent;
            RegistrationList.Font = new Font("Segoe UI", 15F);
            RegistrationList.ForeColor = Color.DeepSkyBlue;
            RegistrationList.Location = new Point(802, 222);
            RegistrationList.Name = "RegistrationList";
            RegistrationList.Size = new Size(653, 64);
            RegistrationList.TabIndex = 1;
            RegistrationList.Text = "label1";
            // 
            // LogoutBtn
            // 
            LogoutBtn.Anchor = AnchorStyles.None;
            LogoutBtn.Location = new Point(1197, 996);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(150, 46);
            LogoutBtn.TabIndex = 4;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // lsbFlightsList
            // 
            lsbFlightsList.Anchor = AnchorStyles.None;
            lsbFlightsList.FormattingEnabled = true;
            lsbFlightsList.Location = new Point(47, 304);
            lsbFlightsList.Name = "lsbFlightsList";
            lsbFlightsList.Size = new Size(405, 644);
            lsbFlightsList.TabIndex = 5;
            // 
            // BookedFlightInfo
            // 
            BookedFlightInfo.Anchor = AnchorStyles.None;
            BookedFlightInfo.Location = new Point(648, 304);
            BookedFlightInfo.Name = "BookedFlightInfo";
            BookedFlightInfo.Size = new Size(916, 644);
            BookedFlightInfo.TabIndex = 6;
            BookedFlightInfo.Text = "";
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.None;
            AddBtn.Location = new Point(146, 983);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(150, 46);
            AddBtn.TabIndex = 7;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // AirTicketBooking
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.airplane;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1671, 1089);
            Controls.Add(AddBtn);
            Controls.Add(BookedFlightInfo);
            Controls.Add(LogoutBtn);
            Controls.Add(lsbFlightsList);
            Controls.Add(HeaderPanel);
            Controls.Add(FlightListLabel);
            Controls.Add(RegistrationList);
            Controls.Add(ConfirmBtn);
            Name = "AirTicketBooking";
            Text = "AirTicketBooking";
            FormClosed += AirTicketBooking_FormClosed;
            Load += AirTicketBooking_Load;
            HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AvatarBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private FlowLayoutPanel BookedFlFlowPanel;
        private Button ConfirmBtn;
        private Panel HeaderPanel;
        private Label WelcomeLabel;
        private PictureBox AvatarBox;
        private Label FlightListLabel;
        private FlowLayoutPanel ListFlightFlowPanel;
        private Label RegistrationList;
        private Button LogoutBtn;
        private ListBox lsbFlightsList;
        private RichTextBox BookedFlightInfo;
        private Button AddBtn;
    }
}