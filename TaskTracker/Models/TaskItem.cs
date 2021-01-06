using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTracker.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public string Executor { get; set; }
        public string Progress { get; set; } = "not_completed";
        public string TaskDate { get; set; }
    }
}
