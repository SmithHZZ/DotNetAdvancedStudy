namespace _22_EntityFramework_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_User_Score
    {
        [StringLength(40)]
        public string Id { get; set; }

        [StringLength(40)]
        public string User_Id { get; set; }

        [StringLength(20)]
        public string User_Name { get; set; }

        public int? Score { get; set; }

        [StringLength(20)]
        public string Function_Code { get; set; }

        [StringLength(40)]
        public string Object_Id { get; set; }

        [StringLength(200)]
        public string Contents { get; set; }

        public int Deletion_State_Code { get; set; }

        public int Enabled { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Create_On { get; set; }

        [StringLength(40)]
        public string Create_User_Id { get; set; }

        [StringLength(20)]
        public string Create_By { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Modified_On { get; set; }

        [StringLength(40)]
        public string Modified_User_Id { get; set; }

        [StringLength(20)]
        public string Modified_By { get; set; }
    }
}
