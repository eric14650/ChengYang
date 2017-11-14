using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class f_01 : Form
    {
        // dataset and datatable
        DataSet ds_client01 = new DataSet();             // 客戶資料的Dataset
        DataTable dt_client01 = new DataTable();         // 客戶資料的DataTable
        DataSet ds_service01 = new DataSet();            // 維修記錄的Dataset
        DataTable dt_service01 = new DataTable();        // 維修記錄的DataTable
                
        public f_01()
        {
            InitializeComponent();

            // 把table帶過來
            ds_client01 = f_main.ds_client0;
            dt_client01 = f_main.dt_client0;
            ds_service01 = f_main.ds_service0;
            dt_service01 = f_main.dt_service0;

            textBox2.Text = System.DateTime.Now.Year.ToString() + "/" + System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Day.ToString();
            if (Convert.ToInt16(System.DateTime.Now.Hour.ToString()) >= 12)
                textBox3.Text = "下午" + System.DateTime.Now.Hour.ToString() + ":" + System.DateTime.Now.Minute.ToString();
            else
                textBox3.Text = "上午" + System.DateTime.Now.Hour.ToString() + ":" + System.DateTime.Now.Minute.ToString();

            radioButton1.Checked = true;

            button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        // 輸入車牌號碼後按Enter搜尋
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                dt_client01.DefaultView.RowFilter = "車牌號碼='" + textBox1.Text.ToUpper() + "'";                
                dataGridView1.DataSource = dt_client01;
                if (dataGridView1.Rows.Count==1)
                {
                    // 新增客戶資料
                }
            }
        }

        // 選擇維修紀錄後列出該次工作單
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView1.Rows.IndexOf(dataGridView1.CurrentRow);
            Console.WriteLine(dataGridView1[0, selectedRowCount].Value.ToString());

        }      
    }
}
