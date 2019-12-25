using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV.ptit.qldsv.model
{
    class StudentInfo
    {
        private string studentId;
        private string fullname;
        private DateTime birthDay;
        private string classId;

        public string StudentId
        {
            get
            {
                return studentId;
            }

            set
            {
                studentId = value;
            }
        }

        public string Fullname
        {
            get
            {
                return fullname;
            }

            set
            {
                fullname = value;
            }
        }

        public DateTime BirthDay
        {
            get
            {
                return birthDay;
            }

            set
            {
                birthDay = value;
            }
        }

        public string ClassId
        {
            get
            {
                return classId;
            }

            set
            {
                classId = value;
            }
        }
    }
}
