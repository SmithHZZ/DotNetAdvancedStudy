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
    
    public partial class Base_Organize_Scope
    {
        public string Id { get; set; }
        public string Resource_Category { get; set; }
        public string Resource_Id { get; set; }
        public string Permission_Id { get; set; }
        public Nullable<short> All_Data { get; set; }
        public Nullable<short> Province { get; set; }
        public Nullable<short> City { get; set; }
        public Nullable<short> District { get; set; }
        public Nullable<short> Street { get; set; }
        public Nullable<short> User_Company { get; set; }
        public Nullable<short> User_Sub_Company { get; set; }
        public Nullable<short> User_Department { get; set; }
        public Nullable<short> User_Sub_Department { get; set; }
        public Nullable<short> User_Workgroup { get; set; }
        public short Only_Own_Data { get; set; }
        public Nullable<short> Not_Allowed { get; set; }
        public Nullable<short> By_Details { get; set; }
        public short Contain_Child { get; set; }
        public short Enabled { get; set; }
        public short Deletion_State_Code { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Create_On { get; set; }
        public string Create_User_Id { get; set; }
        public string Create_By { get; set; }
        public Nullable<System.DateTime> Modified_On { get; set; }
        public string Modified_User_Id { get; set; }
        public string Modified_By { get; set; }
    }
}