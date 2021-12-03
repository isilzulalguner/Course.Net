using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_16_login_project
{
    public class User
    {
        //user bizim için bir entity
        int _id;
        string _name, _password, _question, _answer;

        public User(int id, string name, string password, string question, string answer)
        {
            _id = id;
            _name = name;
            _password = password;
            _question = question;
            _answer = answer;
            
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Password { get => _password; set => _password = value; }
        public string Question { get => _question; set => _question = value; }
        public string Answer { get => _answer; set => _answer = value; }
    }
}
