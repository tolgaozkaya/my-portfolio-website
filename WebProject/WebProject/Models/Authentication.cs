using System;
namespace WebProject.Models
{
    public class Authentication
    {

        public string ErrorMessage { get; set; }
        public bool authentication(string username, string password)

        {
            if (username == "tolga" && password == "123")
            {
                return true;
            }
            else
            {
                this.ErrorMessage = "Kullanıcı Bulunamadı";
                return false;

            }

        }
    }
}

