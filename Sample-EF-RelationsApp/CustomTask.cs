using System;
using System.ComponentModel.DataAnnotations;

namespace Sample_EF_RelationsApp
{
    public class CustomTask
    {
        [Key]
        [Required]
        public Guid TaskGuid { get; set; }
        public String TaskName { get; set; }
        public TaskType TypeOfTask { get; set; }
    }
    public enum TaskType 
    { 
        Billable,
        NonBillable
    }
}
