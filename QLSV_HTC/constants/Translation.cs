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
    public const string _argsCommitErrorMsg = "Couldn't commit. Please try again!\n{0}." ;
    public const string _argsUndoErrorMsg = "Couldn't undo. Please try again!\n{0}.";
    public const string _argsLocationConnectErrorMsg = "Couldn't connect to {0}";
    public const string _argsDeleteErrorMsg = "Couldn't delete {0}.Try again!";

    public const string _argsDeleteWarningMsg = "Are you sure to delete this {0}?";

    public static string _incorectSignInUsernamePasswordMsg = "Username or Password are incorrect!";
    public const string _userPriviledgeNotValidMsg = "Your account does not have priviledge.Please check again!";
    public const string _subjectAlreadyHasScoreList = "Subject already has Score list";
    public const string _subjectAlreadyHasTopic = "Subject already has Topic";
    public const string _subjectAlreadyHasTeacher = "Subject already has Teacher Register";

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
}