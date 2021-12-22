using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frozen
{
    internal class Program
    {
        class person
        {
            string character;
            string gift;
            
            public person(string _character, string _gift)
            {
                character = _character;
                gift = _gift;
                
            }

            public string Character
            {
                get { return character; }
            }

            public string Gift
            {
                get { return gift; }
            }
                        
        }


        static void Main(string[] args)
        {
            List<person> myPersons = new List<person>();
            string[] personsFromFile = GetDataFromFile();

            foreach (string line in personsFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                person newPerson = new person(tempArray[0], tempArray[1]);
                myPersons.Add(newPerson);

            }

            foreach (person personFromList in myPersons)
            {
                Console.WriteLine($"{personFromList.Character} wants {personFromList.Gift}.");
            }

        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\lembe\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}
