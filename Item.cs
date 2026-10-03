using System;

namespace Library
{
    public abstract class Item
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearOfPublishing { get; set; }
        public int CountOfExemplars { get; set; }
        
        protected Item(string title, string author, int yearOfPublishing, int countOfExemplars)
        {
            Title = title;
            Author = author;
            YearOfPublishing = yearOfPublishing;
            CountOfExemplars = countOfExemplars;
        }

        public abstract int TermsOfIssuance(); // термін на який ти можеш взяти якесь видання
        public abstract double CalculateFine(int lateDays); // цей метод рахує штрафи
        

    }
}