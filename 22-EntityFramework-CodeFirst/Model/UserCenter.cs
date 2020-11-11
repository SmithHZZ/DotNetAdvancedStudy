namespace _22_EntityFramework_CodeFirst
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class UserCenter : DbContext
    {
        public UserCenter()
            : base("name=UserCenter")
        {
        }

        public virtual DbSet<Base_Area> Base_Area { get; set; }
        public virtual DbSet<Base_Comment> Base_Comment { get; set; }
        public virtual DbSet<Base_Contact> Base_Contact { get; set; }
        public virtual DbSet<Base_Contact_Details> Base_Contact_Details { get; set; }
        public virtual DbSet<Base_Department> Base_Department { get; set; }
        public virtual DbSet<Base_Exception> Base_Exception { get; set; }
        public virtual DbSet<Base_File> Base_File { get; set; }
        public virtual DbSet<Base_Folder> Base_Folder { get; set; }
        public virtual DbSet<Base_Holidays> Base_Holidays { get; set; }
        public virtual DbSet<Base_Item_Details> Base_Item_Details { get; set; }
        public virtual DbSet<Base_Items> Base_Items { get; set; }
        public virtual DbSet<Base_Knowledge> Base_Knowledge { get; set; }
        public virtual DbSet<Base_Log> Base_Log { get; set; }
        public virtual DbSet<Base_Login_Log> Base_Login_Log { get; set; }
        public virtual DbSet<Base_Message> Base_Message { get; set; }
        public virtual DbSet<BASE_MESSAGE_RECENT> BASE_MESSAGE_RECENT { get; set; }
        public virtual DbSet<Base_Modify_Record> Base_Modify_Record { get; set; }
        public virtual DbSet<Base_News> Base_News { get; set; }
        public virtual DbSet<Base_Notice> Base_Notice { get; set; }
        public virtual DbSet<Base_Organize> Base_Organize { get; set; }
        public virtual DbSet<Base_Organize_Scope> Base_Organize_Scope { get; set; }
        public virtual DbSet<Base_Parameter> Base_Parameter { get; set; }
        public virtual DbSet<Base_Permission> Base_Permission { get; set; }
        public virtual DbSet<Base_Permission_Scope> Base_Permission_Scope { get; set; }
        public virtual DbSet<Base_Role> Base_Role { get; set; }
        public virtual DbSet<Base_Role_Organize> Base_Role_Organize { get; set; }
        public virtual DbSet<Base_Sequence> Base_Sequence { get; set; }
        public virtual DbSet<Base_Staff> Base_Staff { get; set; }
        public virtual DbSet<Base_Staff_Organize> Base_Staff_Organize { get; set; }
        public virtual DbSet<Base_System> Base_System { get; set; }
        public virtual DbSet<Base_Table_Columns> Base_Table_Columns { get; set; }
        public virtual DbSet<Base_User> Base_User { get; set; }
        public virtual DbSet<Base_User_Address> Base_User_Address { get; set; }
        public virtual DbSet<Base_User_Contact> Base_User_Contact { get; set; }
        public virtual DbSet<Base_User_Express> Base_User_Express { get; set; }
        public virtual DbSet<Base_User_Log_On> Base_User_Log_On { get; set; }
        public virtual DbSet<Base_User_Organize> Base_User_Organize { get; set; }
        public virtual DbSet<Base_User_Role> Base_User_Role { get; set; }
        public virtual DbSet<Base_User_Score> Base_User_Score { get; set; }
        public virtual DbSet<Business_Card> Business_Card { get; set; }
        public virtual DbSet<Colp_Appointment_Detail> Colp_Appointment_Detail { get; set; }
        public virtual DbSet<Colp_Audit_Diagnose_Detail> Colp_Audit_Diagnose_Detail { get; set; }
        public virtual DbSet<Colp_Biopsy_Detail> Colp_Biopsy_Detail { get; set; }
        public virtual DbSet<Colp_Biopsy_Report_Detail> Colp_Biopsy_Report_Detail { get; set; }
        public virtual DbSet<Colp_Check_List> Colp_Check_List { get; set; }
        public virtual DbSet<Colp_Check_Report_Detail> Colp_Check_Report_Detail { get; set; }
        public virtual DbSet<Colp_Configuration_List> Colp_Configuration_List { get; set; }
        public virtual DbSet<Colp_Data_Sync_Detail> Colp_Data_Sync_Detail { get; set; }
        public virtual DbSet<Colp_Diagnose_Detail> Colp_Diagnose_Detail { get; set; }
        public virtual DbSet<Colp_Diagnose_Report_Detail> Colp_Diagnose_Report_Detail { get; set; }
        public virtual DbSet<Colp_Equipment_List> Colp_Equipment_List { get; set; }
        public virtual DbSet<Colp_Evaluate_AI> Colp_Evaluate_AI { get; set; }
        public virtual DbSet<Colp_Evaluate_RCI_Detail> Colp_Evaluate_RCI_Detail { get; set; }
        public virtual DbSet<Colp_File_Detail> Colp_File_Detail { get; set; }
        public virtual DbSet<Colp_Flup_Detail> Colp_Flup_Detail { get; set; }
        public virtual DbSet<Colp_Instruments_List> Colp_Instruments_List { get; set; }
        public virtual DbSet<Colp_Operation_Detail> Colp_Operation_Detail { get; set; }
        public virtual DbSet<Colp_Operation_Report_Detail> Colp_Operation_Report_Detail { get; set; }
        public virtual DbSet<Colp_Pathology_Detail> Colp_Pathology_Detail { get; set; }
        public virtual DbSet<Colp_Patient_List> Colp_Patient_List { get; set; }
        public virtual DbSet<Colp_Picture_Annotate_Detail> Colp_Picture_Annotate_Detail { get; set; }
        public virtual DbSet<Colp_QueueManage_List> Colp_QueueManage_List { get; set; }
        public virtual DbSet<Colp_Report_List> Colp_Report_List { get; set; }
        public virtual DbSet<Colp_Report_Tempelate_Detail> Colp_Report_Tempelate_Detail { get; set; }
        public virtual DbSet<Colp_Report_Tempelate_List> Colp_Report_Tempelate_List { get; set; }
        public virtual DbSet<Colp_Statistical_List> Colp_Statistical_List { get; set; }
        public virtual DbSet<Colp_Term_Detailrrrr> Colp_Term_Detailrrrr { get; set; }
        public virtual DbSet<Colp_Typicalcase_Detail> Colp_Typicalcase_Detail { get; set; }
        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<Items_Area> Items_Area { get; set; }
        public virtual DbSet<Items_Audit_Status> Items_Audit_Status { get; set; }
        public virtual DbSet<Items_Big_Area> Items_Big_Area { get; set; }
        public virtual DbSet<Items_Bug_Category> Items_Bug_Category { get; set; }
        public virtual DbSet<Items_Bug_Level> Items_Bug_Level { get; set; }
        public virtual DbSet<Items_Condition> Items_Condition { get; set; }
        public virtual DbSet<Items_Duty> Items_Duty { get; set; }
        public virtual DbSet<Items_EditFields> Items_EditFields { get; set; }
        public virtual DbSet<Items_Education> Items_Education { get; set; }
        public virtual DbSet<Items_Gender> Items_Gender { get; set; }
        public virtual DbSet<Items_Marriage> Items_Marriage { get; set; }
        public virtual DbSet<Items_Nationality> Items_Nationality { get; set; }
        public virtual DbSet<Items_News_Category> Items_News_Category { get; set; }
        public virtual DbSet<Items_Organize_Category> Items_Organize_Category { get; set; }
        public virtual DbSet<Items_Organize_Joining_Methods> Items_Organize_Joining_Methods { get; set; }
        public virtual DbSet<Items_Party> Items_Party { get; set; }
        public virtual DbSet<Items_Priority> Items_Priority { get; set; }
        public virtual DbSet<Items_Role_Category> Items_Role_Category { get; set; }
        public virtual DbSet<Items_Security_Level> Items_Security_Level { get; set; }
        public virtual DbSet<Items_System> Items_System { get; set; }
        public virtual DbSet<Items_Table_Permission_Scope> Items_Table_Permission_Scope { get; set; }
        public virtual DbSet<Items_Title> Items_Title { get; set; }
        public virtual DbSet<Items_True_False> Items_True_False { get; set; }
        public virtual DbSet<Items_Units> Items_Units { get; set; }
        public virtual DbSet<Items_Work_Status> Items_Work_Status { get; set; }
        public virtual DbSet<Items_Working_Property> Items_Working_Property { get; set; }
        public virtual DbSet<Items_Yes_No> Items_Yes_No { get; set; }
        public virtual DbSet<Mvc_Base_Items> Mvc_Base_Items { get; set; }
        public virtual DbSet<Mvc_Base_Module> Mvc_Base_Module { get; set; }
        public virtual DbSet<Mvc_Base_Organize_Scope> Mvc_Base_Organize_Scope { get; set; }
        public virtual DbSet<Mvc_Base_Permission> Mvc_Base_Permission { get; set; }
        public virtual DbSet<Mvc_Base_Permission_Scope> Mvc_Base_Permission_Scope { get; set; }
        public virtual DbSet<Mvc_Base_Role> Mvc_Base_Role { get; set; }
        public virtual DbSet<Mvc_Base_Role_Organize> Mvc_Base_Role_Organize { get; set; }
        public virtual DbSet<Mvc_Base_User_Role> Mvc_Base_User_Role { get; set; }
        public virtual DbSet<Option_Items_Computer_Category> Option_Items_Computer_Category { get; set; }
        public virtual DbSet<Option_Items_Disability> Option_Items_Disability { get; set; }
        public virtual DbSet<Option_Items_Express> Option_Items_Express { get; set; }
        public virtual DbSet<Option_Items_House_hold> Option_Items_House_hold { get; set; }
        public virtual DbSet<Option_Items_Post_Category> Option_Items_Post_Category { get; set; }
        public virtual DbSet<Option_Items_Salary_Item_Category> Option_Items_Salary_Item_Category { get; set; }
        public virtual DbSet<Option_Items_Send_Category> Option_Items_Send_Category { get; set; }
        public virtual DbSet<PDA_USER_LOG_ON> PDA_USER_LOG_ON { get; set; }
        public virtual DbSet<System_Parameter> System_Parameter { get; set; }
        public virtual DbSet<Base_Module> Base_Module { get; set; }
        public virtual DbSet<BASE_ORGANIZE_HORIZONTAL> BASE_ORGANIZE_HORIZONTAL { get; set; }
        public virtual DbSet<Base_Organize_Log> Base_Organize_Log { get; set; }
        public virtual DbSet<Base_User_Log> Base_User_Log { get; set; }
        public virtual DbSet<Colp_Term_Detail> Colp_Term_Detail { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Base_Comment>().ToTable("Base_Comment");
            //modelBuilder.Entity<Base_Comment>().Property(e => e.Description).HasColumnName("Description");

            modelBuilder.Entity<Base_Comment>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Contact>()
                .Property(e => e.Customer_Sex)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Contact>()
                .Property(e => e.Customer_Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Contact>()
                .Property(e => e.Customer_Email)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Contact>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Contact>()
                .Property(e => e.Category_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Contact>()
                .Property(e => e.Label_Mark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Contact>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Contact>()
                .Property(e => e.Create_Department_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Contact>()
                .Property(e => e.Create_Department)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Contact>()
                .Property(e => e.Create_Company)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Contact>()
                .Property(e => e.Create_Company_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.PARENT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.PARENT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.PARENT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.COMPANY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.COMPANY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.COMPANY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.MANAGER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.MANAGER)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.MANAGER_MOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.MANAGER_QQ)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.SHORT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.FULL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.CATEGORY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.CATEGORY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.OUTER_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.INNER_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.CREATE_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Exception>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Exception>()
                .Property(e => e.SYSTEM_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Exception>()
                .Property(e => e.CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Exception>()
                .Property(e => e.SEVERITY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Exception>()
                .Property(e => e.IPADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Exception>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Exception>()
                .Property(e => e.MACHINE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Exception>()
                .Property(e => e.APPDOMAIN_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Exception>()
                .Property(e => e.PROCESS_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Exception>()
                .Property(e => e.PROCESS_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Exception>()
                .Property(e => e.THREAD_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Exception>()
                .Property(e => e.WIN32_THREAD_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Exception>()
                .Property(e => e.MESSAGE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Exception>()
                .Property(e => e.FORMATTED_MESSAGE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Exception>()
                .Property(e => e.CREATE_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Exception>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_File>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_File>()
                .Property(e => e.FOLDER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_File>()
                .Property(e => e.FILE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_File>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_File>()
                .Property(e => e.FILE_PATH)
                .IsUnicode(false);

            modelBuilder.Entity<Base_File>()
                .Property(e => e.CATEGORY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_File>()
                .Property(e => e.INTRODUCTION)
                .IsUnicode(false);

            modelBuilder.Entity<Base_File>()
                .Property(e => e.IMAGE_URL)
                .IsUnicode(false);

            modelBuilder.Entity<Base_File>()
                .Property(e => e.KEY_WORDS)
                .IsUnicode(false);

            modelBuilder.Entity<Base_File>()
                .Property(e => e.SOURCE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_File>()
                .Property(e => e.CONTENTS)
                .IsFixedLength();

            modelBuilder.Entity<Base_File>()
                .Property(e => e.AUDIT_STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<Base_File>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<Base_File>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_File>()
                .Property(e => e.CREATE_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_File>()
                .Property(e => e.MODIFIE_DBY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_File>()
                .Property(e => e.MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Folder>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Folder>()
                .Property(e => e.PARENT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Folder>()
                .Property(e => e.FOLDER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Folder>()
                .Property(e => e.STATE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Folder>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Folder>()
                .Property(e => e.CREATE_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Folder>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Folder>()
                .Property(e => e.MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Folder>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Holidays>()
                .Property(e => e.Holiday)
                .IsFixedLength();

            modelBuilder.Entity<Base_Knowledge>()
                .Property(e => e.Priority_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Knowledge>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.TASK_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.SERVICE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.USER_REAL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.PARAMETERS)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.URL_REFERRER)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.CLIENT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.SERVER_IP)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.COMPANY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.IPADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.WEB_URL)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.COMPANY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.CREATE_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Message>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Message>()
                .Property(e => e.PARENT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Message>()
                .Property(e => e.RECEIVER_DEPARTMENT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Message>()
                .Property(e => e.RECEIVER_DEPARTMENT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Message>()
                .Property(e => e.RECEIVER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Message>()
                .Property(e => e.RECEIVER_REAL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Message>()
                .Property(e => e.CATEGORY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Message>()
                .Property(e => e.FUNCTION_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Message>()
                .Property(e => e.OBJECT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Message>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Message>()
                .Property(e => e.CONTENTS)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Message>()
                .Property(e => e.TARGET_URL)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Message>()
                .Property(e => e.IPADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Message>()
                .Property(e => e.QQ)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Message>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Message>()
                .Property(e => e.TELEPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Message>()
                .Property(e => e.CREATE_DEPARTMENT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Message>()
                .Property(e => e.CREATE_DEPARTMENT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Message>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Message>()
                .Property(e => e.CREATE_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Message>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Message>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Message>()
                .Property(e => e.MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Message>()
                .Property(e => e.CREATE_COMPANY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Message>()
                .Property(e => e.CREATE_COMPANY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_MESSAGE_RECENT>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_MESSAGE_RECENT>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_MESSAGE_RECENT>()
                .Property(e => e.TARGET_CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_MESSAGE_RECENT>()
                .Property(e => e.TARGET_ID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_MESSAGE_RECENT>()
                .Property(e => e.REAL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_MESSAGE_RECENT>()
                .Property(e => e.COMPANY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_MESSAGE_RECENT>()
                .Property(e => e.DEPARTMENT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.FOLDER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.COMPANY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.COMPANY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.DEPARTMENT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.DEPARTMENT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.CATEGORY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.FILE_PATH)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.INTRODUCTION)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.CONTENTS)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.SOURCE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.KEYWORDS)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.IMAGE_URL)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.AUDIT_STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.CREATE_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Notice>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Notice>()
                .Property(e => e.CATEGORY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Notice>()
                .Property(e => e.PARAMETER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Notice>()
                .Property(e => e.PARAMETER_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Notice>()
                .Property(e => e.PARAMETER_CONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Notice>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Notice>()
                .Property(e => e.CREATE_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Notice>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Notice>()
                .Property(e => e.MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Notice>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.USER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.REAL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.GENDER)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.COMPANY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.SUB_COMPANY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.DEPARTMENT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.WORKGROUP_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.QUICK_QUERY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.DUTY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.DUTY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.DUTY_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.DUTY_LEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.DUTY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.IDENTIFICATION_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.ID_CARD)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.BANK_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.REWAR_CARD)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.MEDICAL_CARD)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.UNION_MEMBER)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.MOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.SHORT_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.TELEPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.QQ)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.OFFICE_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.OFFICE_POSTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.OFFICE_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.OFFICE_FAX)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.AGE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.BIRTHDAY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.HEIGHT)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.WEIGHT)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.EDUCATION)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.SCHOOL)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.GRADUATION_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.MAJOR)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.DEGREE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.TITLE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.TITLE_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.TITLE_LEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.WORKING_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.JOIN_IN_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.HOME_POST_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.HOME_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.HOME_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.HOME_FAX)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.PROVINCE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.CAR_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.AREA)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.NATIVE_PLACE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.PARTY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.NATION)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.NATIONALITY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.WORKING_PROPERTY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.COMPETENCY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.EMERGENCY_CONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.DIMISSION_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.DIMISSION_CAUSE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.DIMISSION_WHITHER)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.CREATE_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.CURRENT_DISTRICT)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.CURRENT_CITY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.CURRENT_PROVINCE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.DISTRICT)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.COMPANY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.DEPARTMENT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.WORKGROUP_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.MARRIAGE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.EXTENSION)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.BANK_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff>()
                .Property(e => e.BANK_USER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff_Organize>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff_Organize>()
                .Property(e => e.STAFF_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff_Organize>()
                .Property(e => e.ORGANIZE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff_Organize>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff_Organize>()
                .Property(e => e.CREATE_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff_Organize>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff_Organize>()
                .Property(e => e.MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Staff_Organize>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Table_Columns>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Table_Columns>()
                .Property(e => e.TABLE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Table_Columns>()
                .Property(e => e.COLUMN_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Table_Columns>()
                .Property(e => e.COLUMN_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Table_Columns>()
                .Property(e => e.DATA_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Table_Columns>()
                .Property(e => e.USE_CONSTRAINT)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Table_Columns>()
                .Property(e => e.TARGET_TABLE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Table_Columns>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Table_Columns>()
                .Property(e => e.CREATE_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Table_Columns>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Table_Columns>()
                .Property(e => e.MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Table_Columns>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.REAL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.PROVINCE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.PROVINCE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.CITY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.DISTRICT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.DISTRICT)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.POST_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.MOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.DELIVER_CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.CREATE_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.EMPLOYEE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.EMPLOYEE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.COMPANY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.COMPANY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.BOX_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.STREET)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Address>()
                .Property(e => e.STREET_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Express>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Express>()
                .Property(e => e.OWNER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Express>()
                .Property(e => e.OWNER_RANGE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Express>()
                .Property(e => e.RECEIVE_AREA)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Express>()
                .Property(e => e.MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Express>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Express>()
                .Property(e => e.CREATE_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Express>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Express>()
                .Property(e => e.DISP_AREA)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Express>()
                .Property(e => e.LONGITUDE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Express>()
                .Property(e => e.LATITUDE)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Express>()
                .Property(e => e.SAN_DUAN_MA)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Express>()
                .Property(e => e.COMPANY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Express>()
                .Property(e => e.ORDER_ASSIGN_TO)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Express>()
                .Property(e => e.COOPERATE_FUNCTION)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User_Express>()
                .Property(e => e.SYS_STSBDKW3OZ1775BWH74P2XAKHX)
                .HasPrecision(22, 0);

            modelBuilder.Entity<Base_User_Express>()
                .Property(e => e.SYS_STSIF_NCZXZZ98_YLI21T6PG2G)
                .HasPrecision(22, 0);

            modelBuilder.Entity<Colp_Appointment_Detail>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Appointment_Detail>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Appointment_Detail>()
                .Property(e => e.Organization_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Appointment_Detail>()
                .Property(e => e.Department_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Appointment_Detail>()
                .Property(e => e.Equipment_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Appointment_Detail>()
                .Property(e => e.User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Appointment_Detail>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Appointment_Detail>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Audit_Diagnose_Detail>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Audit_Diagnose_Detail>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Audit_Diagnose_Detail>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Audit_Diagnose_Detail>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Biopsy_Detail>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Biopsy_Detail>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Biopsy_Detail>()
                .Property(e => e.Organization_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Biopsy_Detail>()
                .Property(e => e.Department_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Biopsy_Detail>()
                .Property(e => e.Equipment_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Biopsy_Detail>()
                .Property(e => e.User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Biopsy_Detail>()
                .Property(e => e.BiopsyPathologyResult)
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Biopsy_Detail>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Biopsy_Detail>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Biopsy_Report_Detail>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Biopsy_Report_Detail>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Biopsy_Report_Detail>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Biopsy_Report_Detail>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Check_List>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Check_List>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Check_List>()
                .Property(e => e.Organization_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Check_List>()
                .Property(e => e.Department_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Check_List>()
                .Property(e => e.Equipment_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Check_List>()
                .Property(e => e.User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Check_List>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Check_List>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Check_Report_Detail>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Check_Report_Detail>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Check_Report_Detail>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Check_Report_Detail>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Configuration_List>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Configuration_List>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Configuration_List>()
                .Property(e => e.Organization_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Configuration_List>()
                .Property(e => e.Department_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Configuration_List>()
                .Property(e => e.Equipment_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Configuration_List>()
                .Property(e => e.User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Configuration_List>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Configuration_List>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Data_Sync_Detail>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Data_Sync_Detail>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Data_Sync_Detail>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Data_Sync_Detail>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Diagnose_Detail>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Diagnose_Detail>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Diagnose_Detail>()
                .Property(e => e.Organization_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Diagnose_Detail>()
                .Property(e => e.Department_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Diagnose_Detail>()
                .Property(e => e.Equipment_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Diagnose_Detail>()
                .Property(e => e.User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Diagnose_Detail>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Diagnose_Detail>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Diagnose_Report_Detail>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Diagnose_Report_Detail>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Diagnose_Report_Detail>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Diagnose_Report_Detail>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Equipment_List>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Equipment_List>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Equipment_List>()
                .Property(e => e.Organization_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Equipment_List>()
                .Property(e => e.Department_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Equipment_List>()
                .Property(e => e.User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Equipment_List>()
                .Property(e => e.Current_Check_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Equipment_List>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Equipment_List>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Evaluate_AI>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Evaluate_AI>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Evaluate_AI>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Evaluate_AI>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Evaluate_RCI_Detail>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Evaluate_RCI_Detail>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Evaluate_RCI_Detail>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Evaluate_RCI_Detail>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_File_Detail>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_File_Detail>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_File_Detail>()
                .Property(e => e.Organization_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_File_Detail>()
                .Property(e => e.Department_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_File_Detail>()
                .Property(e => e.Equipment_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_File_Detail>()
                .Property(e => e.User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_File_Detail>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_File_Detail>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Flup_Detail>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Flup_Detail>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Flup_Detail>()
                .Property(e => e.Organization_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Flup_Detail>()
                .Property(e => e.Department_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Flup_Detail>()
                .Property(e => e.Equipment_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Flup_Detail>()
                .Property(e => e.User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Flup_Detail>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Flup_Detail>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Instruments_List>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Instruments_List>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Instruments_List>()
                .Property(e => e.Organization_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Instruments_List>()
                .Property(e => e.Department_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Instruments_List>()
                .Property(e => e.User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Instruments_List>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Instruments_List>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Operation_Detail>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Operation_Detail>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Operation_Detail>()
                .Property(e => e.Organization_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Operation_Detail>()
                .Property(e => e.Department_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Operation_Detail>()
                .Property(e => e.Equipment_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Operation_Detail>()
                .Property(e => e.User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Operation_Detail>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Operation_Detail>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Operation_Report_Detail>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Operation_Report_Detail>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Operation_Report_Detail>()
                .Property(e => e.User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Operation_Report_Detail>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Operation_Report_Detail>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Pathology_Detail>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Pathology_Detail>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Pathology_Detail>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Pathology_Detail>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Patient_List>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Patient_List>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Patient_List>()
                .Property(e => e.Organization_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Patient_List>()
                .Property(e => e.Department_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Patient_List>()
                .Property(e => e.Equipment_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Patient_List>()
                .Property(e => e.User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Patient_List>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Patient_List>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Picture_Annotate_Detail>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Picture_Annotate_Detail>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Picture_Annotate_Detail>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Picture_Annotate_Detail>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_QueueManage_List>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_QueueManage_List>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_QueueManage_List>()
                .Property(e => e.Organization_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_QueueManage_List>()
                .Property(e => e.Department_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_QueueManage_List>()
                .Property(e => e.Equipment_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_QueueManage_List>()
                .Property(e => e.User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_QueueManage_List>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_QueueManage_List>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Report_List>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Report_List>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Report_List>()
                .Property(e => e.Report_Tempelate_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Report_List>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Report_List>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Report_Tempelate_Detail>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Report_Tempelate_Detail>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Report_Tempelate_Detail>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Report_Tempelate_Detail>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Report_Tempelate_List>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Report_Tempelate_List>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Report_Tempelate_List>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Report_Tempelate_List>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Statistical_List>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Statistical_List>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Statistical_List>()
                .Property(e => e.Organization_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Statistical_List>()
                .Property(e => e.Department_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Statistical_List>()
                .Property(e => e.Equipment_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Statistical_List>()
                .Property(e => e.User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Statistical_List>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Statistical_List>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Term_Detailrrrr>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Term_Detailrrrr>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Term_Detailrrrr>()
                .Property(e => e.Organization_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Term_Detailrrrr>()
                .Property(e => e.Department_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Term_Detailrrrr>()
                .Property(e => e.Equipment_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Term_Detailrrrr>()
                .Property(e => e.User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Term_Detailrrrr>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Term_Detailrrrr>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Typicalcase_Detail>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Typicalcase_Detail>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Typicalcase_Detail>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Typicalcase_Detail>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.property)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Area>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Area>()
                .Property(e => e.Parent_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Audit_Status>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Audit_Status>()
                .Property(e => e.Parent_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Big_Area>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Big_Area>()
                .Property(e => e.Parent_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Bug_Category>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Bug_Category>()
                .Property(e => e.Parent_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Bug_Level>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Bug_Level>()
                .Property(e => e.Parent_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Condition>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Condition>()
                .Property(e => e.Parent_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Duty>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Duty>()
                .Property(e => e.Parent_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_EditFields>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_EditFields>()
                .Property(e => e.Parent_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Gender>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Gender>()
                .Property(e => e.Parent_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Marriage>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Marriage>()
                .Property(e => e.Parent_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Nationality>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Nationality>()
                .Property(e => e.Parent_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_News_Category>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_News_Category>()
                .Property(e => e.Parent_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Organize_Category>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Organize_Category>()
                .Property(e => e.Parent_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Organize_Joining_Methods>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Organize_Joining_Methods>()
                .Property(e => e.Parent_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Party>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Party>()
                .Property(e => e.Parent_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Priority>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Priority>()
                .Property(e => e.Parent_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Role_Category>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Role_Category>()
                .Property(e => e.Parent_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Security_Level>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Security_Level>()
                .Property(e => e.Parent_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Table_Permission_Scope>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Table_Permission_Scope>()
                .Property(e => e.Parent_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Title>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Title>()
                .Property(e => e.Parent_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_True_False>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_True_False>()
                .Property(e => e.Parent_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Units>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Units>()
                .Property(e => e.Parent_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Work_Status>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Work_Status>()
                .Property(e => e.Parent_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Working_Property>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Working_Property>()
                .Property(e => e.Parent_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Yes_No>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Items_Yes_No>()
                .Property(e => e.Parent_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Mvc_Base_Organize_Scope>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Mvc_Base_Organize_Scope>()
                .Property(e => e.RESOURCE_CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<Mvc_Base_Organize_Scope>()
                .Property(e => e.RESOURCE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Mvc_Base_Organize_Scope>()
                .Property(e => e.PERMISSION_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Mvc_Base_Organize_Scope>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<Mvc_Base_Organize_Scope>()
                .Property(e => e.CREATE_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Mvc_Base_Organize_Scope>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Mvc_Base_Organize_Scope>()
                .Property(e => e.MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Mvc_Base_Organize_Scope>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Option_Items_Express>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<Option_Items_Express>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<PDA_USER_LOG_ON>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<PDA_USER_LOG_ON>()
                .Property(e => e.USER_FROM)
                .IsUnicode(false);

            modelBuilder.Entity<PDA_USER_LOG_ON>()
                .Property(e => e.USER_PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<PDA_USER_LOG_ON>()
                .Property(e => e.OPEN_ID)
                .IsUnicode(false);

            modelBuilder.Entity<PDA_USER_LOG_ON>()
                .Property(e => e.VERIFICATION_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PDA_USER_LOG_ON>()
                .Property(e => e.IPADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<PDA_USER_LOG_ON>()
                .Property(e => e.MAC_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<PDA_USER_LOG_ON>()
                .Property(e => e.QUESTION)
                .IsUnicode(false);

            modelBuilder.Entity<PDA_USER_LOG_ON>()
                .Property(e => e.ANSWER_QUESTION)
                .IsUnicode(false);

            modelBuilder.Entity<PDA_USER_LOG_ON>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<PDA_USER_LOG_ON>()
                .Property(e => e.CREATE_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<PDA_USER_LOG_ON>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<PDA_USER_LOG_ON>()
                .Property(e => e.MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<PDA_USER_LOG_ON>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<PDA_USER_LOG_ON>()
                .Property(e => e.SALT)
                .IsUnicode(false);

            modelBuilder.Entity<PDA_USER_LOG_ON>()
                .Property(e => e.SYSTEM_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PDA_USER_LOG_ON>()
                .Property(e => e.IPADDRESS_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PDA_USER_LOG_ON>()
                .Property(e => e.COMPUTER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PDA_USER_LOG_ON>()
                .Property(e => e.COMPANY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<PDA_USER_LOG_ON>()
                .Property(e => e.COMPANY)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.Permission_Scope_Tables)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.FULL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.HEADQUARTERS_ID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.HEADQUARTERS_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.HEADQUARTERS)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.BIG_AREA_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.BIG_AREA)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.AREA_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.AREA)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.TRANSFER_FIRST_ID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.TRANSFER_FIRST_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.TRANSFER_FIRST)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.COMPANY_FIRST_ID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.COMPANY_FIRST_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.COMPANY_FIRST)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.COMPANY_SECOND_ID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.COMPANY_SECOND_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.COMPANY_SECOND)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.CONTRACT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.CONTRACT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.CONTRACT)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.PARENT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.PARENT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.PARENT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.COUNTRY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.COUNTRY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.COUNTRY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.PROVINCE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.PROVINCE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.PROVINCE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.CITY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.CITY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.DISTRICT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.DISTRICT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.DISTRICT)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.STREET_ID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.STREET_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.STREET)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.CREATE_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORGANIZE_HORIZONTAL>()
                .Property(e => e.CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Term_Detail>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Term_Detail>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Term_Detail>()
                .Property(e => e.Organization_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Term_Detail>()
                .Property(e => e.Department_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Term_Detail>()
                .Property(e => e.Equipment_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Term_Detail>()
                .Property(e => e.User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Term_Detail>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Term_Detail>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
