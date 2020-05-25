using System;
using System.ComponentModel.DataAnnotations;

namespace Sample_EF_RelationsApp
{
    public class Person
    {
        [Key]
        [Required]
        public Guid PersonGuid { get; set; }
        public string Firstname{ get; set; }
        public string Lastname { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender PersonGender { get; set; }
    }
    public enum Gender
    {
        Male,
        Female,
        Both,
        Unknown
    }
}
