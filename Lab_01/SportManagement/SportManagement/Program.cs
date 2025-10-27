using MainData;
using System.Runtime.CompilerServices;

namespace SportManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cho nhập 2 môn bóng đá, 2 tennis và 2 bóng chuyển
            int nFootball = 2, nTennis = 2, nVolleyball = 2;
            Sport[] sports = new Sport[nFootball + nTennis + nVolleyball];
            //nhập và xuất thông tin của các môn thể thao
            for(int i = 0; i < nFootball; i++)
            {
                Sport footBall = new Football();
                footBall.InputInfo();
                sports[i] = footBall;
            }
            for(int i = 0; i < nTennis; i++)
            {
                Sport tennis = new Tennis();
                tennis.InputInfo();
                sports[nFootball + i] = tennis;
            }
            for(int i = 0; i < nVolleyball; i++)
            {
                Sport volleyBall = new Volleyball();
                volleyBall.InputInfo();
                sports[nFootball + nTennis + i] = volleyBall;
            }
            foreach(Sport s in sports)
            {
                s.DisplayInfo();
            }
            Console.ReadLine();
        }
    }
}

namespace MainData
{
    //dùng để bắt lỗi khi nhập quá số người chơi cho phép của môn thể thao
    //thêm vào đó mỗi môn thể thao thường số lượng người chơi sẽ là số chẵn, vì mỗi bên phải có số người bằng nhau
    public class InvalidNumException : Exception
    {
        public InvalidNumException(string message) : base(message) { }
    }
    public abstract class Sport
    {
        protected string name;
        protected int playerQuantity; //số lượng người chơi
        protected string timePlay; //thời gian chơi, để string do có thể tính set hoặc phút 
        protected string ballType; //loại bóng
        public Sport() { }
        public Sport(int playerQuantity, string timePlay, string ballType)
        {
            this.playerQuantity = playerQuantity;
            this.timePlay = timePlay;
            this.ballType = ballType;
        }
        public virtual void InputInfo()
        {
            Console.WriteLine("Enter information of {0}", name);
            InputPlayerQuantity();
            Console.Write("Input time play: ");
            this.timePlay = Console.ReadLine();
            Console.Write("Input ball type: ");
            this.ballType = Console.ReadLine();
        }
        public abstract void InputPlayerQuantity();
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Name = {0}, Player Quantity = {1}, Time = {2}, Ball Type = {3}", name, playerQuantity, timePlay, ballType);
        }

        public override string ToString()
        {
            return "Name = " + name + ", Player Quantity = " + playerQuantity + ", Time = " + timePlay
                    + ", Ball Type = " + ballType + "\n";
        }
    }
    public class Football : Sport
    {

        public Football() : base()
        {
            this.name = "Football";
        }
        public Football(int playerQuantity, string timePlay, string ballType) : base(playerQuantity, timePlay, ballType)
        {
            this.name = "Football";
        }
        public override void InputPlayerQuantity()
        {
            while (true)
            {
                try
                {
                    Console.Write("Input player quantity: ");
                    string str = Console.ReadLine();
                    playerQuantity = int.Parse(str);
                    if (playerQuantity <= 0 || playerQuantity > 22 || playerQuantity % 2 != 0) //vì mỗi đội bóng đá có tối đa 11 người
                    {
                        throw new InvalidNumException("The number of players must be between 1 and 22 and it must be even.");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input not a number. Please reinput a number!!!!");
                }
                catch (InvalidNumException e)
                {
                    Console.WriteLine("Invalid number: {0}", e.Message);
                }
            }
        }
    }
    public class Tennis : Sport
    {
        public Tennis() : base()
        {
            this.name = "Tennis";
        }
        public Tennis(int playerQuantity, string timePlay, string ballType) : base(playerQuantity, timePlay, ballType)
        {
            this.name = "Tennis";
        }
        public override void InputPlayerQuantity()
        {
            while (true)
            {
                try
                {
                    Console.Write("Input player quantity: ");
                    string str = Console.ReadLine();
                    playerQuantity = int.Parse(str);
                    if (playerQuantity <= 0 || playerQuantity > 4 || playerQuantity % 2 != 0) //vì mỗi đội tennish có tối đa 2 người
                    {
                        throw new InvalidNumException("The number of players must be between 1 and 4 and it must be even.");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input not a number. Please reinput a number!!!!");
                }
                catch (InvalidNumException e)
                {
                    Console.WriteLine("Invalid number: {0}", e.Message);
                }
            }
        }
    }
    public class Volleyball : Sport
    {
        public Volleyball() : base()
        {
            this.name = "Volleyball";
        }
        public Volleyball(int playerQuantity, string timePlay, string ballType) : base(playerQuantity, timePlay, ballType)
        {
            this.name = "Volleyball";
        }
        public override void InputPlayerQuantity()
        {
            while (true)
            {
                try
                {
                    Console.Write("Input player quantity: ");
                    string str = Console.ReadLine();
                    playerQuantity = int.Parse(str);
                    if (playerQuantity <= 0 || playerQuantity > 12 || playerQuantity % 2 != 0) //vì mỗi đội bóng chuyền có tối đa 6 người
                    {
                        throw new InvalidNumException("The number of players must be between 1 and 12 and it must be even.");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input not a number. Please reinput a number!!!!");
                }
                catch (InvalidNumException e)
                {
                    Console.WriteLine("Invalid number: {0}", e.Message);
                }
            }
        }
    }
}
