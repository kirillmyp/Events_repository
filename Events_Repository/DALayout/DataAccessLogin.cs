using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Events_Repository.Models;

namespace Events_Repository.Data_Access_Layout
{
    public class DataAccessLogin
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
        public bool SignUpUser(User newUser)
        {
            return false;
        }

        /// <summary>
        /// метод для логирования 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool SignInUser(User user)
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
