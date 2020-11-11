namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Organize_Scope
    {
        [StringLength(40)]
        public string Id { get; set; }

        [StringLength(50)]
        public string Resource_Category { get; set; }

        [StringLength(40)]
        public string Resource_Id { get; set; }

        [StringLength(40)]
        public string Permission_Id { get; set; }

        public short? All_Data { get; set; }

        public short? Province { get; set; }

        public short? City { get; set; }

        public short? District { get; set; }

        public short? Street { get; set; }

        public short? User_Company { get; set; }

        public short? User_Sub_Company { get; set; }

        public short? User_Department { get; set; }

        public short? User_Sub_Department { get; set; }

        public short? User_Workgroup { get; set; }

        public short Only_Own_Data { get; set; }

        public short? Not_Allowed { get; set; }

        public short? By_Details { get; set; }

        public short Contain_Child { get; set; }

        public short Enabled { get; set; }

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
    }
}
