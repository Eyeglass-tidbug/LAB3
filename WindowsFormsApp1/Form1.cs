using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Student> _students = new List<Student>();
        List<double> _geade = new List<double>();
        //double Hightscore = 0;
        //double Lowscore = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Createbutton_Click(object sender, EventArgs e)
        {
            if (NameTextbox.Text=="" | StudenID.Text=="" | branchTextbox.Text=="" | heightTextbox.Text=="" | gradeTextbox.Text=="" | BirthyearTextbox.Text=="")
            {

            }
            else
            {
                string stname = this.NameTextbox.Text;
                string stid = this.StudenID.Text;
                string stheight = this.heightTextbox.Text;
                string stbranch = this.branchTextbox.Text;
                string stbirthyear = this.BirthyearTextbox.Text;
                int c_year = Int32.Parse(stbirthyear);
                string stgrade = this.gradeTextbox.Text;
                double c_grade = Int32.Parse(stgrade);

                Student student = new Student(stname, stid, c_year, stheight, c_grade, stbranch);
                //student.Hightscore();
                this._students.Add(student);
                this._geade.Add(c_grade);
                //double count = 0;
                //count += 1;
                Int32 Total = _students.Count;
                double maxGrade = _geade.Max();
                double minGrade = _geade.Min();
                

                this.Hscroe.Text = maxGrade.ToString();
                this.Lscore.Text = minGrade.ToString();
                this.total_input.Text = Total.ToString();
                
                NameTextbox.Text = ""; StudenID.Text = "";
                branchTextbox.Text = ""; heightTextbox.Text = "";
                gradeTextbox.Text = ""; BirthyearTextbox.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.ClassScore.Visible==true) { this.ClassScore.Visible = false;}
            else { this.ClassScore.Visible = true;}
        }
    }
}
