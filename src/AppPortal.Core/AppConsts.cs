namespace AppPortal.Core
{
    public class AppConst
    {
        public AppConst()
        {

        }
        public const string GROUP_ADMIN = "Admins";
        public const string GROUP_USER = "Users";
        public const string ROLE_SYSADMIN = TypeRole.SysAdmin;
        public const string ROLE_Mode = TypeRole.Mode;
        public const string ROLE_Editor = TypeRole.Editor;
        public const string ROLE_Department = TypeRole.Department;
        public const string ROLE_User = TypeRole.User;
        public const string ROLE_Member = TypeRole.Member;
        public const string ROLE_Guest = TypeRole.Guest;
    }

    public class TypeRole
    {
        public const string
        SysAdmin = "SYS_ADMINISTRATOR",
        Mode = "LANH_DAO",
        Editor = "DANG_BAI",
        Department = "PHONG_BAN",
        User = "USER_THUONG_TRUC",
        Member = "USER_THUONG",
        Guest = "G_KHACH";
    }

    public class ActionId
    {
        public const string
        Home = ":Home:Index",
        Logout = ":Account:Logout",
        Error = ":Home:Error";
    }

    public class PolicyRole
    {
        public const string
            ADMINISTRATOR_ONLY = "AdministratorOnly",
            EDIT_ONLY = "EditOnly",
            EMPLOYEE_ID = "EmployeeAll";
    }

    public enum Separator
    {
        Comma = ',',
        Tab = '\t',
        Space = ' '
    }
}
