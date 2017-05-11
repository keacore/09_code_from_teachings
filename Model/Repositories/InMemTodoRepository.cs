using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoWebApi.Model.Entities;

namespace TodoWebApi.Model.Repositories
{
    public class InMemTodoRepository : ITodoRepository
    {
        List<TodoItem> todoList;
        public InMemTodoRepository()
        {
            todoList = new List<TodoItem>();
            todoList.Add(new TodoItem{TodoItemID = 1, Task = "First task", IsComplete = false});
            todoList.Add(new TodoItem{TodoItemID = 2, Task = "First task 3", IsComplete = false});
            todoList.Add(new TodoItem{TodoItemID = 3, Task = "First task 4", IsComplete = true});

        }

        public void Create(TodoItem item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public TodoItem Get(int id)
        {
            return todoList.Find(item => item.TodoItemID == id);
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return todoList;
        }

        public void Update(TodoItem item)
        {
            throw new NotImplementedException();
        }
    }
}
