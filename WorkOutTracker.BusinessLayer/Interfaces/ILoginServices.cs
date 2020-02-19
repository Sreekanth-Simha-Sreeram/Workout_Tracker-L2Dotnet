using System;
using System.Collections.Generic;
using System.Text;

namespace WorkOutTracker.BusinessLayer.Interfaces
{
    public interface ILoginServices
    {
        void signUp(String userName, String userPassword, String userEmail);
        bool signIn(String userName, String password);
        void forgotPassword(String userEmail);
        void resetPassword(String newPassword, String username);
        void logOut(int userId);

    }
}
