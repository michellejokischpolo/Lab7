using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            { 
            Class1 m = new Class1("Michelle", 1, "Ecuador", "Spaghetti");
            Class1 a = new Class1("Anel", 2, "Juarez", "Pizza");
            Class1 t = new Class1("Tammy", 3, "Grand Rapids", "Sushi");

            List<Class1> students = new List<Class1>();
            students.Add(m);
            students.Add(a);
            students.Add(t);

            Console.WriteLine("Welcome to the Develop[HER] Class");
            Console.WriteLine("Which student would you like to learn more about? (enter a number 1-3 )");

            int userinput = Int32.Parse(Console.ReadLine());
            Class1 requested = students[userinput - 1];                Console.WriteLine("That student is not in the class. (enter a number from 1-3)");
            Console.WriteLine("Student " + userinput + " is " + requested.StudentName() + ".");
            Console.WriteLine("What would you like to know about " + requested.StudentName() + " enter (favorite food or hometown)");
            string userline = Console.ReadLine();

            userline = userline.ToLower();
            if (userline == "favorite food")
            {
                Console.WriteLine(requested.StudentName() + " favorite food is  " + requested.FavoriteFood() + ". Would you like to know more? enter (favorite food or hometown)");
                string userline3 = Console.ReadLine();
                Console.WriteLine(requested.StudentName() + " favorite food is " + requested.FavoriteFood());
            }
             if (userline == "hometown")
            {
                Console.WriteLine(requested.StudentName() + " 's hometown is " + requested.HomeTown() + " Would you like to know more? enter (favorite food or hometown)");
                string userline4 = Console.ReadLine();
                Console.WriteLine(requested.StudentName() + " favorite food is " + requested.FavoriteFood());
            }

           
            else
            {
                Console.WriteLine("That entry does not exist. Please try again. (enter hometown or favorite food)");
            } /// i do not understand continue loops.... could you help me?
        }

     
            }
    }
}