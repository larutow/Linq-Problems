using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            LinqProblems.RunProblem1(words);


            //Problem 2
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            LinqProblems.RunProblem2(names);

            //Problem 3 & Problem 4
            List<Customer> customers = new List<Customer>()
            {
                new Customer(1, "Mike", "Rodgers"),
                new Customer(2, "Nick", "Allen"),
                new Customer(3, "Jason", "Ryan"),
                new Customer(4, "Dan", "Laffey")
            };

            LinqProblems.RunProblem3(customers);
            LinqProblems.RunProblem4(customers);
 

            //Problem 5
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65", 
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };
            double result = LinqProblems.RunProblem5(classGrades);

            //--------------------
            //Bonus Problem 1
            string letters = "terrill";
            string answer = LinqProblems.RunBonusProblem1(letters);

        }
    }
}
