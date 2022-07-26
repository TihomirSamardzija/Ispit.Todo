﻿using Ispit.Todo.Models.Dbo.Base;
using System.ComponentModel.DataAnnotations;

namespace Ispit.Todo.Models.Dbo
{
    public class TodoList:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string ListName { get; set; }
        public DateTime Created { get; set; }
        public AspNetUser AspNetUser { get; set; }
        public ICollection<TodoTask> Tasks { get; set; }
    }
}
