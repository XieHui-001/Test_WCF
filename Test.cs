
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_WCF
{
    public class Test
    {

        public static Test Instance = null;
        public Test() {

            Instance = this;
        }
        public  string  PubTest() {
            string sg = "123";
            return sg == null? "Success":"Not";
        }

    }
}
