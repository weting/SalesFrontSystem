using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesFrontSystem
{
    public partial class Form1 : Form
    {

        public static string str_database = @"..\\posdatabase.mbd";    
        public static string str_con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + str_database + ";User Id=admin;Password=";

        static string account = "admin";
        static string password = "1234";

        private OleDbConnection OleDBConn;

        bool test_flag = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDBConn = new OleDbConnection(Form1.str_con);
            if (test_flag == true)
            {
                txtbx_userid.Text = "0001";
                txtbx_account.Text = "admin";
                txtbx_password.Text = "1234";
            }
            else
            {

            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bool flag_check = false;
            string str_userid = "";
            string str_account = "";
            string str_password = "";

            str_userid = txtbx_userid.Text;

            try
            {
                OleDBConn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = OleDBConn;
                string query = "select * from AllShopManager where SaleID='" + str_userid + "'";
                command.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable global_dataTable = new DataTable();
                da.Fill(global_dataTable);
                OleDBConn.Close();

                str_account = global_dataTable.Rows[0]["LoginAccount"].ToString();
                str_password = global_dataTable.Rows[0]["Password"].ToString();


                if (str_account.Equals(txtbx_account.Text) && str_password.Equals(txtbx_password.Text))
                {
                    Form1.ActiveForm.Hide();
                    Form2 form2 = new Form2();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("帳號密碼有誤，請重新輸入");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }

        }
    }
}
