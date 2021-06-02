using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{

    public class Lecture
    {

        private string lectureName;
        private int empId;
        private string lecFaculty;
        private string lecDep;
        private string lecCenter;
        private string lecBuilding;
        private int lecLevel;
        private int lecRank;

        public Lecture(string lectureName, int empId, string lecFaculty, string lecDep, string lecCenter, string lecBuilding, int lecLevel, int lecRank)
        {
            this.lectureName = lectureName;
            this.empId = empId;
            this.lecFaculty = lecFaculty;
            this.lecDep = lecDep;
            this.lecCenter = lecCenter;
            this.lecBuilding = lecBuilding;
            this.lecLevel = lecLevel;
            this.lecRank = lecRank;
        }
        public Lecture()
        {
        }
        public string LectureName
        {
            get
            {
                return this.lectureName;
            }
            set
            {
                this.lectureName = value;
            }
        }
        public int EmpId
        {
            get
            {
                return this.empId;
            }
            set
            {
                this.empId = value;

            }
        }
        public string LecFaculty
        {
            get
            {
                return this.lecFaculty;
            }
            set
            {
                this.lecFaculty = value;
            }
        }
        public string LecDep
        {
            get
            {
                return this.lecDep;
            }
            set
            {
                this.lecDep = value;
            }
        }
        public string LecCenter
        {
            get
            {
                return this.lecCenter;
            }
            set
            {
                this.lecCenter = value;
            }
        }
        public string LecBuilding
        {
            get
            {
                return this.lecBuilding;
            }
            set
            {
                this.lecBuilding = value;
            }
        }
        public int LecLevel
        {
            get
            {
                return this.lecLevel;
            }
            set
            {
                this.lecLevel = value;
            }
        }
        public int LecRank
        {
            get
            {
                return this.lecRank;
            }
            set
            {
                this.lecRank = value;
            }
        }
    }
}


   
