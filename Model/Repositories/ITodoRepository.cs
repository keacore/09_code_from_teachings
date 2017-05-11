using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoWebApi.Model.Entities;

namespace TodoWebApi.Model.Repositories
{
    public interface ITodoRepository
    {
        // CRUD Funtionality
        void Create(TodoItem item);
        TodoItem Get(int id);
        IEnumerable<TodoItem> GetAll();
        void Update(TodoItem item);
        void Delete(int id);

    }
}
