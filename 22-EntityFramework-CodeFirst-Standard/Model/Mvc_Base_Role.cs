namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mvc_Base_Role
    {
        [StringLength(40)]
        public string Id { get; set; }

        [StringLength(40)]
        public string Company_Id { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(200)]
        public string Real_Name { get; set; }

        [StringLength(50)]
        public string Category_Code { get; set; }

        public short Allow_Edit { get; set; }

        public short Allow_Delete { get; set; }

        public short Is_Visible { get; set; }

        public int? Sort_Code { get; set; }

        public short Deletion_State_Code { get; set; }

        public short Enabled { get; set; }

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

        [StringLength(50)]
        public string Company_Name { get; set; }

        [StringLength(50)]
        public string System_Code { get; set; }

        public int? Security_Level { get; set; }
    }
}
