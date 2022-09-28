using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Grade_Save_System
{
    public partial class FrmTeacher : Form
    {
        public FrmTeacher()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=SADAY\SQLEXPRESS;Initial Catalog=DbSchool;Integrated Security=True");
        private void FrmTeacher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbSchoolDataSet.TBLSTUDENT' table. You can move, or remove it, as needed.
            this.tBLSTUDENTTableAdapter.Fill(this.dbSchoolDataSet.TBLSTUDENT);
            conn.Open();
            SqlCommand command5 = new SqlCommand("Select Count(*) From TBLSTUDENT where STATUS=1", conn);
            SqlDataReader dr2= command5.ExecuteReader();
            while (dr2.Read())
            {
                LblPassing.Text = dr2[0].ToString();
            }
            conn.Close();
            conn.Open();
            SqlCommand command6 = new SqlCommand("Select Count(*) From TBLSTUDENT where STATUS=0", conn);
            SqlDataReader dr3 = command6.ExecuteReader();
            while (dr3.Read())
            {
                LblLeftovers.Text = dr3[0].ToString();
            }
            conn.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command2 = new SqlCommand("insert into TBLSTUDENT (STUDENTNUMBER,STUDENTNAME,STUDENTSURNAME) values (@p1,@p2,@p3)", conn);
            command2.Parameters.AddWithValue("@p1", MskNumber.Text);
            command2.Parameters.AddWithValue("@p2", TxtName.Text);
            command2.Parameters.AddWithValue("@p3", TxtSurname.Text);
            command2.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully added!");
            this.tBLSTUDENTTableAdapter.Fill(this.dbSchoolDataSet.TBLSTUDENT);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            MskNumber.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtName.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtExam1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtExam2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtExam3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }
        public string status;
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            double average, e1, e2, e3;
            
            e1 = Convert.ToDouble(TxtExam1.Text);
            e2 = Convert.ToDouble(TxtExam2.Text);
            e3 = Convert.ToDouble(TxtExam3.Text);
            average = (e1 + e2 + e3) / 3;

            if(average >= 50)
            {
                status = "True";
            }
            else
            {
                status = "False";
            }
           
            

            LblAvarage.Text = average.ToString();

            conn.Open();
            SqlCommand command3 = new SqlCommand("Update TBLSTUDENT set EXAM1=@P1,EXAM2=@P2,EXAM3=@P3,AVERAGE=@P4,STATUS=@P5 where STUDENTNUMBER=@P6",conn);
            command3.Parameters.AddWithValue("@P1", TxtExam1.Text);
            command3.Parameters.AddWithValue("@P2", TxtExam2.Text);
            command3.Parameters.AddWithValue("@P3", TxtExam3.Text);
            command3.Parameters.AddWithValue("@P4",decimal.Parse(LblAvarage.Text));
            command3.Parameters.AddWithValue("@P5", status);
            command3.Parameters.AddWithValue("@P6", MskNumber.Text);
            command3.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Update successfully!");
            this.tBLSTUDENTTableAdapter.Fill(this.dbSchoolDataSet.TBLSTUDENT);
        }
        
    }
}
