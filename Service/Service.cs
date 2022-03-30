using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class LoginService
    {
        public static bool Login(string login, string password)
        {
            if (!(login == "admin"))
                return "Неверный логин";

            if (!(password == "admin"))
                return "Неверный пароль";

            else
                return "Вход выполнен";
        }
    }
}
