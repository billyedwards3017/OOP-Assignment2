﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace CMP1903MAssignment2BillyEdwardss
{
    class Program
    {
        static void Main(string[] args)
        {
            int Choice1;
            string temp;
            int Choice2;
            Dictionary<int, string> GitRepos = new Dictionary<int, string>();
            //Declaring the variables required for the program

            GitRepos.Add(1, "GitRepositories_1a.txt");
            GitRepos.Add(2, "GitRepositories_1b.txt");
            GitRepos.Add(3, "GitRepositories_2a.txt");
            GitRepos.Add(4, "GitRepositories_2b.txt");
            GitRepos.Add(5, "GitRepositories_3a.txt");
            GitRepos.Add(6, "GitRepositories_3b.txt");
            //This adds the key and value pairs into the dictionary for the viable text documents

            foreach(KeyValuePair<int, string> item in GitRepos)
            {
                Console.WriteLine("Please enter {0} if you want to use {1}", item.Key, item.Value);
            }
            //This will write to the console each option of text document that the user can choose from, allowing new text docuemtns to be added easily
            do
            {
                Console.WriteLine("Input the value corrosponding to the first text file you would like to compare");               
                temp = (Console.ReadLine());
                int.TryParse(temp, out Choice1);
            } while (!(Choice1 == 1 || Choice1 == 2 || Choice1 == 3 || Choice1 == 4 || Choice1 == 5 || Choice1 == 6));
            //This will take the users input in the first text document that they will want to use. This also includes a error handle which means the only viable inputs are the displayed options
            do {
                Console.WriteLine("Input the value corrosponding to the second text file you would like to compare");
                temp = (Console.ReadLine());
                int.TryParse(temp, out Choice2); 
            } while (!(Choice2 == 1 || Choice2 == 2 || Choice2 == 3 || Choice2 == 4 || Choice2 == 5 || Choice2 == 6));
            //this does the same as the above code but for the second option
            string Git1a = File.ReadAllText(Convert.ToString(GitRepos[Choice1]));
            string Git1b = File.ReadAllText(Convert.ToString(GitRepos[Choice2]));
            //This will extract the text from the chosen text file into string variables
            if (Git1a == Git1b)
            {
                Console.WriteLine($"{GitRepos[Choice1]} and {GitRepos[Choice2]} not different.");
            }
            else
            {
                Console.WriteLine($"{GitRepos[Choice1]} & {GitRepos[Choice2]} are different.");
            }
            //this section of code compares the text of each file and if there are no differences, it will write to the console there are no diferences and vice versa
            Console.ReadKey();
        }
    }
}
