namespace Library
{
    public class BookForKids: Item
    {

        public BookForKids(string title, string author, int yearOfPublishing, int countOfExemplars)
            : base(title, author, yearOfPublishing, countOfExemplars)
        {
            
        }

        public override int TermsOfIssuance()
        {
            return 21;
        }

        public override double CalculateFine(int lateDays)
        {
            return lateDays * 10;
        }
    }
}