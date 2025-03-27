using StarBuko.Repositories;
using StarBuko.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuko.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginForm _view;
        private readonly UserRepository _userRepository;

        public LoginPresenter(ILoginForm view)
        {
            _view = view;
            _userRepository = new UserRepository(); 
            _view.OnLoginAttempt += HandleLoginAttempt;
        }

        private void HandleLoginAttempt(object sender, (string username, string password) credentials)
        {
            if (_userRepository.IsValidUser(credentials.username, credentials.password))
            {
                (_view as LoginForm)?.LoginSuccessful(); 
            } else
            {
                _view.ShowLoginError("Invalid credentials."); 
            }
        }
    }
}
