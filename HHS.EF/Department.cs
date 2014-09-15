namespace HHS.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Department")]
    public partial class Department
    {
        public Department()
        {
            Course = new HashSet<Course>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepartmentID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "money")]
        public decimal Budget { get; set; }

        public DateTime StartDate { get; set; }

        public int? Administrator { get; set; }

        public virtual ICollection<Course> Course { get; set; }
    }
}
