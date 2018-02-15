using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Events_Repository.Data_Access_Layout;
using Events_Repository.Models;

namespace Events_Repository.Business_Access_Layout
{
    public class BusinessAccessLogin
    {
        private DataAccessLogin _dataAccessLogin;

        public BusinessAccessLogin()
        {
            _dataAccessLogin = new DataAccessLogin();
        }

        public BusinessAccessLogin(DataAccessLogin dataAccessLogin)
        {
            _dataAccessLogin = dataAccessLogin;
        }

        public bool CheckAuthorization()
        {
            return false;
        }

        public bool SignUp(User newUser)
        {
            return _dataAccessLogin.SignUpUser(newUser);
        }

        public bool SignIn(User user)
        {
            return _dataAccessLogin.SignInUser(user);
        }

        

    }
}
