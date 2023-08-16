using System;
using System.Collections.Generic;

class Translation
{
    /// <summary>
    /// {0} exception message
    /// </summary>
    public static string _argsDatabaseConnectErrorMsg = "Unable to connect to database.\n{0}";
    public static string _argsNotEmptyMsg = "{0} should not be empty!";
    public static string _argsInputFieldTooltipMsg = "Please enter {0}.";
    public const string _argsRefreshErrorMsg = "Reload error\n{0}.";
    public const string _argsCommitDatabaseErrorMsg = "Couldn't Commit Database. Please try again!\n{0}." ;
    public const string _argsUndoErrorMsg = "Couldn't undo. Please try again!\n{0}.";
    public const string _argsLocationConnectErrorMsg = "Couldn't connect to {0}";
    public const string _argsDeleteErrorMsg = "Couldn't delete {0}.Try again!\n{1}";
    public const string _argFieldNotValidErrorMsg = "{0} is not valid!";
    public const string _argsExamSubjectNotFoundMsg = "Couldn't find exam subjects\n{0}";

    public const string _argsDeleteWarningMsg = "Are you sure to delete this {0}?";

    public const string _incorectSignInUsernamePasswordMsg = "Username or Password are incorrect!";
    public const string _userPriviledgeNotValidMsg = "Your account does not have priviledge.Please check again!";
    public const string _subjectAlreadyHasScoreListMsg = "Subject already has Score list";
    public const string _subjectAlreadyHasTopicMsg = "Subject already has Topic";
    public const string _subjectAlreadyHasTeacherMsg = "Subject already has Teacher Register";
    public const string _examSubjectNotFoundMsg = "Couldn't find the exam subjects. Please make sure this subject was assigned to your class.";
    
    public const string _teacherExamResultMsg = "Your Exam result is {0}";
    public const string _studentExamResultMsg = "Your Exam result is {0}.\nOK view details.";

    public const string _incorrectNumberOfExamTimesErrorMsg = "Number Of Exam Times must be twice at least.";
    public const string _incorrectTotalQuestionErrorMsg = "The exam must have a minimum of 10 questions and a maximum of 100 questions.";
    public const string _incorrectTotalMinutesErrorMsg = "Exam time must be more than 15 minutes.";
    public const string _noTestHeldOnSundayErrorMsg = "There are no exams on Sundays.";
    public const string _invalidExamDateErrorMsg = "Invalid Exam date";

    public const string _teacherCannotEditQuestionOfOtherTeacherMsg = "You can't modify question of other teacher!";
    public const string _argsFailedToGetNextQuestionNoErrorMsg = "Couldn't get next question no\n{0}";

    public const string _argsStudentHasNeverDoneAnyExamErrorMsg = "Student has never done any exam of this subject";
    public const string _examResultNotFoundErrorMsg = "Couldn't find any exam result";

    public static string _errorTitle = "Error";
    public static string _warningTitle = "Warning";
    public static string _infomationTitle = "Information";

    public static string _usernameLabel = "Username";
    public static string _passwordLabel = "Password";
    public static string _usernameTeacherLabel = "Username";
    public static string _usernameStudentLabel = "Student Code";
    public static string _idLabel = "Id";
    public static string _nameLabel = "Name";
    public static string _teacherInfoLabel = "Teacher Info";

    //FormSignUp
    public static string _loginNameExistsMsg = "Login Name is already exists. Please choose another!";
    public static string _userNameExistsMsg = "User Name is already exists. Please choose another!";
    public static string _signUpSuccessfullyMsg = "Sign up successfully";
    public static string _signUpFailedMsg = "Failed to Sign up";
}