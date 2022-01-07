using System;
using System.Collections.Generic;
using System.Text;

namespace CursoOnline.Entities
{
    class Student
    {
        public int Cod { get; set; }

        public override int GetHashCode()
        {
            return Cod.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Student))
            {
                return false;
            }
            Student student = obj as Student;
            return Cod.Equals(student.Cod);
        }
    }
}
