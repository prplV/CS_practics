using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;

namespace practica
{
    /*
    [Serializable]
    public class Calc
    {
        public int i { get; set; }
        public int b { get; set; }

        public Calc() {
        
        }
        public Calc(int num1, int num2)
        {
            i = num1;
            b = num2;
        }
    }
    class Program
    {
        static void Main()
        {
            Calc nabor1 = new Calc(13, 21);

            XmlSerializer formatter = new XmlSerializer(typeof(Calc));

            using (FileStream fl = new FileStream("1.xml", FileMode.Append))
            {
                formatter.Serialize(fl, nabor1);
            }
            
        }
    }
    */

    /*
    class Program 
    {   
        static void Main()
        {
            
            List<string> countries = new List<string>() { "Russia", "France", "Germany", "China"};
            countries.Add("USA");
            countries.RemoveAt(3);
            //
            
            
        }
    }
    */

    class Program 
    {
        static void Main() 
        {
            List<string> polz = new List<string>();
            char o = ' ';

            while (true)
            {
                Console.WriteLine("Enter operation (1 - add polz, 2 - search polz, 3 - delete polz, 4 - show all users, 0 - exit)");
                try
                {
                    o = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception exp) {
                    Console.WriteLine($"***********Exception:***********{'\n'}{exp}");
                }
                if (o == '1')
                {
                    Console.WriteLine("Enter name, fname and lname of new user splitted by char ' ': ");
                    string new_polz = Console.ReadLine();
                    polz.Add(new_polz);
                    Console.WriteLine("***********New user was succesfully added!***********");
                }
                else if (o == '2')
                {
                    Console.WriteLine("Enter name, fname and lname of the user who you're looking for:");
                    string find = Console.ReadLine();
                    string result = null;
                    foreach (string pol in polz)
                    {
                        if (pol.Contains(find))
                        {
                            result = pol;
                        }
                    }
                    if (result == "")
                    {
                        Console.WriteLine("This user doesn't exist");
                    }
                    else {
                        Console.WriteLine($"***********Your user exists***********{'\n'}Full name = {result}");
                    }
                }
                else if (o == '3')
                {
                    Console.WriteLine("Enter name, fname and lname of the user who you'd like to delete:");
                    string delete = Console.ReadLine();
                    int result = 0;
                    foreach (string user in polz) {
                        if (user.Contains(delete) == false)
                        {
                            result++;
                        }
                        else {
                            string outsider = user;
                            polz.RemoveAt(result);
                            Console.WriteLine($"***********Succesfull operation!***********");
                            Console.WriteLine($"User {outsider} was succesfully deleted!");
                            break;
                        }

                    }
                    Console.WriteLine("This user doesn't exist");
                }
                else if (o == '4')
                {
                    int counter = 1;
                    Console.WriteLine("***********Users:***********");
                    foreach (string user in polz)
                    {
                        Console.WriteLine($"{counter}) {user}");
                    }
                    Console.WriteLine("***********End of array***********");
                }
                else if (o == '0') 
                {
                    break;
                }
                else
                {
                    Console.WriteLine("*********************************");
                }
            }
        }
    }
}
