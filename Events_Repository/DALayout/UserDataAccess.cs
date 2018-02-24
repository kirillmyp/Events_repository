namespace Events_Repository.DALayout
{

    using System;
    using System.Data.SqlClient;
    using Models.Interface;

    public class UserDataAccess : IUserDataAccess
    {
        public bool CheckUserToken(int? id)
        {
            if (!id.HasValue)
            {
                return false;
            }

            using(var db = new SqlConnection())
            //send request to DB
            //and need to use user cache to storage token

            return false;
        }

        /// <summary>
        /// регистрация юзера
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns></returns>
        public bool SignUpUser(IUser newUser)
        {
            return false;
        }

        /// <summary>
        /// метод для логирования 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool SignInUser(IUser user)
        {
            if (true)//check password and login
            {
                Authorize();
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="minutes">сколько минут будет активен токен</param>
        /// <returns></returns>
        private bool Authorize(int minutes = 30)
        {
            var token = CreateTemporaryToken();
            if (String.IsNullOrWhiteSpace(token))
            {

            }
            return false;
        }

        /// <summary>
        /// Создать временный токен
        /// </summary>
        /// <returns></returns>
        private string CreateTemporaryToken()
        {
            return "";
        }
    }
}
