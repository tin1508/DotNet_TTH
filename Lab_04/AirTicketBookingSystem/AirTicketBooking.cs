using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AirTicketBookingSystem
{
    public partial class AirTicketBooking : Form
    {
        private new Login? ParentForm;
        public User? currentUser;
        public Customers? currentCustomer;
        private bool isLogout = false;
        private string strRegistration;
        public int idxRegistration;

        public AirTicketBooking()
        {
            InitializeComponent();
            ParentForm = Login.OriginalForm;
            foreach (Flight obj in ParentForm.FlightsList)
            {
                lsbFlightsList.Items.Add(obj.FlightID);
            }
            BookedFlightInfo.Text = "";
            RoundedCornersHelper.ApplyRoundedCorners(AddBtn, 30);
            RoundedCornersHelper.ApplyRoundedCorners(ConfirmBtn, 30);
            RoundedCornersHelper.ApplyRoundedCorners(LogoutBtn, 30);
        }

        private void AirTicketBooking_Load(object sender, EventArgs e)
        {
           
            this.FlightListLabel.Text = "Available Flights";
            this.RegistrationList.Text = "Your Flight Registration";
        }
        public void SetCurrentUser(User user)
        {
            currentUser = user;
            if(currentUser.Username == "admin")
            {
                this.AddBtn.Visible = false;
                this.ConfirmBtn.Visible = false;
            }
            currentCustomer = ParentForm.CustomersList.Find(x => x.ID == currentUser.CustomerID);
            if (currentUser != null)
            {
                this.WelcomeLabel.Text = "Welcome, " + currentUser.Username;
            }
            if (currentCustomer != null && currentCustomer.Avatar != null)
            {
                this.AvatarBox.Image = currentCustomer.Avatar;
            }
            idxRegistration = ParentForm.FlightBookings.FindIndex(x => x.CustomerID == currentCustomer.ID);
            if (idxRegistration >= 0)
            {
                foreach (Flight obj in ParentForm.FlightBookings[idxRegistration].FlightEnrollList)
                {
                    int idx = lsbFlightsList.FindString(obj.FlightID.Trim());
                    lsbFlightsList.SetSelected(idx, true);
                }
            }
            ShowRegistrationInfo();
        }
        public string ShowRegistrationInfo()
        {
            strRegistration = "\t\t\t Flight Registration of Customer \n";
            strRegistration += "____________________________________________________________________\n";
            strRegistration += String.Format("Customer ID: {0}\n \tCustomer Name: {1} \n", currentCustomer.ID, currentCustomer.Name);
            int sumFlight;
            if (idxRegistration >= 0) sumFlight = ParentForm.FlightBookings[idxRegistration].FlightEnrollList.Count;
            else sumFlight = 0;
            strRegistration += String.Format("\t Sum of Registered Flights: {0}\n", sumFlight);
            strRegistration += "____________________________________________________________________\n";
            Flight obj;
            foreach (Object selectedItem in lsbFlightsList.SelectedItems)
            {
                obj = ParentForm.FlightsList.Find(x => x.FlightID == selectedItem.ToString());
                if (obj != null)
                {
                    strRegistration += obj.ToString() + "\n";
                    sumFlight += 1;
                }
            }
            BookedFlightInfo.Text = strRegistration;
            return strRegistration;
        }
        private void AirTicketBooking_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isLogout == false)
                Application.Exit();
        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            isLogout = true;
            this.Close();
            if (ParentForm != null)
            {
                ParentForm.ResetLogin = true;
                ParentForm.Show();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (idxRegistration < 0)
            {
                ParentForm.FlightBookings.Add(new FlightBooking(currentCustomer.ID));
                idxRegistration = ParentForm.FlightBookings.FindIndex(x => x.CustomerID == currentCustomer.ID);
                Flight obj;
                foreach (Object selectedItem in lsbFlightsList.SelectedItems)
                {
                    obj = ParentForm.FlightsList.Find(x => x.FlightID == selectedItem.ToString());
                    if (obj != null)
                        ParentForm.FlightBookings[idxRegistration].FlightEnrollList.Add(obj);
                }
            }
            ShowRegistrationInfo();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your flight booking has been confirmed!", "Booking Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void WelcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void AvatarBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(currentCustomer.ToString(), "Customer Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
