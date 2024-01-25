namespace Machine_Test.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        public int Emp_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Emp_Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        [StringLength(20)]
        public string Status { get; set; }
    }
}
