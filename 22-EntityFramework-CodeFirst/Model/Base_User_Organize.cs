namespace _22_EntityFramework_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_User_Organize
    {
        [StringLength(40)]
        public string Id { get; set; }

        [StringLength(40)]
        public string User_Id { get; set; }

        [StringLength(50)]
        public string Company_Id { get; set; }

        [StringLength(50)]
        public string Sub_Company_Id { get; set; }

        [StringLength(50)]
        public string Department_Id { get; set; }

        [StringLength(50)]
        public string Sub_Department_Id { get; set; }

        [StringLength(50)]
        public string Workgroup_Id { get; set; }

        public int Enabled { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public int? Deletion_State_Code { get; set; }

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
    }
}
