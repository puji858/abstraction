using System;

using System.Text;

 

namespace abstraction

{

    public class Laptop

    {

        private string merk;

        private string type;

        public string merk

        {

            get { return merk; }

            set { merk = value; }

        }

        public string tye

        {

            get { return type; }

            set { type = value; }

        }

        public void LaptopDetails()

        {

            Console.WriteLine("merk: " + merk);

            Console.WriteLine("merk: " + merk);

        }

        public void LaptopKeyboard()

        {

            Console.WriteLine("Type using Keyword");

        }

        private void MotherBoardInfo()

        {

            Console.WriteLine("informasi motherboard");

        }

        private void InternalProcessor()

        {

            Console.WriteLine("informasi prosesor");

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            Laptop l = new Laptop();

            l.merk = "Dell";

            l.type = "Inspiron 14R";

            l.LaptopDetails();

            Console.WriteLine("\nPress Enter Key to Exit..");

            Console.ReadLine();

        }

    }

}