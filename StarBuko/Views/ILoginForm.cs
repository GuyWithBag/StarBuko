using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuko.Views
{
    public interface ILoginForm
    {
        event EventHandler<(string username, string password)> OnLoginAttempt;
        void ShowLoginError(string message); 
    }
}
