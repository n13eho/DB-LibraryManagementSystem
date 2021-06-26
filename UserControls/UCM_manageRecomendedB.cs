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
    public partial class UCM_manageRecomendedB : UserControl
    {
        private userInfo user;
        public UCM_manageRecomendedB(userInfo thUser)
        {
            InitializeComponent();
            user = thUser;
            showAllRec();
        }

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
