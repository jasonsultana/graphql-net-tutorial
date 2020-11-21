using System;
using GraphQLTutorial.Models;
using System.Linq;
using System.Collections.Generic;

namespace GraphQLTutorial.Data
{
    public abstract class GenericRepository<T>
        where T : IHasId
    {
        private readonly List<T> _models = new List<T>();
        
        public T GetById(Guid id) => _models.SingleOrDefault(b => b.Id == id);
        
        public List<T> GetAll() => _models;
        
        public void AddOrUpdate(T item)
        {
            var existingItem = _models.Where(b => b.Id == item.Id).SingleOrDefault();
            if (existingItem != null)
            {
                existingItem = item;
            }
            else 
            {
                _models.Add(item);
            }
        }     
    }
}