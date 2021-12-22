using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAndFiles
{
    internal class Program
    {
        class movie
        {
            string title;
            string rating;
            string year;

            public movie(string _title, string _rating, string _year)
            {
                title = _title;
                rating = _rating;
                year = _year;

            }

            public string Title
            {
                get { return title; }
            }

            public string Rating
            {
                get { return rating; }
            }

            public string Year
            {
                get { return year; }
            }
        }
                    

        static void Main(string[] args)
        {
            List<movie> myMovies = new List<movie>();
            string[] moviesFromFile = GetDataFromFile();

            foreach(string line in moviesFromFile)
            {
                string[] tempArray = line.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
                movie newMovie =new movie(tempArray[0], tempArray[1], tempArray[2]);
                myMovies.Add(newMovie);

            }

            foreach(movie movieFromList in myMovies)
            {
                Console.WriteLine($"Title --> {movieFromList.Title}. Rating --> {movieFromList.Rating}. Year --> {movieFromList.Year}"); 
            }

        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach(string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\lembe\samples\movies.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
        
}
