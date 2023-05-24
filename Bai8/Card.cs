using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    public class Card
    {
        public int CardId { get; set; }
        public int BorrowDate { get; set; }
        public int ReturnDate { get; set; }
        public int BookNo { get; set; }
        public Student student { get; set; }

        public Card(int cardId, int borrowDate, int returnDate, int bookNo, Student student)
        {
            CardId = cardId;
            BorrowDate = borrowDate;
            ReturnDate = returnDate;
            BookNo = bookNo;
            this.student = student;
        }
        public override string ToString()
        {
            return "CardInfo :" + "\n" + "Card Id: " + this.CardId + "\n" + " Borrow Date: " + this.BorrowDate + "\n" + "Return Date: " + this.ReturnDate + "\n" + "Book No: " + this.BookNo + "\n" + "Student Name : " + this.student.Name + "\n" + "Student Age : " + this.student.Age + "\n" + "Student Grade : " + this.student.Grade;

        }
    }
}
