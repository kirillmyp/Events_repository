namespace Events_Repository.DALayout
{
    using Models.Interface;

    public interface IUserDataAccess
    {
        bool CheckUserToken(int? id);

        bool SignUpUser(IUser newUser);

        bool SignInUser(IUser user);

        //bool Authorize(int minutes = 30);

        //string CreateTemporaryToken();
    }
}
