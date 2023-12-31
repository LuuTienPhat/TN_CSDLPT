﻿using System;
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
    /// {0}: student ID
    /// {1}: subject ID
    /// {2}: number of exam times
    /// </summary>
    public const string SP_CHECK_STUDENT_ALREADY_FINISHED_EXAM = "SP_CHECK_STUDENT_ALREADY_FINISHED_EXAM";


    /// <summary>
    /// {0}: subject ID
    /// {1}: level
    /// {2}: number of exam times
    /// </summary>
    public const string SP_GET_QUESTIONS = "SP_GET_QUESTIONS";

    /// <summary>
    /// {0}: student ID
    /// {1}: level
    /// {2}: exam date
    /// {3}: number of exam times
    /// </summary>
    public const string SP_FIND_EXAM_FOR_STUDENT = "SP_FIND_EXAM_FOR_STUDENT";

    /// <summary>
    /// {0}: subject ID
    /// {1}: exam date
    /// {2}: number of exam times
    /// </summary>
    public const string SP_FIND_EXAM_FOR_TEACHER = "SP_FIND_EXAM_FOR_TEACHER";

    /// <summary>
    /// {0}: id
    /// {1}: name
    /// {2}: location ID
    /// </summary>
    public const string SP_INSERT_DEPARTMENT = "SP_INSERT_DEPARTMENT";

    /// <summary>
    /// {0}: id
    /// {1}: name
    /// {2}: location ID
    /// </summary>
    public const string SP_UPDATE_DEPARTMENT = "SP_UPDATE_DEPARTMENT";

    /// <summary>
    /// {0}: id
    /// </summary>
    public const string SP_DELETE_DEPARTMENT = "SP_DELETE_DEPARTMENT";

    /// <summary>
    /// 0: teacher ID
    /// 1: last name
    /// 2: first name
    /// 4: address
    /// 6: department ID
    /// </summary>
    public const string SP_INSERT_TEACHER = "SP_INSERT_TEACHER";

    /// <summary>
    /// 0: teacher ID
    /// 1: last name
    /// 2: first name
    /// 4: address
    /// 6: department ID
    /// </summary>
    public const string SP_UPDATE_TEACHER = "SP_UPDATE_TEACHER";

    /// <summary>
    /// 0: teacher ID
    /// </summary>
    public const string SP_DELETE_TEACHER = "SP_DELETE_TEACHER";

    /// <summary>
    /// {0}: id
    /// {1}: name
    /// </summary>
    public const string SP_INSERT_SUBJECT = "EXEC SP_INSERT_SUBJECT N'{0}', N'{1}'";

    /// <summary>
    /// {0}: id
    /// {1}: name
    /// </summary>
    public const string SP_UPDATE_SUBJECT = "EXEC SP_UPDATE_SUBJECT N'{0}', N'{1}'";

    /// <summary>
    /// {0}: id
    /// </summary>
    public const string SP_DELETE_SUBJECT = "EXEC SP_DELETE_SUBJECT N'{0}'";

    /// <summary>
    /// {0}: id
    /// {1}: name
    /// {2}: deparment ID
    /// </summary>
    public const string SP_INSERT_CLASS = "SP_INSERT_CLASS";

    /// <summary>
    /// {0}: id
    /// {1}: name
    /// {2}: deparment ID
    /// </summary>
    public const string SP_UPDATE_CLASS = "SP_UPDATE_CLASS";

    /// <summary>
    /// {0}: id
    /// </summary>
    public const string SP_DELETE_CLASS = "SP_DELETE_CLASS";

    /// <summary>
    /// 0: student ID
    /// 1: last name
    /// 2: first name
    /// 3: birth date
    /// 4: address
    /// 5: password
    /// 6: class ID
    /// </summary>
    public const string SP_INSERT_STUDENT = "SP_INSERT_STUDENT";

    /// <summary>
    /// 0: student ID
    /// 1: last name
    /// 2: first name
    /// 3: birth date
    /// 4: address
    /// 5: password
    /// 6: class ID
    /// </summary>
    public const string SP_UPDATE_STUDENT = "SP_UPDATE_STUDENT";

    /// <summary>
    /// 0: student ID
    /// </summary>
    public const string SP_DELETE_STUDENT = "SP_DELETE_STUDENT";

    /// <summary>
    /// {0} : user name
    /// </summary>
    public const string SP_CHECK_USERNAME_EXISTS = "EXEC SP_CHECK_USERNAME_EXISTS N'{0}'";

    /// <summary>
    /// {0} : login name
    /// </summary>
    public const string SP_CHECK_LOGINNAME_EXISTS = "EXEC SP_CHECK_LOGINNAME_EXISTS N'{0}'";

    /// <summary>
    /// 0: login name
    /// 1: password
    /// 2: username
    /// 3: role
    /// </summary>
    public const string SP_CREATE_LOGIN = "EXEC SP_CREATE_LOGIN '{0}', '{1}', '{2}', '{3}'";

    /// <summary>
    /// 0: login name
    /// 1: user name
    /// </summary>
    public const string SP_DELETE_LOGIN = "SP_DELETE_LOGIN";


    public const string SP_GET_NEXT_QUESTION_NO = "SP_GET_NEXT_QUESTION_NO";

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
    public const string SP_INSERT_TOPIC = "SP_INSERT_TOPIC";

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
    public const string SP_UPDATE_TOPIC = "SP_UPDATE_TOPIC";

    /// <summary>
    /// 0: question NO
    /// </summary>
    public const string SP_DELETE_TOPIC = "SP_DELETE_TOPIC";

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
    public const string SP_INSERT_GRADE = "SP_INSERT_GRADE";

    /// <summary>
    /// 0: class ID
    /// 1: subject ID
    /// 2: number Of Exam Times
    /// 3: exam date
    /// </summary>
    public const string SP_CHECK_TEACHER_REGISTRATION_EXISTS = "SP_CHECK_TEACHER_REGISTRATION_EXISTS";

    /// <summary>
    /// 0: class ID
    /// 1: subject ID
    /// 2: number Of Exam Times
    /// 3: exam date
    /// </summary>
    public const string SP_CHECK_UPDATE_TEACHER_REGISTRATION = "SP_CHECK_UPDATE_TEACHER_REGISTRATION";

    /// <summary>
    /// 0: class ID
    /// 1: subject ID
    /// 2: number Of Exam Times
    /// 3: exam date
    /// </summary>
    public const string SP_CHECK_DELETE_TEACHER_REGISTRATION = "SP_CHECK_DELETE_TEACHER_REGISTRATION";

    /// <summary>
    /// 0: teacher ID
    /// 1: subject ID
    /// 2: class ID
    /// 3: level
    /// 4: exam date
    /// 5: number Of Exam Times
    /// 6: number Of Question
    /// 7: exam times
    /// </summary>
    public const string SP_UPDATE_TEACHER_REGISTRATION = "SP_UPDATE_TEACHER_REGISTRATION";

    /// <summary>
    /// 0: teacher ID
    /// 1: subject ID
    /// 2: class ID
    /// 3: level
    /// 4: exam date
    /// 5: number Of Exam Times
    /// 6: number Of Question
    /// 7: exam times
    /// </summary>
    public const string SP_INSERT_TEACHER_REGISTRATION = "SP_INSERT_TEACHER_REGISTRATION";

    /// <summary>
    /// 1: subject ID
    /// 2: class ID
    /// 5: number Of Exam Times
    /// </summary>
    public const string SP_DELETE_TEACHER_REGISTRATION = "SP_DELETE_TEACHER_REGISTRATION";

    /// <summary>
    /// 0: Login Name
    /// </summary>
    public const string SP_GET_TEACHER_LOGIN_INFO = "EXEC SP_GET_TEACHER_LOGIN_INFO N'{0}'";

    /// <summary>
    /// 0: student ID
    /// 1: password
    /// </summary>
    public const string SP_GET_STUDENT_LOGIN_INFO = "EXEC SP_GET_STUDENT_LOGIN_INFO N'{0}', N'{1}'";


    /// <summary>
    /// 0: student ID
    /// 1: subject ID
    /// 2: number of exam times
    /// </summary>
    public const string SP_REPORT_EXAM_RESULT_CHECK_BEFORE_HAND = "SP_REPORT_EXAM_RESULT_CHECK_BEFORE_HAND";

    /// <summary>
    /// 0: class ID
    /// 1: subject ID
    /// 2: number of exam times
    /// </summary>
    public const string SP_REPORT_SUBJECT_GRADE_SHEET_CHECK_SUBJECT_AVAILABLE_FOR_CLASS = "SP_REPORT_SUBJECT_GRADE_SHEET_CHECK_SUBJECT_AVAILABLE_FOR_CLASS";


    //TABLES
    public const string TABLE_STUDENT = "SINHVIEN";
    public const string TABLE_LOCATION = "COSO";
    public const string TABLE_EXAM_RESULT = "BANGDIEM";
    public const string TABLE_EXAM_DETAIL = "CT_BAITHI";
    public const string TABLE_SUBJECT = "MONHOC";
    public const string TABLE_TEACHER = "GIAOVIEN";
    public const string TABLE_TEACHER_REGISTRATION = "GIAOVIEN_DANGKY";
    public const string TABLE_CLASS = "LOP";
    public const string TABLE_DEPARTMENT = "KHOA";
    public const string TABLE_TOPIC = "BODE";

    //COLUMS
    public const string VIEW_ALL_LOCATION_COL_LOCATION_ID = "MACS";
    public const string VIEW_ALL_LOCATION_COL_LOCATION_NAME = "TENCS";
    public const string VIEW_ALL_LOCATION_COL_LOCATION_SERVER = "TENSERVER";

    public const string TABLE_LOCATION_COL_LOCATION_ID = "MACS";
    public const string TABLE_LOCATION_COL_LOCATION_NAME = "TENCS";

    public const string TABLE_SUBJECT_COL_SUBJECT_ID = "MAMH";
    public const string TABLE_SUBJECT_COL_SUBJECT_NAME = "TENMH";

    public const string TABLE_DEPT_COL_DEPT_ID = "MAKH";
    public const string TABLE_DEPT_COL_DEPT_NAME = "TENKH";
    public const string TABLE_DEPT_COL_DEPT_LOCATION_ID = "MACS";

    public const string TABLE_CLASS_COL_CLASS_ID = "MALOP";
    public const string TABLE_CLASS_COL_CLASS_NAME = "TENLOP";
    public const string TABLE_CLASS_COL_CLASS_DEPARTMENT_ID = "MAKH";

    public const string TABLE_TEACHER_COL_TEACHER_ID = "MAGV";
    public const string TABLE_TEACHER_COL_TEACHER_LASTNAME = "HO";
    public const string TABLE_TEACHER_COL_TEACHER_FIRSTNAME = "TEN";
    public const string TABLE_TEACHER_COL_TEACHER_ADDRESS = "DIACHI";
    public const string TABLE_TEACHER_COL_TEACHER_DEPARTMENT_ID = "MAKH";

    public const string TABLE_STUDENT_COL_STUDENT_ID = "MASV";
    public const string TABLE_STUDENT_COL_STUDENT_LASTNAME = "HO";
    public const string TABLE_STUDENT_COL_STUDENT_FIRSTNAME = "TEN";
    public const string TABLE_STUDENT_COL_STUDENT_BIRTHDATE = "NGAYSINH";
    public const string TABLE_STUDENT_COL_STUDENT_ADDRESS = "DIACHI";
    public const string TABLE_STUDENT_COL_STUDENT_PASSWORD = "MATKHAU";
    public const string TABLE_STUDENT_COL_STUDENT_CLASS_ID = "MALOP";

    public const string TABLE_TEACHER_REGISTRATION_CLASS_ID = "MALOP";
    public const string TABLE_TEACHER_REGISTRATION_SUBJECT_ID = "MAMH";
    public const string TABLE_TEACHER_REGISTRATION_TEACHER_ID = "MAGV";
    public const string TABLE_TEACHER_REGISTRATION_LEVEL = "TRINHDO";
    public const string TABLE_TEACHER_REGISTRATION_EXAM_DATE = "NGAYTHI";
    public const string TABLE_TEACHER_REGISTRATION_NUMBER_OF_EXAM_TIMES = "LAN";
    public const string TABLE_TEACHER_REGISTRATION_NUMBER_OF_QUESTIONS = "SOCAUTHI";
    public const string TABLE_TEACHER_REGISTRATION_EXAM_TIME = "THOIGIAN";

    public const string TABLE_TOPIC_COL_QUESTION_NO = "CAUHOI";
    public const string TABLE_TOPIC_COL_SUBJECT_ID = "MAMH";
    public const string TABLE_TOPIC_COL_LEVEL = "TRINHDO";
    public const string TABLE_TOPIC_COL_CONTENT = "NOIDUNG";
    public const string TABLE_TOPIC_COL_ANSWER_A = "A";
    public const string TABLE_TOPIC_COL_ANSWER_B = "B";
    public const string TABLE_TOPIC_COL_ANSWER_C = "C";
    public const string TABLE_TOPIC_COL_ANSWER_D = "D";
    public const string TABLE_TOPIC_COL_ANSWER = "DAP_AN";
    public const string TABLE_TOPIC_COL_TEACHER_ID = "MAGV";
}