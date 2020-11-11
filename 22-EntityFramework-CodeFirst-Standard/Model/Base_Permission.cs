namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Permission
    {
        [StringLength(40)]
        public string Id { get; set; }

        [StringLength(50)]
        public string Resource_Category { get; set; }

        [StringLength(40)]
        public string Resource_Id { get; set; }

        [StringLength(40)]
        public string Permission_Id { get; set; }

        [StringLength(200)]
        public string Permission_Constraint { get; set; }

        public short? Enabled { get; set; }

        public short Deletion_State_Code { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public DateTime? Create_On { get; set; }

        [StringLength(40)]
        public string Create_User_Id { get; set; }

        [StringLength(20)]
        public string Create_By { get; set; }

        public DateTime? Modified_On { get; set; }

        [StringLength(40)]
        public string Modified_User_Id { get; set; }

        [StringLength(20)]
        public string Modified_By { get; set; }

        [StringLength(40)]
        public string Company_Id { get; set; }

        [StringLength(50)]
        public string Company_Name { get; set; }
    }
}
