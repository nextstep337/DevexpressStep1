using DevExpress.XtraDashboardLayout;
using EDU.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonTest
{
    //https://inf.run/fMt6

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //데이터를 조회하는데는 2가지 방식
            //1. datatable 사용하는것
            //2. 객체를 사용합니다.

            DataTable dt = new DataTable();
            dt.Columns.Add("ONE");
            dt.Columns.Add("TWO");

            DataRow dr = dt.NewRow();
            dr["ONE"] = "안녕";
            dr["TWO"] = "홍길동";
            dt.Rows.Add(dr);
            
            dr = dt.NewRow();
            dr["ONE"] = "두번째";
            dr["TWO"] = "김대중";
            dt.Rows.Add(dr);

            // 조회를 하도록 처리
            grdSample.DataSource = dt;
        }

        private void btnObject_Click(object sender, EventArgs e)
        {
            SampleObject s1 = new SampleObject();
            s1.ONE = "객체";
            s1.TWO = "표기처리";

            SampleObject s2 = new SampleObject();
            s2.ONE = "소유";
            s2.TWO = "가수";

            List<SampleObject> lst = new List<SampleObject>();
            lst.Add(s1);
            lst.Add(s2);
            this.grdSample.DataSource = lst;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            DataTable dt = Service.ExecuteDataTable();
        }
    }
}
