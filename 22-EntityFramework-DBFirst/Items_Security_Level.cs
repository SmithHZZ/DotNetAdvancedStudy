//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace _22_EntityFramework_DBFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Items_Security_Level
    {
        public string Id { get; set; }
        public string Parent_Id { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public string Item_Value { get; set; }
        public short Enabled { get; set; }
        public short Allow_Edit { get; set; }
        public short Allow_Delete { get; set; }
        public short Is_Public { get; set; }
        public short Deletion_State_Code { get; set; }
        public Nullable<int> Sort_Code { get; set; }
        public string Description { get; set; }
        public System.DateTime Create_On { get; set; }
        public string Create_User_Id { get; set; }
        public string Create_By { get; set; }
        public System.DateTime Modified_On { get; set; }
        public string Modified_User_Id { get; set; }
        public string Modified_By { get; set; }
    }
}
