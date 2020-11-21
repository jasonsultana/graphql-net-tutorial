using System;

namespace GraphQLTutorial.Models
{
    public class Author : IHasId
    {
        public Guid Id { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
    }
}