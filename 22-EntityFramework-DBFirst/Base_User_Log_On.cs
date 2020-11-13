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
    
    public partial class Base_User_Log_On
    {
        public string Id { get; set; }
        public string User_From { get; set; }
        public string User_Password { get; set; }
        public string Open_Id { get; set; }
        public Nullable<System.DateTime> Allow_Start_Time { get; set; }
        public Nullable<System.DateTime> Allow_End_Time { get; set; }
        public Nullable<System.DateTime> Lock_Start_Date { get; set; }
        public Nullable<System.DateTime> Lock_End_Date { get; set; }
        public Nullable<System.DateTime> First_Visit { get; set; }
        public Nullable<System.DateTime> Previous_Visit { get; set; }
        public Nullable<System.DateTime> Last_Visit { get; set; }
        public Nullable<int> Log_On_Count { get; set; }
        public int Password_Error_Count { get; set; }
        public Nullable<System.DateTime> Change_Password_Date { get; set; }
        public Nullable<short> Is_Staff { get; set; }
        public Nullable<short> User_On_Line { get; set; }
        public Nullable<short> Multi_User_Login { get; set; }
        public Nullable<int> Show_Count { get; set; }
        public Nullable<short> Is_Visible { get; set; }
        public Nullable<short> Check_IPAddress { get; set; }
        public string Verification_Code { get; set; }
        public string IPAddress { get; set; }
        public string MAC_Address { get; set; }
        public string Question { get; set; }
        public string Answer_Question { get; set; }
        public Nullable<short> Enabled { get; set; }
        public Nullable<short> Deletion_State_Code { get; set; }
        public Nullable<int> Sort_Code { get; set; }
        public string Description { get; set; }
        public string Salt { get; set; }
        public Nullable<System.DateTime> Open_Id_Timeout { get; set; }
        public string System_Code { get; set; }
        public string IPAddress_Name { get; set; }
        public Nullable<short> Password_Strength { get; set; }
        public string Computer_Name { get; set; }
        public Nullable<short> Need_Modify_Password { get; set; }
        public string Company_Id { get; set; }
        public string Company { get; set; }
        public Nullable<System.DateTime> Create_On { get; set; }
        public string Create_User_Id { get; set; }
        public string Create_By { get; set; }
        public Nullable<System.DateTime> Modified_On { get; set; }
        public string Modified_User_Id { get; set; }
        public string Modified_By { get; set; }
        public Nullable<short> Check_Mac_Address { get; set; }
    }
}