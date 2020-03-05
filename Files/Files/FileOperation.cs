﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    class FileOperation
    {
        public void CreateFile(string path)
        {
            if(!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    Console.Write("Enter Your Name:");
                    string name = Console.ReadLine();
                    Console.Write("Enter Your city:");
                    string city = Console.ReadLine();
                    sw.WriteLine("This is " + name);
                    sw.WriteLine("I am from " + city);
                }
            }
            else
            {
                Console.WriteLine("File Already exists.Delete and create the file");

            }
        }
        public void Display(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while((s=sr.ReadLine())!=null)
                {
                    Console.WriteLine("\n"+s);
                }
            }
        }

        public void AddToFile(string path)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                Console.WriteLine("\nEnter text to append\n");
                string s = Console.ReadLine();
                sw.WriteLine(s);
            }
        }
        public void Delete(string path)
        {
            File.Delete(path);
            Console.WriteLine("existing file is deleteed at " + path +"Create a File");
        }
    }
}
