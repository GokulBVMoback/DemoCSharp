using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TypeConvertion
            TypeCast(17,27.30);
            
            //Find South Indian State`s Capital using Switch Statement  
            switchState();

        }
        static void TypeCast(int myNum,double myDoub,string str="100")
        {
            //Implicit Type Casting(automatic Convertion)
            float myFloat=myNum;
            Console.WriteLine("Converting from Integer to Float. Int value=" + myNum+ "\nConverted Float value="+myFloat);
            
            //Explicit Type Casting
            int myNum2=(int)myDoub;
            short myShort=(short)myNum;
            Console.WriteLine("\nConverting from Double to Integer. double value=" + myDoub + "\nConverted Integer value=" + myNum2);
            Console.WriteLine("\nConverting from Integer to Short. Int value=" + myNum + "\nConverted Short value="+myShort);

            //Converting String to Int using Convert Class Helper
            int myNum3 = Convert.ToInt16(str);
            double myDouble2=Convert.ToDouble(str);
            Console.WriteLine("\nConverting from String to Int. String value=" + str + "\nConverted Integer value=" + myNum3);
            Console.WriteLine("\nConverting from String to Double. String value=" + str + "\nConverted Double value=" + myDouble2+"\n");
        }
        static void switchState(string state="Tamil Nadu")
        {
            switch(state)
            {
                case "Andra Pradesh":
                        Console.WriteLine(state + " Capital is Visakhapatnam");
                    break;
                case "Karnataka":
                    Console.WriteLine(state + " Capital is Bangalore");
                    break ;
                case "Kerala":
                    Console.WriteLine(state + " Capital is Thiruvananthapuram");
                    break;
                case "Tamil Nadu":
                    Console.WriteLine(state + " Capital is Chennai");
                    break;
                case "Telangana":
                    Console.WriteLine(state + " Capital is Hyderabad");
                    break;
                default:
                    Console.WriteLine(state +" is not in South India or given State variable is not State");
                    break;
            }
        }
    }
}
