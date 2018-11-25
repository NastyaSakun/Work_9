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
            string_.DeleteEv+=Delete;
            string_.DelPEv += DelP;
            string_.AddEv += Add;
            string_.ReplaceEv += Replace;

            string_.Add("nast_t!  ;lolkek.");
            Console.WriteLine(string_.ToString());





        }

        private static void Show_Message(string message)
            {
                Console.WriteLine(message);
            }

        public static void Delete(string user)
        {
            user.Replace(',', '_');
            user.Replace('.', '_');
            user.Replace(';', '_');
            user.Replace(':', '_');
            user.Replace('!', '_');
            user.Replace('?', '_');
        }

        public static void Add(string user)
        {
            user.Insert(2, "_");
        }

        public static void Replace(string user)
        {
            user.ToUpper();
        }

        public static void DelP(string user)
        {
            user.Replace(' ', '_');
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
            public event Action<string> DeleteEv;
            public event Action<string> AddEv;
            public event Action<string> ReplaceEv;
            public event Action<string> DelPEv;


            public void Delete(string user)
            {
                DeleteEv?.Invoke(user);
            }

            public void Add(string user)
            {
                AddEv?.Invoke(user);
            }

            public void Replace(string user)
            {
                ReplaceEv?.Invoke(user);
            }

            public void DelP(string user)
            {
                DelPEv?.Invoke(user);
            }

            
           // public override string ToString()
            //{
              //  return .ToString();
            //}
        }


    }
}
