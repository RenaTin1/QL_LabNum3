using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber3
{
    class Program
    {
        static void Main(string[] args)
        {
            //LAB NUMBER 3- Serena Tindle

            bool ContinueOn = true;
            while (ContinueOn == true)
            {

                int x;
                //User Input
                Console.WriteLine("Learn your squares and cubes"); 
                Console.WriteLine("Enter an integer:"); //ask for a integer
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Number" + "\t" + "Square" + "\t" + "Cubed"); //name columns
                for (int i= 0; i <= x; i++) //Process
                {
                    Console.WriteLine(i +"\t" + Math.Pow(i,2) + "\t" + Math.Pow(i, 3)); //print value of integer squared an cubed
                }
                string Userinput;
                Console.WriteLine("Continue? (Y / N)");
                Userinput = Console.ReadLine();
                if (Userinput == "N" || Userinput =="No" || Userinput== "no") //User decides to continue or not
                {
                    ContinueOn = false;

                    Console.ReadKey();
                }
            }
        }
    }
}
