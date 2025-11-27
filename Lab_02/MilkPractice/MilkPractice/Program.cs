using MainData;
using System.Globalization;
using System.Runtime.InteropServices;
using AttributeData;
using System.Net.Http.Headers;
using System.Security.Cryptography;

delegate int MilkeReadWrite(string filename);

namespace MilkPractice
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern int MessageBox(int hParent, string Message, string Caption, int Type);
        public static void Main(string[] args)
        {
            Milk newMilk = new Milk();
            //nhập thông tin sữa từ bàn phím
            newMilk.InputInfo();

            //khai báo các đối tượng thuộc kiểu delegate 
            MilkeReadWrite action1 = new MilkeReadWrite(newMilk.WriteMilkToFile);
            MilkeReadWrite action2 = new MilkeReadWrite(newMilk.ReadMilkFromFile);
            //sau đó ghi vào file

            action1.Invoke("D:\\Net_Programming\\Lab_02\\MilkData.txt");
            Console.WriteLine("Milk information has been written to file successfully.");

            //đọc thông tin sữa tư file vưa mới ghi

            action2.Invoke("D:\\Net_Programming\\Lab_02\\MilkData.txt");
            Console.WriteLine("Read milk information from file successfully.");
            Console.ReadKey();

        }
    }
}

namespace MainData
{
    public class InvalidNumException : Exception
    {
         public InvalidNumException(string message) : base(message) { }

    }
    public class InvalidDateException : Exception
    {
        public InvalidDateException(string message) : base(message) { }
    }
    interface IMilkAction
    {
        int ReadMilkFromFile(string filename);
        int WriteMilkToFile(string filename);
    }
    [MilkMoreInfo("TH Factory", "TH Corporation")]
    [MilkMoreInfo("Vinamilk Factory", "Vinamilk Enterprise")]
    public class Milk : IMilkAction
    {
        private string MilkID = String.Empty, MilkName = String.Empty;
        private DateTime ProductionDate, ExpiredDate;
        private int Quantity;
        public Milk()
        {
            this.ValMilkID = String.Empty;
            this.ValMilkName = String.Empty;
            this.ValProductionDate = DateTime.Now.ToString("dd/MM/yyyy");
            this.ValExpiredDate = DateTime.Now.ToString("dd/MM/yyyy");
            this.ValQuantity = 0;
        }
        public Milk(string milkName, string productionDate, string expiredDate, int quantity)
        {
            this.ValMilkName = milkName;
            this.ValProductionDate = productionDate;
            this.ValExpiredDate = expiredDate;
            this.ValQuantity = quantity;
            this.ValMilkID = String.Format("MILK{0}", this.ProductionDate.ToString("ddMMyyyy"));
        }
        public string ValMilkID
        {
            get { return MilkID; }
            set { MilkID = value; }
        }
        public string ValMilkName
        { 
            get { return MilkName; }
            set { MilkName = value; }
        }
        public string ValProductionDate
        {
            get { return ProductionDate.ToString("dd/MM/yyyy"); }
            set { ProductionDate = DateTime.ParseExact(value, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                this.MilkID = String.Format("MILK{0}", this.ProductionDate.ToString("ddMMyyyy"));
            }
        } 
        public string ValExpiredDate
        {
            get { return ExpiredDate.ToString("dd/MM/yyyy"); }
            set { ExpiredDate = DateTime.ParseExact(value, "dd/MM/yyyy", CultureInfo.InvariantCulture); }
        }
        public int ValQuantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }

        public override string ToString()
        {
            return "Milk ID: " + ValMilkID + ", Milk Name: " + ValMilkName + ", Production Date: " + ValProductionDate 
                + ", Expired Date: " + ValExpiredDate + ", Quantity: " + ValQuantity;
        }
        public void InputInfo()
        {
            Console.Write("Enter Milk Name: ");
            ValMilkName = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.Write("Enter Production Date (dd/MM/yyyy): ");
                    ValProductionDate = Console.ReadLine();
                    Console.Write("Enter Expired Date (dd/MM/yyyy): ");
                    ValExpiredDate = Console.ReadLine();
                    //kiểm tra xem ngày hết hạn có trước ngày sản xuất không?
                    if (DateTime.ParseExact(ValExpiredDate, "dd/MM/yyyy", CultureInfo.InvariantCulture) <=
                        DateTime.ParseExact(ValProductionDate, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                    {
                        throw new InvalidDateException("Expired Date must be after Production Date. Please re-enter.");
                    }
                    break; 
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid date format. Please use dd/MM/yyyy.");
                }
                catch (InvalidDateException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while(true)
            {
                try
                {
                    Console.Write("Enter Quantity: ");
                    ValQuantity = int.Parse(Console.ReadLine());
                    if (ValQuantity < 0)
                    {
                        throw new InvalidNumException("Quantity cannot be negative. Please re-enter.");
                    }
                    break; 
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number format. Please enter a valid integer.");
                }
                catch (InvalidNumException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Milk ID: " + ValMilkID);
            Console.WriteLine("Milk Name: " + ValMilkName);
            Console.WriteLine("Production Date: " + ValProductionDate);
            Console.WriteLine("Expired Date: " + ValExpiredDate);
            Console.WriteLine("Quantity: " + ValQuantity);
        }

        public int ReadMilkFromFile(string filename)
        {
            int counter = 0;
            string? line;
            System.IO.StreamReader file = new System.IO.StreamReader(filename);
            while ((line = file.ReadLine()) != null)
            {
                string[] terms = line.Split(':');
                if (line.Contains("Milk Name: ")) ValMilkName = terms[1].Trim();

                if (line.Contains("Production Date: ")) ValProductionDate = terms[1].Trim();
                if (line.Contains("Expired Date: ")) ValExpiredDate = terms[1].Trim();
                counter++;
            }
            file.Close();
            return counter;
        }
        public int WriteMilkToFile(string filename)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(filename);
            string content = "";
            content = String.Format("\n MilkID = {0}, \n Milk Name = {1},", ValMilkID, ValMilkName);
            file.WriteLine(content);
            content = String.Format("\n Production Date = {0},\n Expired Date = {1}", ValProductionDate, ValExpiredDate);
            file.WriteLine(content);
            content = String.Format("\n Quantity = {0}", ValQuantity);
            file.WriteLine(content);
            file.Close();
            return 1 ;
        }
    }   
    
}
namespace AttributeData
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class MilkMoreInfo : System.Attribute
    {
        private string Manufacturer = String.Empty, CompanyName = String.Empty;
        public MilkMoreInfo(string manufacturer, string companyName)
        {
            this.ValManufacturer = manufacturer;
            this.ValCompanyName = companyName;
        }
        public string ValManufacturer
        {
            get { return Manufacturer; }
            set { Manufacturer = value; }
        }
        public string ValCompanyName
        {
            get { return CompanyName; }
            set { CompanyName = value; }
        }

    }
}