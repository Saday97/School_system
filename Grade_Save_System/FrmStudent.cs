using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Grade_Save_System
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }
        public string number;
        

        SqlConnection conn = new SqlConnection(@"Data Source=SADAY\SQLEXPRESS;Initial Catalog=DbSchool;Integrated Security=True");
        private void FrmStudent_Load(object sender, EventArgs e)
        {
            LblNumber.Text = number;

            conn.Open();
            SqlCommand command1 = new SqlCommand("Select * From TBLSTUDENT Where STUDENTNUMBER=@p1",conn);
            command1.Parameters.AddWithValue("@p1",number);
            SqlDataReader dr = command1.ExecuteReader();
            while (dr.Read())
            {
                LblName.Text = dr[2].ToString() + " " + dr[3].ToString();
                LblExam1.Text = dr[4].ToString();
                LblExam2.Text = dr[5].ToString();
                LblExam3.Text = dr[6].ToString();
                LblAvarage.Text = dr[7].ToString();
                LblStatus.Text = dr[8].ToString();
            }
            conn.Close();
        }

        private void LblStatus_Click(object sender, EventArgs e)
        {
       
        }
    }
}
