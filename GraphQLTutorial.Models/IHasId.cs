using System;

namespace GraphQLTutorial.Models
{
    public interface IHasId
    {
        Guid Id { get; }
    }
}