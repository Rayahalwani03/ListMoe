using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp7
{
    public class StudentClass

    {
        public StudentClass(int ID, string Name, string Department)
        {
            this.ID = ID;
            this.Name = Name;
            this.Department = Department;

        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Text1 { get; }
        public string Text2 { get; }


    }
}