using System;
using System.Collections.Generic;
using System.Text;

namespace AirTicketBookingSystem
{
    internal class PasswordNormalization
    {
        public static bool IsPasswordValid(string password)
        {
            // Kiem tra do dai toi thieu phai la 8 ky tu
            if (password.Length < 8)
                return false;
            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;
            bool hasSpecial = false;
            //kiem tra trong mat khau phai co chu cai in hoa, chu cai thuong, chu so va ky tu dac biet
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    hasUpper = true;
                else if(char.IsLower(c))
                     hasLower = true;
                else if (char.IsDigit(c))
                    hasDigit = true;
                else if (!char.IsLetterOrDigit(c))
                    hasSpecial = true;
            }
            return hasUpper && hasLower && hasDigit && hasSpecial;
        }
    }
}
