using System;
using MainData;

namespace AnimalManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a. Tạo danh sách gồm 3 con chó và 2 con mèo
            int nDog = 3, nCat = 2;
            Animal[] animalList = new Animal[nDog + nCat];
            //b. Nhập và xuất thông tin của các con vật
            for(int i = 0; i < nDog; i++)
            {
                Animal dog = new Dog();
                dog.InputInfo();
                animalList[i] = dog;
            }
            for(int i = 0; i < nCat; i++)
            {
                Animal cat = new Cat();
                cat.InputInfo();
                animalList[nDog + i] = cat;
            }
            //xuất  thông tin của các con vật ra
            foreach(Animal animal in animalList)
            {
                animal.DisplayInfo();
            }
            Console.ReadLine();
        }
    }
}

namespace MainData
{
    //c.bắt lỗi khi nhập tuổi âm hoặc lớn hơn 20
    public class InvalidNumException: Exception
    {
        public InvalidNumException(string message) : base(message) { }
    }
    public abstract class Animal
    {
        protected string name;
        protected int age;
        protected double height, weight; //weight tính theo đơn vị kg
        public Animal() { }
        public Animal(string name, int age, double height, double weight)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
        }
        public abstract void InputInfo();
        public abstract void DisplayInfo();
        public abstract void InputAge();
        public abstract void InputHeight();
        public abstract void InputWeight();
        public override string ToString()
        {
            return "name = " + this.name + ", Age = " + this.age
                    + ", Height = (cm)" + this.height + ", Weight = (kg)" + this.weight + "\n";
        }
       
    }
    public class Dog : Animal
    {
        
        public Dog() : base() { }
        public Dog(string name, int age, int height, double weight) : base(name, age, height, weight) { }
        

        public override void InputInfo()
        {
            Console.Write("Input Dog name: ");
            this.name = Console.ReadLine();
            InputAge();
            InputHeight();
            InputWeight();
        }
        public override void InputAge()
        {
            while (true)
            {
                try
                {
                    Console.Write("Input Dog Age: ");
                    age = int.Parse(Console.ReadLine());
                    if (age <= 0 || age > 20) throw new InvalidNumException("Age must be between 1 and 20.");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not input a Number. Please reinput a number!");
                }
                catch (InvalidNumException e)
                {
                    Console.WriteLine("Invalid Number: {0}", e.Message);
                }
            }
        }
        //d. Bắt lỗi khi người dùng nhập chuỗi hay ký tự (không phải số) các thông tin Height và Weight 
        public override void InputHeight()
        {
            while (true)
            {
                try
                {
                    Console.Write("Input Dog height (cm): ");
                    height = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not input a Number. Please reinput a number!");
                }
            }
        }
        public override void InputWeight()
        {
            while (true)
            {
                try
                {
                    Console.Write("Input Dog weight (kg): ");
                    weight = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not input a Number. Please reinput a number!");
                }
            }
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Dog Name = {0}, Age = {1}, " +
                "Height = {2} (cm), Weight = {3} (kg)", name, age, height, weight);
        }
        public override string ToString()
        {
            return "Dog " + base.ToString();
        }
    }

    public class Cat : Animal
    {
        public Cat() : base() { }
        public Cat(string name, int age, int height, double weight) : base(name, age, height, weight) { }
        public override void InputInfo()
        {
            Console.Write("Input Cat name: ");
            this.name = Console.ReadLine();
            InputAge();
            InputHeight();
            InputWeight();
        }
        public override void InputAge()
        {
            while (true)
            {
                try
                {
                    Console.Write("Input Cat Age: ");
                    age = int.Parse(Console.ReadLine());
                    if (age <= 0 || age > 20) throw new InvalidNumException("Age must be between 1 and 20.");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not input a Number. Please reinput a number!");
                }
                catch (InvalidNumException e)
                {
                    Console.WriteLine("Invalid Number: {0}", e.Message);
                }
            }
        }
        //d. Bắt lỗi khi người dùng nhập chuỗi hay ký tự (không phải số) các thông tin Height và Weight 
        public override void InputHeight()
        {
            while (true)
            {
                try
                {
                    Console.Write("Input Cat height (cm): ");
                    height = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not input a Number. Please reinput a number!");
                }
            }
        }
        public override void InputWeight()
        {
            while (true)
            {
                try
                {
                    Console.Write("Input Cat weight (kg): ");
                    weight = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not input a Number. Please reinput a number!");
                }
            }
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Cat Name = {0}, Age = {1}, " +
                "Height = {2} (cm), Weight = {3} (kg)", name, age, height, weight);
        }
        public override string ToString()
        {
            return "Cat " + base.ToString();
        }
    }
    
}
