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
    /// {0} : student ID
    /// {1} : subject ID
    /// {2} : number of exam times
    /// </summary>
    public const string SP_CHECK_STUDENT_ALREADY_FINISHED_EXAM = "SP_CHECK_STUDENT_ALREADY_FINISHED_EXAM";


    /// <summary>
    /// {0} : subject ID
    /// {1} : level
    /// {2} : number of exam times
    /// </summary>
    public const string SP_GET_QUESTIONS = "SP_GET_QUESTIONS";

    /// <summary>
    /// {0} : student ID
    /// {1} : level
    /// {2} : exam date
    /// {3} : number of exam times
    /// </summary>
    public const string SP_FIND_EXAM_SUBECT = "SP_FIND_EXAM_SUBECT";

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
    public const string SP_INSERT_STUDENT = "EXEC SP_INSERT_STUDENT N'{0}', N'{1}', N'{2}', N'{3}', N'{4}'";

    /// <summary>
    /// 0: login name
    /// 1: password
    /// 2: username
    /// 3: role
    /// </summary>
    public const string SP_UPDATE_STUDENT = "EXEC SP_UPDATE_STUDENT N'{0}', N'{1}'";

    /// <summary>
    /// 0: login name
    /// 1: password
    /// 2: username
    /// 3: role
    /// </summary>
    public const string SP_DELETE_STUDENT = "EXEC SP_DELETE_STUDENT N'{0}'";
    public const string SP_CHECK_USERNAME_EXISTS = "EXEC CHECK_USERNAME_EXISTS N'{0}'";
    public const string SP_CHECK_LOGINNAME_EXISTS = "EXEC CHECK_LOGINNAME_EXISTS N'{0}'";
    
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
    public const string SP_INSERT_TOPIC = "EXEC SP_INSERT_TOPIC N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}'";

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
    public const string SP_UPDATE_TOPIC = "EXEC SP_UPDATE_TOPIC N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}'";


    /// <summary>
    /// 0: question NO
    /// 1: student ID
    /// 2: subject ID
    /// 3: number Of Exam Times
    /// 4: question
    /// 5: answer (A, B, C, D)
    /// </summary>
    ///public const string SP_INSERT_EXAM_DETAIL = "EXEC SP_INSERT_EXAM_DETAIL N'{0}', N'{1}', N'{2}', N'{3}', N'{4}'";

    /// <summary>
    /// 0: An string with format @CAUSO, @MASV, @MAMH, @LAN, @CAUHOI, @DACHON||....
    /// </summary>
    ///public const string SP_INSERT_EXAM_DETAIL = "EXEC SP_INSERT_EXAM_DETAIL N'{0}', N'{1}', N'{2}', N'{3}', N'{4}'";

    /// <summary>
    /// 0: student ID
    /// 1: subject ID
    /// 2: number Of Exam Times
    /// 3: exam date
    /// 4: grade
    /// </summary>
    public const string SP_INSERT_SCORE = "SP_INSERT_SCORE";

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

    public static string TABLE_CLASS_COL_CLASS_ID = "MALOP";
    public static string TABLE_CLASS_COL_CLASS_NAME = "TENLOP";
    public static string TABLE_CLASS_COL_CLASS_DEPARTMENT_ID = "MAKH";

    public static string TABLE_STUDENT_COL_STUDENT_ID = "MASV";
    public static string TABLE_STUDENT_COL_STUDENT_LASTNAME = "HO";
    public static string TABLE_STUDENT_COL_STUDENT_FIRSTNAME = "TEN";
}