using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace LibraryManagementSystem.UserControls
{
    /*************************************************************************
    【类名】             UCM_manageRecomendedB
    【功能】             显示已推荐书单
    【接口说明】         showAllRec()
    【开发者及日期】      Algernon, 2021/06/19
    【版本】             V1.0
    *************************************************************************/
    public partial class UCM_manageRecomendedB : UserControl
    {
        private userInfo user;


        /*************************************************************************
        【函数名称】       UCM_manageRecomendedB
        【函数功能】       类构造函数
        【参数】           userInfo theUser
        【访问变量】       无
        【返回值】         无
        【使用情况】       调用InitializeComponent()、showAllRec()；被FormDBoard new新窗体时使用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        public UCM_manageRecomendedB(userInfo thUser)
        {
            InitializeComponent();
            user = thUser;
            showAllRec();
        }


        /*************************************************************************
        【函数名称】       showAllRec
        【函数功能】       通过信息陈列用户推荐的书目
        【参数】           无
        【访问变量】       无
        【返回值】         无
        【使用情况】       无调用函数；被构造函数调用调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        private void showAllRec()
        {
            dgv_manageRecom.Rows.Clear();
            // 连接数据库
            OdbcConnection con = new OdbcConnection(user.conString);
            con.Open();
            string sql = "select recommended_books.uno, uname, rc_bname, rc_author, rc_pHouse, rc_date from recommended_books, user where recommended_books.uno = user.uno;";
            OdbcCommand com = new OdbcCommand(sql, con);
            OdbcDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                int index = dgv_manageRecom.Rows.Add();
                for (int i = 0; i < reader.FieldCount; i++)
                {// 填进去
                    dgv_manageRecom.Rows[index].Cells[i].Value = Convert.ToString(reader[i]);
                }
            }
        }
    }
}
