using System.Collections.Generic;

namespace Library
{
    public class Reader
    {
        public int TicketNumb { get; set; }
        public string Name { get; set; }
        public List<BorrowBooks> borrowBooks { get; set; }

        public Reader(int ticketNumb, string name)
        {
            TicketNumb = ticketNumb;
            Name = name;
            borrowBooks = new List<BorrowBooks>();
        }

        public bool HasOverDueBooks() 
            // Даний метод для подальшої перевірки для цього пункта "Видавати будь-яке видання читачеві
            // — але лише якщо у читача немає жодного простроченого повернення"
        {
            foreach (var book in borrowBooks)
            {
                if (book.IfDaysOver())
                {
                    return true;
                }
            }

            return false;
        }
        
        
    }
}