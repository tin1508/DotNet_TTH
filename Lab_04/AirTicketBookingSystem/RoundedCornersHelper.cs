using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace AirTicketBookingSystem
{
    internal class RoundedCornersHelper
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,     
            int nTopRect,      
            int nRightRect,    
            int nBottomRect,   
            int nWidthEllipse, 
            int nHeightEllipse 
        );
        [DllImport("Gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(IntPtr hObject);
        public static void ApplyRoundedCorners(Control control, int radius) { 
            IntPtr ptr = CreateRoundRectRgn(0, 0, control.Width, control.Height, radius, radius);
            control.Region = Region.FromHrgn(ptr);
            DeleteObject(ptr); //tranh ro ri bo nho
        }
    }
}
