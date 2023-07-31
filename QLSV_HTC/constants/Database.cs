using System;
class Database
{
    public static String connectionString = "";
    public static String connectionStringPublisher = "";

    public static String servername = "";
    public static String username = "";
    public static String mlogin = "";
    public static String password = "";

    public static String database = "TN_CSDLPT";
    public static String remoteLogin = "HTKN";
    public static String remotePassword = "123456";

    public static String mLoginDN = "";
    public static String passwordDN = "";
    public static String mGroup = "";
    public static String mHoTen = "";
    public static String maCoSo = "";
    public static int indexCoSo = -1;

    public static String maSinhVien = "";
    public static String maLop = "";
    public static String tenLop = "";

    public static string ROLE_SCHOOL = "TRUONG";
    public static string ROLE_LOCATION = "COSO";
    public static string ROLE_TEACHER = "GIANGVIEN";
    public static string ROLE_STUDENT = "SINHVIEN";

    public static string STATEMENT_SELECT_ALL = "SELECT * FROM {0}";
    public static string VIEW_ALL_LOCATIONS = "VIEW_ALL_LOCATIONS";

    /// <summary>
    /// {0} : id
    /// </summary>
    public static string SP_INSERT_SUBJECT = "EXEC SP_INSERT_SUBJECT {0}, {1}";
    public static string SP_UPDATE_SUBJECT = "EXEC SP_UPDATE_SUBJECT {0}, {1}";
    public static string SP_DELETE_SUBJECT = "EXEC SP_DELETE_SUBJECT {0}";


    public static string SP_INSERT_STUDENT = "EXEC SP_INSERT_STUDENT {0}, {1}, {2}, {3}, {4}";
    public static string SP_UPDATE_STUDENT = "EXEC SP_UPDATE_STUDENT {0}, {1}";
    public static string SP_DELETE_STUDENT = "EXEC SP_DELETE_STUDENT {0}";
    public static string SP_CHECK_USERNAME_EXISTS = "EXEC CHECK_USERNAME_EXISTS {0}";
    public static string SP_CHECK_LOGINNAME_EXISTS = "EXEC CHECK_LOGINNAME_EXISTS {0}";
    
    /// <summary>
    /// 0: login name
    /// 1: password
    /// 2: username
    /// 3: role
    /// </summary>
    public static string SP_CREATE_LOGIN = "EXEC SP_CREATE_LOGIN '{0}', '{1}', '{2}', '{3}'";


    public static string TABLE_STUDENT = "SINHVIEN";
    public static string TABLE_LOCATION = "COSO";
    public static string TABLE_EXAM_RESULT = "BANGDIEM";
    public static string TABLE_EXAM_DETAIL = "CT_BAITHI";
    public static string TABLE_SUBJECT = "MONHOC";
    public static string TABLE_TEACHER = "GIAOVIEN";
    public static string TABLE_TEACHER_EXAM = "GIAOVIEN_DANGKY";
    public static string TABLE_CLASS = "LOP";
    public static string TABLE_DEPARTMENT = "KHOA";
    public static string TABLE_TOPIC = "BODE";

    
}