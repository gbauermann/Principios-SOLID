using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    public class DVD : IBorrowbleDVD
    {
        public int RunTimeInMinutes { get; set; }
        public List<string> Actors { get; set; }
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public DateTime BorrowDate { get; set; }
        public string Borrower { get; set; }
        public int CheckOutDurationInDays { get; set; }

        public void CheckIn()
        {
            Borrower = string.Empty;
        }

        public void CheckOut(string borrower)
        {            
            Borrower = borrower;
            BorrowDate = DateTime.Now;
        }

        public DateTime GetDueDate()
        {
            return BorrowDate.AddDays(CheckOutDurationInDays);
        }
    }
}
