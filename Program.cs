using System;
using System.Text;
namespace Lab1
{
    public static class Userdata{
        public static string ID;
        public static string UserName;
        public static float Health;
        public static double Point;
        static Userdata()
        {
            ID = "080803";
            UserName = "Leo";
            Health = 100.0f;
            Point = 100f;
        }
    }
    class Maps
    {
        public string ID;
        public string Name;
        public static string _inGame = "liên minh huyền thoại";

        public Maps(string id, string name)
        {
            ID = id;
            Name = name;
        }
        public Maps() { }
 


        public string ShowData()
        {
            return "ID: " + ID + "|Name: " + Name + "inGame: " + _inGame; 
        }
    }

     public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Id:"+ Userdata.ID);
            Console.WriteLine("Name:" + Userdata.UserName);
            Console.WriteLine("Health:" + Userdata.Health);
            Console.WriteLine("Point:" + Userdata.Point);
            var maps1 = new Maps("2024" , "URf ");
            Console.WriteLine(maps1.ShowData());
            var maps2 = new Maps()
            {
                ID = "2024",
                Name = "URF "
            };
            Console.WriteLine(maps2.ShowData());
            Bai3 bai3  = new Bai3(  );
            bai3.A = 10;
            bai3.B = 5;
            Console.WriteLine("A= " + bai3.A);
            Console.WriteLine("B= " + bai3.B);
            Console.WriteLine("Addition: " + bai3.Add());
            Console.WriteLine("Subtraction: " + bai3.Sub());
            Console.WriteLine("Multiplication: " + bai3.Mul());
            Console.WriteLine("Divication: " + bai3.Div());

        }
        
    }
}
