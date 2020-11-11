namespace _22_EntityFramework_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_System
    {
        [StringLength(40)]
        public string Id { get; set; }

        [StringLength(40)]
        public string Parent_Id { get; set; }

        [StringLength(40)]
        public string Item_Code { get; set; }

        [StringLength(100)]
        public string Item_Name { get; set; }

        [StringLength(100)]
        public string Item_Value { get; set; }

        public int? Use_Permission { get; set; }

        public int? Use_Organize_Permission { get; set; }

        public int? Use_Role { get; set; }

        [StringLength(400)]
        public string Logon_Url { get; set; }

        [StringLength(200)]
        public string Test_Logon_Url { get; set; }

        [StringLength(200)]
        public string Prepare_Logon_Url { get; set; }

        public short Allow_Edit { get; set; }

        public short Allow_Delete { get; set; }

        public short Is_Public { get; set; }

        public short Enabled { get; set; }

        public short Deletion_State_Code { get; set; }

        public int? Sort_Code { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public DateTime Create_On { get; set; }

        [StringLength(40)]
        public string Create_User_Id { get; set; }

        [StringLength(20)]
        public string Create_By { get; set; }

        public DateTime Modified_On { get; set; }

        [StringLength(40)]
        public string Modified_User_Id { get; set; }

        [StringLength(20)]
        public string Modified_By { get; set; }
    }
}
