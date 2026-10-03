using System;

namespace Library
{
    public class Book: Item

    {
        public Book(string title, string author, int yearOfPublishing, int countOfExemplars) 
            : base(title, author, yearOfPublishing, countOfExemplars)
        {
            
        }

        public override int TermsOfIssuance()
        {
            return 14;
        }
        
        public override double CalculateFine(int lateDays)
        {
            int first = Math.Min(lateDays, 7);
            int rest = Math.Max(lateDays - 7, 0);
            return first * 50 + rest * 100;
        }
    }
}