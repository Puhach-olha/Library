namespace Library
{
    public class ScienceMagazine: Item
    {
        
        public ScienceMagazine(string title, string author, int yearOfPublishing, int countOfExemplars) 
            : base(title, author, yearOfPublishing, countOfExemplars)
        {
            
        }

        public override int TermsOfIssuance()
        {
            return 3;
        }

        public override double CalculateFine(int lateDays)
        {
            if (lateDays < 7)
            {
                return lateDays * 50;
            }
            else
            {
                return (lateDays - 7) * 100 + 7 * 50;
            }
        }
    }
}