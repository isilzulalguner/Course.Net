using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_16_login_project
{
    public class UserManager
    {
        static UserManager userManager;

        List<User> users = new List<User>() //buradaki typemız User, bu listenin her bir itemi user
        {
            new User(1, "Ali", "123456", "En sevdiğin marka?", "Tesla"),
            new User(2, "Fatma", "123456", "En sevdiğin yemek?", "Spagetti"),
            new User(3, "Zülal", "123456", "En sevdiğin renk?", "Yeşil"),
            new User(4, "Kübra", "123456", "En sevdiğin şehir?", "İstanbul")
        };

        private UserManager()
        {
            // private yaptık ki bunun bir constructorı alınamasın!!!
            //yani bu classtan başka kimse kopya alamasın!!!
            // newleyemesin!!
        }

        public string AddUser(User user) 
        {
            try
            {
                //control methodu

                if (!IsUserComplete(user))
                {
                    return "Kullanıcı eklenemez";
                }
                if (!IsPasswordComplete(user.Password))
                {
                    return "Şifre yeteri kadar güvenli değil";
                }
                
                users.Add(user);
                return user.Name + " olarak başarıyla kaydoldunuz.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }        
        }

        public string UpdatePassword(int userId, string password) 
        {
            try
            {
                if (!IsPasswordComplete(password))
                {
                    return "Şifre yeteri kadar güvenli değil";
                }
                //kontrol methodu
                foreach (User item in users)
                {
                    if (item.Id == userId)
                    {
                        item.Password = password;
                        return "Şifreniz başarıyla güncellendi.";
                    }
                }
                return "Kullanıcı bulunamadı.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool LoginControl(string userName, string password) 
        {
            try
            {
                foreach (var item in users)
                {
                    if (item.Name == userName && item.Password == password) 
                    {
                        return true;
                    }
                    
                }
                return false;

            }
            catch
            {
                return false;
            }
        }

        bool IsUserComplete(User user) 
        {
            if (string.IsNullOrEmpty(user.Name) || string.IsNullOrEmpty(user.Password) || string.IsNullOrEmpty(user.Question) ||string.IsNullOrEmpty(user.Answer) )
            {
                return false;
            }
            return true;
        }

        bool IsPasswordComplete(string password) 
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }
            if (password.Length < 8 ||  password.Contains("1234567"))
            {
                return false;
            }
            return true; 
        }

        public static UserManager GetInstance() //static= classı newlemeden çağırabilsin
        {
            if (userManager == null)
            {
                userManager = new UserManager();//bu classtan obje yarat ve döndür
            }
            return userManager;
        }


    }

}

