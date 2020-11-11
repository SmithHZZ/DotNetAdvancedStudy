namespace _22_EntityFramework_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Sequence
    {
        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Full_Name { get; set; }

        [StringLength(50)]
        public string Prefix { get; set; }

        [StringLength(50)]
        public string Delimiter { get; set; }

        public int Sequence { get; set; }

        public int Reduction { get; set; }

        public int Step { get; set; }

        public int Is_Visible { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public DateTime? Create_On { get; set; }

        [StringLength(20)]
        public string Create_User_Id { get; set; }

        [StringLength(20)]
        public string Create_By { get; set; }

        public DateTime? Modified_On { get; set; }

        [StringLength(20)]
        public string Modified_User_Id { get; set; }

        [StringLength(20)]
        public string Modified_By { get; set; }
    }
}
