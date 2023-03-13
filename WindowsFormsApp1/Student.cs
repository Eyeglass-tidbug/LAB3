using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.CodeDom;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    internal class Student
    {
        private string name;
        private string id;
        private int age;
        private string height;
        private double grade;
        private string major;
        
        public string Name { get{ return name; } }
        public string Id { get { return id; } }
        public double Age { get { return age; } }
        public string Height { get { return height; } }
        public double Grade { get { return grade; } }
        public string Major { get { return major; } }

        //constoctor or something ??
        public Student(string Aname, string Aid, int Abirthyear, string Aheight, double Agrade, string Amajor)
        {
            this.name = Aname;
            this.id = Aid;
            this.age = 2565-Abirthyear;
            this.height = Aheight;
            this.grade = Agrade;
            this.major = Amajor;
        }
        // method ?
    }
}
