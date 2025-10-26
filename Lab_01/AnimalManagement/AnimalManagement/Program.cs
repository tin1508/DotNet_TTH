//23110156-Nguyễn Minh Hoàng
using System;
using System.Runtime.InteropServices;
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
        protected double height, weight; //weight tính theo đơn vị kg, height tính theo đơn vị cm
        public Animal() {
            this.name = "";
        }
        public Animal(string name, int age, double height, double weight)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
        }
        public virtual void InputInfo()
        {
            Console.Write("Input {0} name: ", GetType().Name);
            name = Console.ReadLine();
            InputAge();
            InputHeight();
            InputWeight();
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine("{0} Name = {1}, Age = {2}, " +
                "Height = {3} (cm), Weight = {4} (kg)", GetType().Name, name, age, height, weight);
        }
        public virtual void InputAge()
        {
            while (true)
            {
                try
                {
                    Console.Write("Input {0} Age: ", GetType().Name);
                    string strAge = Console.ReadLine();
                    age = int.Parse(strAge);
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
        //bắt lỗi khi người dùng nhập chuỗi kí tự thay vì số cho height và weight
        public virtual void InputHeight()
        {
            while (true)
            {
                try
                {
                    Console.Write("Input {0} height (cm): ", GetType().Name);
                    string strHeight = Console.ReadLine();
                    height = double.Parse(strHeight);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not input a Number. Please reinput a number!");
                }
            }
        }
        public virtual void InputWeight()
        {
            while (true)
            {
                try
                {
                    Console.Write("Input {0} weight (kg): ", GetType().Name);
                    string strWeight = Console.ReadLine();
                    weight = double.Parse(strWeight);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not input a Number. Please reinput a number!");
                }
            }
        }
        public override string ToString()
        {
            return GetType().Name +  " name = " + this.name + ", Age = " + this.age
                    + ", Height = (cm)" + this.height + ", Weight = (kg)" + this.weight + "\n";
        }
       
    }
    public class Dog : Animal
    {
        
        public Dog() : base() { }
        public Dog(string name, int age, int height, double weight) : base(name, age, height, weight) { }
        
    }

    public class Cat : Animal
    {
        public Cat() : base() { }
        public Cat(string name, int age, int height, double weight) : base(name, age, height, weight) { }

    }
}
