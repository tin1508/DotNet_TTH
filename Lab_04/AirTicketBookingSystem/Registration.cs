using AirTicketBookingSystem.Properties;
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
    public partial class Registration : Form
    {
        private Login ParentForm;

        public Registration()
        {
            InitializeComponent();
            StatusLabel.Text = "";
            ParentForm = Login.OriginalForm;
            RoundedCornersHelper.ApplyRoundedCorners(RegistrationPanel, 20);
            RoundedCornersHelper.ApplyRoundedCorners(UploadAvatarBtn, 30);
            RoundedCornersHelper.ApplyRoundedCorners(RemoveBtn, 30);
            RoundedCornersHelper.ApplyRoundedCorners(RegisterBtn, 30);
            RoundedCornersHelper.ApplyRoundedCorners(ClearBtn, 30);
            RoundedCornersHelper.ApplyRoundedCorners(CancelBtn, 30);
        }

        private void Birthday_ValueChanged(object sender, EventArgs e)
        {
            Birthday.Format = DateTimePickerFormat.Long;
        }

        private void RegistrationPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UploadAvatarBtn_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Processing...";
            OpenFileDialog fileImage = new OpenFileDialog();
            fileImage.Title = "Select an Image";
            fileImage.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            
            if (fileImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    AvatarBox.Image = new Bitmap(fileImage.FileName);
                    string filePath = fileImage.FileName;
                    StatusLabel.Text = "Upload successful!";
                    StatusLabel.ForeColor = Color.Green;
                }
                catch (Exception ex)
                {
                    StatusLabel.Text = "Upload failed: " + ex.Message;
                    StatusLabel.ForeColor = Color.Red;
                }
            }
            else
            {
                StatusLabel.Text = "Upload cancelled.";
                StatusLabel.ForeColor = Color.Gray;
            }
        }
        private string ValidateAllFields()
        {
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    TextBox textBox = (TextBox)c;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return "Please fill in all fields!!!";
                    }
                }
            }
            if (!MaleBtn.Checked && !FemaleBtn.Checked) return "Please select a gender";
            if (!PasswordNormalization.IsPasswordValid(InputPassword.Text)) return "Password is invalid. It must be at least 8 character. It must have upper, lower, number, and special characters";
            if (ConfirmPassword.Text != InputPassword.Text)
            {
                return "Confirm Password is not the same as password";
            }
            return "Valid";
        }   
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (ValidateAllFields() == "Valid")
            {
                Customers objCustomer = new Customers();
                User obj = new User(InputUsername.Text, InputPassword.Text, objCustomer.ID);
                objCustomer.Name = InputCustomerName.Text;
                objCustomer.Birthday = Birthday.Value.ToString("dd/MM/yyyy");
                objCustomer.Gender = (MaleBtn.Checked == true) ? Genders.Male : Genders.Female;
                objCustomer.PassportNo = InputPassportNo.Text;
                objCustomer.Nationality = InputNationality.Text;
                objCustomer.Avatar = AvatarBox.Image;

                ParentForm.UsersList.Add(obj);
                ParentForm.CustomersList.Add(objCustomer);

                MessageBox.Show("New UserID is created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                if (ParentForm != null)
                    ParentForm.Show();
            }
            else MessageBox.Show(ValidateAllFields(), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (ParentForm != null)
                ParentForm.Show();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            AvatarBox.Image = Properties.Resources.Doraemon;
        }
        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (AvatarBox.Image != null)
            {
                AvatarBox.Image = null;
                StatusLabel.Text = "Avatar is removed.";
                StatusLabel.ForeColor = Color.Red;
            }
            else return;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All input fields will be cleared.", "Clear Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            InputCustomerName.Text = "Name";
            Birthday.Format = DateTimePickerFormat.Custom;
            InputPassportNo.Text = "Passport No.";
            InputNationality.Text = "Nationality";
            InputUsername.Text = "Username";
            InputPassword.Text = "Password";
            ConfirmPassword.Text = "Confirm Password";
            this.RemoveBtn_Click(sender, e);
        }

        private void InputCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (InputCustomerName.Text == "Name")
            {
                InputCustomerName.Text = "";
                InputCustomerName.ForeColor = Color.Black;
            }
        }

        private void InputPassportNo_TextChanged(object sender, EventArgs e)
        {
            if (InputPassportNo.Text == "Passport No.")
            {
                InputPassportNo.Text = "";
                InputPassportNo.ForeColor = Color.Black;
            }
        }
        private void InputNationality_TextChanged(object sender, EventArgs e)
        {
            if (InputNationality.Text == "Nationality")
            {
                InputNationality.Text = "";
                InputNationality.ForeColor = Color.Black;
            }
        }
        private void InputUsername_TextChanged(object sender, EventArgs e)
        {
            if (InputUsername.Text == "Username")
            {
                InputUsername.Text = "";
                InputUsername.ForeColor = Color.Black;
            }
        }
        private void InputPassword_TextChanged(object sender, EventArgs e)
        {
            if (InputPassword.Text == "Password")
            {
                InputPassword.Text = "";
                InputPassword.ForeColor = Color.Black;
                InputPassword.UseSystemPasswordChar = true;
            }
        }
        private void ConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (ConfirmPassword.Text == "Confirm Password")
            {
                ConfirmPassword.Text = "";
                ConfirmPassword.ForeColor = Color.Black;
                ConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void EyeIcon1_Click(object sender, EventArgs e)
        {
            if (InputPassword.Text == "Password") return;
            else InputPassword.UseSystemPasswordChar = !InputPassword.UseSystemPasswordChar;
        }
        private void EyeIcon2_Click(object sender, EventArgs e)
        {
            if (ConfirmPassword.Text == "Confirm Password") return;
            else ConfirmPassword.UseSystemPasswordChar = !ConfirmPassword.UseSystemPasswordChar;
        }
    }
}
