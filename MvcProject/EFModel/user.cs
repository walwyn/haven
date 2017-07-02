namespace MvcProject.EFModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("test.user")]
    public partial class user
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Password { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
