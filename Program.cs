using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_WCF.ServiceReference1;
using Test_WCF.ServiceReference2;
using System.Data.SqlClient;
using System.Data;

namespace Test_WCF
{
    class Program 
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            //UserClient user = new UserClient();
            //string value = user.DoWork(10, 12);
            //string getvalue = value;
            //Console.WriteLine(getvalue);
            Login();
        }
        public static bool Login() {
            
            UserClient userClient = new UserClient();
            bool Loginint = false;
            string Userinfo = userClient.Login("张三", "2213");
            if (!Userinfo.Equals("登录失败"))
            {
                Loginint = true;
                Console.WriteLine("登录成功");
                Console.ReadLine();
            }
            else {
                Console.WriteLine("登录失败");
                Console.ReadLine();
            }
            userClient.Close();
            return Loginint;
        }

        public  static async Task Succe() {
            IpublicapiClient ipublicapiClient = new IpublicapiClient();
            string value = ipublicapiClient.DoWork();
            Console.WriteLine(value);
            Console.ReadLine();
            await succ();
        }

        public static async Task succ() {
            await Task.Run(() =>
            {
                IpublicapiClient ipublicapiClient = new IpublicapiClient();
                string value = ipublicapiClient.DoWork();
                Console.WriteLine(value);
                Console.ReadLine();
                ipublicapiClient.Close();
                return value;
            });
        }

    }
}
