using System;

namespace CommunityProApp.Entities
{
    public class BookLending : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public bool BookReturned { get; set; }
    }
}
