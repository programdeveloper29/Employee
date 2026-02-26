using System;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int i = 0;
            //objects
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            //Write with static value
            //emp1.FirstName = "Ahmed";
            //emp1.LastName = "Amgad";
            //emp2.FirstName = "Nour";
            //emp2.LastName = "Ali";
            //Console.Write("Enter Fist Name: ");
            //emp1.FirstName=Console.ReadLine();
            //Console.Write("\n Enter Last Name:");
            //emp1.LastName=Console.ReadLine();
            //Console.Write("\n Enter Address:");
            //emp1.Address(Console.ReadLine(), Console.ReadLine());

            //Console.Write("Enter Fist Name: ");
            //emp2.FirstName = Console.ReadLine();
            //Console.Write("\n Enter Last Name:");
            //emp2.LastName = Console.ReadLine();
            //Console.Write("\n Enter Address:");

            //emp2.Address(Console.ReadLine(), Console.ReadLine());
            ////Read the value by using properties
            /// -------------------------------------
            //Console.WriteLine(emp1.FirstName +" " +emp1.LastName);
            //Console.WriteLine(emp2.FirstName +" " +emp2.LastName);
            // =====================================================
            //Using Read only Property 
            //---------------------------
            //Console.WriteLine(emp1.FullName);
            //Console.WriteLine(emp2.FullName);
            //====================================
            //Using Read only Method
            //-------------------------------
            //Console.WriteLine(emp1.GetFullName());
            //Console.WriteLine(emp1.GetAddress());
            //Console.WriteLine(emp2.GetFullName("DR"));
            //Console.WriteLine(emp2.GetAddress());
            
            

            //Use Do While
            char ch;
            Console.WriteLine("Enter the Data of Employee");
            do
            {
                string city = null, district = null, street = null;
                Employee emp= new Employee();
                Console.Write("Enter Fist Name: ");
                emp.FirstName = Console.ReadLine();
                Console.Write("\nEnter Last Name:");
                emp.LastName = Console.ReadLine();
                
                Console.WriteLine("\nPlease Select For Address:\n \n 1 To Enter City.\n 2 To Enter  City and District.\n 3 To Enter  FUll Address: ");
                string input= Console.ReadLine();
                if (Int32.TryParse(input, out i))
                    {
                    switch (i)
                    {
                        case 1:
                            Console.Write("City: " );
                            city = Console.ReadLine();
                            emp.Address(city);
                            
                            break;
                        case 2:
                            Console.Write("City: ");
                            city = Console.ReadLine();
                            Console.Write(" District:" );
                            district = Console.ReadLine();
                            emp.Address(city, district);
                            break;
                        case 3:
                            Console.Write("City: ");
                            city = Console.ReadLine();
                            Console.Write("District:");
                            district = Console.ReadLine();
                            emp.Address(city, district);
                            Console.Write("Street:");
                            street = Console.ReadLine();
                            emp.Address(city,district,street);
                            break;
                        default:
                            
                            emp.Address(city);
                            break;
                    } }
                else
                {
                    Console.WriteLine("You Enter Invalid Number!");
                }
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Full Name: {0}", emp.GetFullName());
                Console.WriteLine("Address: " + emp.GetAddress());
                Console.WriteLine("-----------------------------------");

                Console.WriteLine("\n\nChose 'y' for Another Employee");
                ConsoleKeyInfo key = Console.ReadKey(); ch = key.KeyChar;
            } while (ch == 'y');

            Console.ReadKey();
        }
    }
    public class Employee
    {//Fields
      private  string _FirstName;
       private string _LastName;
       private string _City;
       private string _District;
       private String _Street;
        //Properties
        internal string FirstName 
        { get { return _FirstName; }
            set {  _FirstName = value; } 
        }
        internal string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        // Read only
        internal string FullName { get { return _FirstName+"  "+_LastName; } }
        //Methods 
        // Use vaildation 
        internal string GetFullName(string title= null) { 
            return (String.IsNullOrEmpty(title) ?  FullName : title + ": " + FullName); }
        //Overload
        internal void Address(string city) {_City = city;}
        internal void Address(string city, string district ) { _City = city; _District = district; }
        internal void Address(string city, string district, string street) { _City = city; _District = district;
            _Street = street;}
        internal string GetAddress() 
        {
            if (string.IsNullOrEmpty(_City) && string.IsNullOrEmpty(_District) && string.IsNullOrEmpty(_Street))
                return "No Address";
            else if (string.IsNullOrEmpty(_District) && string.IsNullOrEmpty(_Street))
                return _City + ".";
            else if (string.IsNullOrEmpty(_Street))
                return _City + ", " + _District + ".";
            else
                return _City + ", " + _District + ", " + _Street +".";




                    }
    }
}
