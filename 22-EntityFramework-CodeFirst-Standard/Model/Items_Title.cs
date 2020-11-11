namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Items_Title
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

        public int Enabled { get; set; }

        public int Allow_Edit { get; set; }

        public int Allow_Delete { get; set; }

        public int Is_Public { get; set; }

        public int Deletion_State_Code { get; set; }

        public int? Sort_Code { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public DateTime? Create_On { get; set; }

        [StringLength(40)]
        public string Create_User_Id { get; set; }

        [StringLength(50)]
        public string Create_By { get; set; }

        public DateTime? Modified_On { get; set; }

        [StringLength(40)]
        public string Modified_User_Id { get; set; }

        [StringLength(50)]
        public string Modified_By { get; set; }
    }
}
