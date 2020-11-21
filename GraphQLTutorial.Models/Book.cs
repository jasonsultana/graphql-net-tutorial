using System;

namespace GraphQLTutorial.Models
{
    public class Book : IHasId
    {
        public Guid Id { get; set; }
        
        public string Title { get; set; }
        
        public int NumPages { get; set; }
        
        public DateTime PublicationDate { get; set; }
        
        public string Publisher { get; set; }
    }
}
