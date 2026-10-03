namespace Library
{
    public class Ebook: Item
    {
        public Ebook(string title, string author, int yearOfPublishing) 
            : base(title, author, yearOfPublishing , int.MaxValue)
        {
            
        }

        public override int TermsOfIssuance()
        {
            return 14;
        }

        public override double CalculateFine(int lateDays)
        {
            return 10 * lateDays;
        }
    }
}