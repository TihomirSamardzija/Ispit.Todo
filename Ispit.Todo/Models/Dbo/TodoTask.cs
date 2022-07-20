using Ispit.Todo.Models.Dbo.Base;
using System.ComponentModel.DataAnnotations;

namespace Ispit.Todo.Models.Dbo
{
    public class TodoTask: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public bool Status { get; set; }
        public ICollection<TodoList> TodoList { get; set; }
    }
}
