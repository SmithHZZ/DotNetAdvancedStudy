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
    
    public partial class Base_Contact_Details
    {
        public string Id { get; set; }
        public string Contact_Id { get; set; }
        public string Category { get; set; }
        public string Receiver_Id { get; set; }
        public string Receiver_Real_Name { get; set; }
        public int Is_New { get; set; }
        public int New_Comment { get; set; }
        public int Enabled { get; set; }
        public Nullable<int> Replied { get; set; }
        public string Last_View_IP { get; set; }
        public string Last_View_Date { get; set; }
        public int Deletion_State_Code { get; set; }
        public Nullable<int> Sort_Code { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Create_On { get; set; }
        public string Create_User_Id { get; set; }
        public string Create_By { get; set; }
        public Nullable<System.DateTime> Modified_On { get; set; }
        public string Modified_User_Id { get; set; }
        public string Modified_By { get; set; }
    }
}
