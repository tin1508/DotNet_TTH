using MainData;
using System.Runtime.CompilerServices;

namespace CompanyManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            company.CompanyName = "TechT Company";

            company.CompanyAddOrRemoveCustomer += new Company.CompanyHandler(UpdateNumberOfCustomers);

            Customer customer1 = company.AddCustomer("C001", "Minh Hoang", "Dong Nai", "09123456", CustomerType.TiemNang);
            Customer customer2 = company.AddCustomer("C002", "Tuan Khai", "Ho Chi Minh", "09234567", CustomerType.TrungThanh);
            Customer customer3 = company.AddCustomer("C003", "Nhat Khoi", "Ho Chi Minh", "09345678", CustomerType.CanQuanTam);

            //truoc khi thuc hien xoa
            Console.WriteLine("Before removing a customer:\n");
            company.CompanyInfo();

            Customer foundCustomer = company.SearchCustomer("Minh Hoang");
            company.RemoveCustomer(foundCustomer);

            //sau khi thuc hien xoa
            Console.WriteLine("\nAfter removing a customer:\n");
            company.CompanyInfo();

            Console.ReadKey();
        }
        static void UpdateNumberOfCustomers(Company company)
        {
            company.NumberOfCustomers = company.Customers.Count;
        }
    }
}
 
namespace MainData
{
    public class CustomerNotFoundException : Exception
    {
        public CustomerNotFoundException(string message) : base(message) { }
    }
    public class IndexOutOfRangeException : Exception
    {
        public IndexOutOfRangeException(string message) : base(message) { }
    }
    public static class MyExtensions
    {
        public static string ConvertToString(this Customer customer)
        {
            string customerType = Enum.GetName(typeof(CustomerType), customer.Type) ?? "Unknown";
            if (customer.CustomerID != String.Empty)
            {
                return String.Format("Customer ID: {0}, Name: {1}, Address: {2}, Phone: {3}, Type: {4}",
                    customer.CustomerID, customer.CustomerName, customer.CustomerAddress, customer.CustomerPhone, customerType);
            }
            else return "There is no customer";
        }
    }
    public enum CustomerType { TrungThanh, TiemNang, CanQuanTam, KhachHangKhac};
    public class Customer
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }

        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }
        public CustomerType Type { get; set; }
        internal Customer() { 
            CustomerID = string.Empty;
            CustomerName = string.Empty;
            CustomerAddress = string.Empty;
            CustomerPhone = string.Empty;
        }
        internal Customer(string id, string name, string address, string phone, CustomerType type)
        {
            CustomerID = id;
            CustomerName = name;
            CustomerAddress = address;
            CustomerPhone = phone;
            Type = type;
        }
        public void CustomerInfo()
        {
            Console.WriteLine("Customer ID: {0}", CustomerID);
            Console.WriteLine("Customer Name: {0}", CustomerName);
            Console.WriteLine("Customer Address: {0}", CustomerAddress);
            Console.WriteLine("Customer Phone: {0}", CustomerPhone);
            Console.WriteLine("Customer Type: {0}", Type);
        }
    }
    public class Company
    {
        public string CompanyName { get; set; }
        public List<Customer> Customers { get; set; }
        Dictionary<CustomerType, string> typeInfo = new Dictionary<CustomerType, string>();
        public int NumberOfCustomers { get; set; }
        public delegate void CompanyHandler(Company company);
        public event CompanyHandler CompanyAddOrRemoveCustomer;
        public Company()
        {
            CompanyName = string.Empty;
            Customers = new List<Customer>();
            NumberOfCustomers = 0;
            
            typeInfo.Add(CustomerType.TrungThanh, "Khach hang co niem tin va da gan bo voi cong ty lau nhat");
            typeInfo.Add(CustomerType.TiemNang, "Khach hang co kha nang tuong lai se tro thanh khach hang thuc su cua cong ty.");
            typeInfo.Add(CustomerType.CanQuanTam, "Khach hang can quan tam den gia tri san pham/dich vu cua cty");
            typeInfo.Add(CustomerType.KhachHangKhac, "Nhung khach hang khac khong nam trong cac loai tren");
        }
        public Customer AddCustomer(string id, string name, string address, string phone, CustomerType type)
        {
            Customer newCustomer = new Customer(id, name, address, phone, type);
            Customers.Add(newCustomer);
            OnCompanyChanger(this);
            return newCustomer;
        }
        public void RemoveCustomer(Customer customer)
        {
            if (Customers.Contains(customer))
            {
                Customers.Remove(customer);
                OnCompanyChanger(this);
            }
        }
        public void OnCompanyChanger(Company company)
        {
            if (CompanyAddOrRemoveCustomer != null)
            {
                CompanyAddOrRemoveCustomer(company);
            }
        }
        public Customer SearchCustomer<T> (T search)
        {
            try
            {
                if (search == null)
                {
                    throw new ArgumentNullException("Search parameter is null.");
                }
                if (typeof(T) == typeof(string))
                {

                    var customer = Customers.FirstOrDefault(c => c.CustomerName == search.ToString());
                    if (customer == null)
                    {
                        throw new CustomerNotFoundException("Customer with Name {" + search.ToString() + "} not found.");
                    }
                    return customer;
                }
                else if (typeof(T) == typeof(int))
                {
                    if (Convert.ToInt32(search) < Customers.Count)
                    {
                        return Customers[Convert.ToInt32(search)];
                    }
                    else throw new IndexOutOfRangeException("Index {" + search.ToString() + "} is out of range.");
                }
                else
                {
                    throw new ArgumentException("Invalid search type.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }
            catch (CustomerNotFoundException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return null!;
        }
        public void CompanyInfo()
        {
            Console.WriteLine("Company Name: {0}, the number of customers: {1}", CompanyName, NumberOfCustomers);
            Console.WriteLine("Customers:");
            foreach(Customer c in Customers)
            {
                KeyValuePair<CustomerType, string> info = typeInfo.FirstOrDefault(t => t.Key == c.Type);
                c.CustomerInfo();
                Console.WriteLine("Type Info: {0}", info.Value);
                Console.WriteLine("-------------------");
            }
        }
    }
}
