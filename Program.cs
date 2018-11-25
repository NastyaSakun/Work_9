using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work9
{
    class Program
    {
        static void Main(string[] args)
        {

            User linux = new User();
            linux.Work += Show_Message;
            linux.Method_L();
            User windows = new User();
            windows.Upgrade += Show_Message;
            windows.Method_W();


            String_ string_ = new String_();
            string_.DeleteEv += string_.Delete;
            string_.DelPEv += string_.DelP;
            string_.InsertEv += string_.Insert;
            string_.ReplaceEv += string_.Replace;
            string_.AllFunc += string_.Delete;
            string_.AllFunc += string_.DelP;
            string_.AllFunc += string_.Insert;
            string_.AllFunc += string_.Replace;
            string_.Add("nast_t! ;lolkek. chebyrek");
            Console.WriteLine(string_.AllFunc.Invoke());





        }

        private static void Show_Message(string message)
            {
                Console.WriteLine(message);
            }


       


        class User
        {
            public delegate void ForUser(string message);
            public event ForUser Work;
            public event ForUser Upgrade;
                      
            public void Method_L()
            {
                Work.Invoke("\0Работаем");
            }

            public void Method_W()
            {               
                Upgrade.Invoke("\0Обновление");
            }

        }

        class String_
        {
            public Func<string> DeleteEv;
            public Func<string> InsertEv;
            public Func<string> ReplaceEv;
            public Func<string> DelPEv;
            public Func<string> AllFunc;

            private string _name;

            public string Delete()
            {
                return _name=_name.Replace(',', '_').Replace('.', '_').Replace(';', '_').Replace(':', '_').Replace('!', '_').Replace('?', '_');
            }

            public void Add(string user)
            {
                _name = user;
            }

            public string Insert()
            {
                return _name=_name.Insert(2, "+");
            }

            public string Replace()
            {
               return _name.ToUpper();
            }

            public string DelP()
            {
                return _name=_name.Replace(' ', '_');
            }

            public override string ToString()
            {
                return this._name;
            }
        }


    }
}
