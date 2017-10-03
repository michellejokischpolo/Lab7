using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Class1

    {
        string name;
        string homeTown;
        string food;
        int studentinput;
        int studentnumber;

        public Class1(string n, int i, string ht, string f)
        {
            name = n;
            studentnumber = i;
            homeTown = ht;
            food = f;

        }


        public void PrintHometown()
        {
        
            Console.WriteLine("Student is "  + name + ". What would you like to know about her? (enter favorite food or hometown)");
            string userline = Console.ReadLine();
            if (userline == "favorite food")
            { Console.WriteLine(name + "'s " + " favorite food is  " + food + ". Would you like to know more? enter (favorite food or hometown)"); }
            if (userline == "hometown")
            { Console.WriteLine(name + " is from "  + homeTown); }
            else
            { Console.WriteLine("That entry does not exist. Please try again. (enter hometown or favorite food)"); }; }


        public string StudentName()
        { return name; }

        public string HomeTown()
        {  
             return homeTown; }

        public string FavoriteFood()
        { return food;  }
 
              //  Console.WriteLine("Student " + studentinput + " is " + name + ".");

        }
    }
      