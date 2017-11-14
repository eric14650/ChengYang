using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // streamreader and streamwriter

namespace WindowsFormsApplication1
{
    public partial class f_main : Form
    {
        
        // dataset and datatable
        public static DataSet ds_service0 = new DataSet();            // 維修記錄的Dataset
        public static DataTable dt_service0 = new DataTable();        // 維修記錄的DataTable
        public static DataSet ds_client0 = new DataSet();             // 客戶資料的Dataset
        public static DataTable dt_client0 = new DataTable();         // 客戶資料的DataTable
        public static DataSet ds_factory0 = new DataSet();            // 廠商資料的Dataset
        public static DataTable dt_factory0 = new DataTable();        // 廠商資料的DataTable
        public static DataSet ds_employee0 = new DataSet();           // 員工資料的Dataset
        public static DataTable dt_employee0 = new DataTable();       // 員工資料的DataTable
        public static DataSet ds_purchase0 = new DataSet();           // 進貨記錄的Dataset
        public static DataTable dt_purchase0 = new DataTable();       // 進貨記錄的DataTable
        public static DataSet ds_components0 = new DataSet();         // 零件的Dataset
        public static DataTable dt_components0 = new DataTable();     // 零件的DataTable
        public static DataSet ds_cars0 = new DataSet();               // 車種的Dataset
        public static DataTable dt_cars0 = new DataTable();           // 車種的DataTable
        
        public f_main()
        {
            InitializeComponent();

            // 讀檔
            FileStream fs_client = new FileStream(System.Environment.CurrentDirectory + "\\客戶資料.csv", FileMode.Open);
            StreamReader sr_client = new StreamReader(fs_client, Encoding.Default);

            // 宣告新的一行
            DataRow dr = null;

            string string1 = "";
            int counter = 1;
            char[] delimiterChars = new char[] { ' ', ',', '\t' };
            // 開始讀檔
            while ((string1 = sr_client.ReadLine()) != null)
            {
                if (counter == 1)
                {
                    string[] split1 = string1.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

                    // 宣告dataTable
                    dt_client0 = ds_client0.Tables.Add("client");

                    // 增加行
                    for (int i = 0; i <= split1.Length - 1; i++)
                        dt_client0.Columns.Add(split1[i], Type.GetType("System.String"));

                    counter++;
                }
                else
                {
                    string[] split1 = string1.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

                    dr = dt_client0.NewRow();
                    for (int i = 0; i <= split1.Length - 1; i++)
                        dr[i] = split1[i].ToString();
                    dt_client0.Rows.Add(dr);
                }
            }
            sr_client.Close();
        }

        private void button_入廠建檔_Click(object sender, EventArgs e)
        {
            f_01 f1 = new f_01();      //產生f_01的物件，才可以使用它所提供的Method
            f1.ShowDialog(this);       //設定f_01為f_main的上層，並開啟f_01視窗。由於在f_main的程式碼內使用this，所以this為f_main的物件本身
            
            if (f1.DialogResult == System.Windows.Forms.DialogResult.OK)             // 確認進廠
            {
                f1.Close();
                
            }
            else if (f1.DialogResult == System.Windows.Forms.DialogResult.Cancel)    // 取消進廠
            {
                f1.Close();
                
            }
        }

        private void button_離開_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
