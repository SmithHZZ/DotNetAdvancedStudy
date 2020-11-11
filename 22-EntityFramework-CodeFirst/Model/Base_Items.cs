namespace _22_EntityFramework_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Items
    {
        [StringLength(40)]
        public string Id { get; set; }

        [StringLength(40)]
        public string Parent_Id { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(100)]
        public string Full_Name { get; set; }

        [StringLength(50)]
        public string Target_Table { get; set; }

        public short Is_Tree { get; set; }

        public short? Use_Item_Code { get; set; }

        public short? Use_Item_Name { get; set; }

        public short? Use_Item_Value { get; set; }

        public short Allow_Edit { get; set; }

        public short Allow_Delete { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public short Deletion_State_Code { get; set; }

        public short Enabled { get; set; }

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
