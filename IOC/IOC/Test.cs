using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC
{
    public class Test : ITest
    {
        public string Add()
        {
            return "向Mysql数据库添加成功！";
        }
    }
}
