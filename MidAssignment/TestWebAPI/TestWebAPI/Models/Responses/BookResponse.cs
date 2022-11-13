using Test.Data.Entities;

namespace TestWebAPI.Models.Responses
{
    public class BookResponse
    {
        public int BookId { get; set; }

        public string BookTitle { get; set; }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public bool IsDeleted { get; set; }

    }
}
