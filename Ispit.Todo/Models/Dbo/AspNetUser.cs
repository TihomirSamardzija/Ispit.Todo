using Ispit.Todo.Models.Dbo.Interface;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Ispit.Todo.Models.Dbo
{
    public class AspNetUser : IdentityUser, IAspNetUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<TodoList> TodoLists {get; set; }

    }
}
