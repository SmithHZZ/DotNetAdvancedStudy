namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Comment
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string Parent_Id { get; set; }

        [StringLength(50)]
        public string Department_Id { get; set; }

        [StringLength(50)]
        public string Department_Name { get; set; }

        [StringLength(50)]
        public string Category_Code { get; set; }

        [StringLength(50)]
        public string Object_Id { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public int? Worked { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        [StringLength(400)]
        public string Target_URL { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [Column(TypeName = "ntext")]
        public string Contents { get; set; }

        public int? Deletion_State_Code { get; set; }

        public int Enabled { get; set; }

        public int? Sort_Code { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Create_On { get; set; }

        [StringLength(20)]
        public string Create_User_Id { get; set; }

        [StringLength(20)]
        public string Create_By { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Modified_On { get; set; }

        [StringLength(20)]
        public string Modified_User_Id { get; set; }

        [StringLength(20)]
        public string Modified_By { get; set; }
    }
}
