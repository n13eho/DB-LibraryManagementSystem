using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    /*************************************************************************
    【类名】             connectDB
    【功能】             保存连接DB的语句
    【接口说明】           SqlInject(string s)
    【开发者及日期】       Algernon, 2021/06/19
    【版本】              1.0
    *************************************************************************/
    class connectDB
    {
        //public static string conString = "DSN=_library;UID=root;PWD=123456"; //ODBC的数据源名
        public static string conString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=1.15.111.142;Port=3306;Uid=root;Pwd=QWer1234/;Database=2018302359_library;"; //ODBC的数据源名
        
        public static bool SqlInject(string s)
        {//检测是否发生sql注入，发生则返回true
            //主要是检测这个字串中有没有‘-- ’
            if (s.Contains(" -- ")) return true;
            else return false;
        }

    }
}
