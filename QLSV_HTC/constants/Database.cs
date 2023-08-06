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

    //ROLES
    public const string ROLE_SCHOOL = "TRUONG";
    public const string ROLE_LOCATION = "COSO";
    public const string ROLE_TEACHER = "GIANGVIEN";
    public const string ROLE_STUDENT = "SINHVIEN";

    //VIEWS
    public const string STATEMENT_SELECT_ALL = "SELECT * FROM {0}";
    public const string VIEW_ALL_LOCATIONS = "VIEW_ALL_LOCATIONS";

    //STORE PROCEDUES
    /// <summary>
    /// {0} : id
    /// </summary>
    public const string SP_INSERT_SUBJECT = "EXEC SP_INSERT_SUBJECT N'{0}', N'{1}'";
    public const string SP_UPDATE_SUBJECT = "EXEC SP_UPDATE_SUBJECT N'{0}', N'{1}'";
    public const string SP_DELETE_SUBJECT = "EXEC SP_DELETE_SUBJECT N'{0}'";

    /// <summary>
    /// 0: login name
    /// 1: password
    /// 2: username
    /// 3: role
    /// </summary>
    public const string SP_INSERT_STUDENT = "EXEC SP_INSERT_STUDENT {0}, {1}, {2}, {3}, {4}";

    /// <summary>
    /// 0: login name
    /// 1: password
    /// 2: username
    /// 3: role
    /// </summary>
    public const string SP_UPDATE_STUDENT = "EXEC SP_UPDATE_STUDENT {0}, {1}";

    /// <summary>
    /// 0: login name
    /// 1: password
    /// 2: username
    /// 3: role
    /// </summary>
    public const string SP_DELETE_STUDENT = "EXEC SP_DELETE_STUDENT {0}";
    public const string SP_CHECK_USERNAME_EXISTS = "EXEC CHECK_USERNAME_EXISTS {0}";
    public const string SP_CHECK_LOGINNAME_EXISTS = "EXEC CHECK_LOGINNAME_EXISTS {0}";
    
    /// <summary>
    /// 0: login name
    /// 1: password
    /// 2: username
    /// 3: role
    /// </summary>
    public const string SP_CREATE_LOGIN = "EXEC SP_CREATE_LOGIN '{0}', '{1}', '{2}', '{3}'";

    /// <summary>
    /// 0: question NO
    /// 1: subject ID
    /// 2: level
    /// 3: question
    /// 4: answer A
    /// 5: answer B
    /// 6: answer C
    /// 7: answer D
    /// 8: answer
    /// 9: teacher ID
    /// </summary>
    public const string SP_INSERT_TOPIC = "EXEC SP_INSERT_TOPIC '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}'";

    /// <summary>
    /// 0: question NO
    /// 1: subject ID
    /// 2: level
    /// 3: question
    /// 4: answer A
    /// 5: answer B
    /// 6: answer C
    /// 7: answer D
    /// 8: answer
    /// 9: teacher ID
    /// </summary>
    public const string SP_UPDATE_TOPIC = "EXEC SP_UPDATE_TOPIC '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}'";

    /// <summary>
    /// 0: Login Name
    /// </summary>
    public const string SP_GET_TEACHER_LOGIN_INFO = "EXEC SP_GET_TEACHER_LOGIN_INFO N'{0}'";

    /// <summary>
    /// 0: student ID
    /// 1: password
    /// </summary>
    public const string SP_GET_STUDENT_LOGIN_INFO = "EXEC SP_GET_STUDENT_LOGIN_INFO N'{0}', N'{1}'";

    //TABLES
    public const string TABLE_STUDENT = "SINHVIEN";
    public const string TABLE_LOCATION = "COSO";
    public const string TABLE_EXAM_RESULT = "BANGDIEM";
    public const string TABLE_EXAM_DETAIL = "CT_BAITHI";
    public const string TABLE_SUBJECT = "MONHOC";
    public const string TABLE_TEACHER = "GIAOVIEN";
    public const string TABLE_TEACHER_EXAM = "GIAOVIEN_DANGKY";
    public const string TABLE_CLASS = "LOP";
    public const string TABLE_DEPARTMENT = "KHOA";
    public const string TABLE_TOPIC = "BODE";

    //COLUMS
    public const string VIEW_ALL_LOCATION_COL_LOCATION_ID = "MACS";
    public const string VIEW_ALL_LOCATION_COL_LOCATION_NAME = "TENCS";
    public const string VIEW_ALL_LOCATION_COL_LOCATION_SERVER = "TENSERVER";

    public static string TABLE_SUBJECT_COL_SUBJECT_ID = "MAMH";
    public static string TABLE_SUBJECT_COL_SUBJECT_NAME = "TENMH";

    
}