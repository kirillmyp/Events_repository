namespace Events_Repository.BALayout
{
    using DALayout;
    using Models;

    public class UserBusinessAccess : IUserBusinessAccess
    {
        private IUserDataAccess _userDataAccess;

        public UserBusinessAccess(IUserDataAccess userDataAccess)
        {
            _userDataAccess = userDataAccess;
        }

        public UserBusinessAccess(UserDataAccess userDataAccess)
        {
            _userDataAccess = userDataAccess;
        }

        public bool CheckAuthorization()
        {
            return false;
        }

        public bool SignUp(User newUser)
        {
            return _userDataAccess.SignUpUser(newUser);
        }

        public bool SignIn(User user)
        {
            return _userDataAccess.SignInUser(user);
        }
    }
}
