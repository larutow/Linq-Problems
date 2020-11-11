using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ
{
    public static class LinqProblems
    {
        //Weighted project points: /10
        //Project points: /25
       
        #region Problem 1 
        //(5 points) Problem 1
        //Using LINQ, write a method that takes in a list of strings and returns all words that contain the substring “th” from a list.
        public static List<string> RunProblem1(List<string> words)
        {
            //code
            List<string> thlist = words.Where(w => w.Contains("th")).ToList();
            //return
            return thlist;

        }
        #endregion

        #region Problem 2 
        //(5 points) Problem 2
        //Using LINQ, write a method that takes in a list of strings and returns a copy of the list without duplicates.
        public static List<string> RunProblem2(List<string> names)
        {
            //code
            List<string> uniquenames = names.Distinct().ToList();

            //return
            return uniquenames;
        }
        #endregion

        #region Problem 3
        //(5 points) Problem 3
        //Using LINQ, write a method that takes in a list of customers and returns the lone customer who has the name of Mike. 
        public static Customer RunProblem3(List<Customer> customers)
        {
            //code
            Customer targetCustomer = customers.Where(c => c.FirstName == "Mike").FirstOrDefault();
            //return
            return targetCustomer;

        }
        #endregion

        #region Problem 4
        //(5 points) Problem 4
        //Using LINQ, write a method that takes in a list of customers and returns the customer who has an id of 3. 
        //Then, update that customer's first name and last name to completely different names and return the newly updated customer from the method.
        public static Customer RunProblem4(List<Customer> customers)
        {
            //code
            Customer num3 = customers.Where(c => c.Id == 3).FirstOrDefault();
            num3.FirstName = "The";
            num3.LastName = "Dude";

            //return
            return num3;

        }
        #endregion

        #region Problem 5
        //(5 points) Problem 5
        //Using LINQ, write a method that calculates the class grade average after dropping the lowest grade for each student.
        //The method should take in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), 
        //drops the lowest grade from each string, averages the rest of the grades from that string, then averages the averages.
        //Expected output: 86.125
        public static double RunProblem5(List<string> classGrades)
        {

            List<double> doubleClassGrades = new List<double>();

            //code
            foreach(string student in classGrades)
            {
                List<double> studentgrades = Array.ConvertAll(student.Split(','), double.Parse).ToList();
                studentgrades.Remove(studentgrades.Min());
                doubleClassGrades.Add(studentgrades.Average());
            };

            return doubleClassGrades.Average();

        }
        #endregion

        #region Bonus Problem 1
        //    (5 points) Bonus Problem 1
        //    Write a method that takes in a string of letters(i.e. “Terrill”)
        //    and returns an alphabetically ordered string corresponding to the letter frequency(i.e. "E1I1L2R2T1")
        public static string RunBonusProblem1(string word)
        {
            //code
            //first order string
            char[] w = word.ToUpper().ToCharArray();
            Array.Sort(w);
            //EILLRRT

            //create list to track duplicate char count
            List<int> numOfChars = new List<int>();
            int counter = 1;
            
            //count characters
            for (int i = 0; i < w.Length; i++)
            {
                if(i == w.Length - 1)
                {
                    numOfChars.Add(counter);
                    break;
                }
                
                if (w[i] == w[i + 1])
                {
                    counter++;
                    continue;
                }
                else
                {
                    numOfChars.Add(counter);
                    counter = 1;
                }
            }
            
            //make array a list of distinct chars using Distinct method
            List<char> uniqueLetters = w.Distinct().ToList();

            //build stringbuilder using the distinct
            StringBuilder s = new StringBuilder();
            for(int i = 0; i < uniqueLetters.Count; i++)
            {
                s.Append(uniqueLetters[i]);
                s.Append(numOfChars[i]);
            }
            //return answer (using .ToString())
            return s.ToString();

        }
            #endregion
    }
}
