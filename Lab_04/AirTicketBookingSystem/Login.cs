using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;


namespace AirTicketBookingSystem
{
    public partial class Login : Form
    {
        public static Login? OriginalForm;
        public List<Customers> CustomersList;
        public List<User> UsersList;
        public List<Flight> FlightsList;
        public List<FlightBooking> FlightBookings;
        public bool ResetLogin;

        public Login()
        {
            InitializeComponent(); 
            OriginalForm = this;
            UsersList = new List<User>();
            FlightsList = new List<Flight>();
            CustomersList = new List<Customers>();
            //lam cho cac goc cua panel login form tron 
            RoundedCornersHelper.ApplyRoundedCorners(LoginPanel, 20);
            RoundedCornersHelper.ApplyRoundedCorners(LoginButton, 30);
        }

        

        private void inputPassword_TextChanged(object sender, EventArgs e)
        {
            if(InputPassword.Text == "Password")
            {
                InputPassword.Text = "";
                InputPassword.ForeColor = Color.Black;
                InputPassword.UseSystemPasswordChar = true;
            }   
        }

        private void inputUsername_TextChanged(object sender, EventArgs e)
        {
            if(InputUsername.Text == "Username")
            {
                InputUsername.Text = "";
                InputUsername.ForeColor = Color.Black;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration();
            this.Hide();
            registration.Show();
            linkLblRegister.LinkVisited = true;
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (InputUsername.Text.Length == 0)
            {
                MessageBox.Show("Please enter your user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                InputUsername.Focus();
                return;
            }
            if (InputPassword.Text.Length == 0)
            {
                MessageBox.Show("Please enter your password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                InputPassword.Focus();
                return;
            }
            try
            {
                User? SpecificOne = UsersList.Find(user => (user.Username == InputUsername.Text) && (user.Password == InputPassword.Text));
                if (SpecificOne == null)
                {
                    MessageBox.Show("Invalid username or password. Maybe you don't have an account. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    InputUsername.Text = "";
                    InputPassword.Text = "";
                    InputUsername.Focus();
                    return;
                }
                AirTicketBooking booking = new AirTicketBooking();
                booking.SetCurrentUser(SpecificOne);
                this.Hide();
                booking.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InputUsername.Text = "";
                InputPassword.Text = "";
                InputUsername.Focus();
                return;
            }
        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            Customers newCustomer = new Customers("Admin", Genders.Male, "15/08/2005", "12345678", "Viet Nam", Properties.Resources.Doraemon);
            CustomersList.Add(newCustomer);
            UsersList.Add(new User("admin", "admin", newCustomer.ID));

            //them 3 chuyen bay truoc
            FlightsList.Add(new Flight("FVN001",
                            DateTime.ParseExact("15/12/2025 14:23:01", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                            DateTime.ParseExact("15/12/2025 18:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture), FlightTypes.VietnameAirlines));
            FlightsList.Add(new Flight("FVN002",
                            DateTime.ParseExact("18/12/2025 15:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                            DateTime.ParseExact("15/12/2025 17:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture), FlightTypes.VietjetAir));
            FlightsList.Add(new Flight("FVN003",
                            DateTime.ParseExact("15/12/2025 09:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                            DateTime.ParseExact("15/12/2025 12:30:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture), FlightTypes.BambooAirways));
            FlightBookings = new List<FlightBooking>();
            ResetLogin = false;
        }

        private void EyeIcon_Click(object sender, EventArgs e)
        {
            if (InputPassword.Text == "Password") return;
            else InputPassword.UseSystemPasswordChar = !InputPassword.UseSystemPasswordChar;
        }
        private void Login_VisibleChanged(object sender, EventArgs e)
        {
            if(ResetLogin == true)
            {
                InputUsername.Text = "Username";
                InputPassword.Text = "Password";
            }
        }
    }
}
