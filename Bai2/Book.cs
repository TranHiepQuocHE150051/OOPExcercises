using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class Book : Document
    {
        public string AuthorName { get; set; }
        public int PageNumber { get; set; }
        public Book(int id, string publisher, int releasedNum, string authorName, int pageNumber) : base(id, publisher, releasedNum)
        {
            AuthorName = authorName;
            PageNumber = pageNumber;
        }
        public override string ToString()
        {
            return "Type : Book" + "\n" + "Id: " + this.Id + "\n" + "Publisher name: " + this.Publisher + "\n" + "Released Number: " + this.ReleasedNum + "\n" + "Author name: " + this.AuthorName + "\n" + "Number of page: " + this.PageNumber;

        }
    }
}
