using System;
using System.Collections.Generic;
using System.Text;

namespace Urja.Utility.Services.Constant
{
    public interface IStringConstant
    {
        string InvalidRequest { get; }
        string LoginCredentailWrong { get; }
        string InvalidPassword { get; }
        string UserAccountDeleted { get; }
        string LoginSuccessfull { get; }
        string AlreadyExists { get; }
        string SignUpSuccessfull { get; }
        string SignUpFail { get; }
        string NoDataFound { get; }
        string AddedSuccessfully { get; }
        string FailToAdd { get; }
        string UpdatedSuccessfully { get; }
        string FailToUpdate { get; }
        string DeletedSuccessfully { get; }
        string FailToDelete { get; }
        string InvalidEmail { get; }
        string ResetPassword { get; }
        string ResetPasswordFailed { get; }
        string OtpSentSuccessfully { get; }
        string NewPasswordSent { get; }
    }
}
