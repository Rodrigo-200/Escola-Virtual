using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_Virtual
{
    public class Class
    {
        private List<Student> _List_Of_Student = new List<Student>();
        private List<Subject> _List_Of_Subject = new List<Subject>()
        {
            new Subject() { Set_name = "Área de Integração", Set_subject_acronym = "AI", Set_subject_number = 600},
            new Subject() { Set_name = "Matemática", Set_subject_acronym = "Mat", Set_subject_number = 600},
            new Subject() { Set_name = "Português", Set_subject_acronym = "PT", Set_subject_number = 600},
            new Subject() { Set_name = "Inglês", Set_subject_acronym = "ING", Set_subject_number = 600}
        };
        private string _class_name;
        private string _class_acronym;
        private int _classID;
        private int _school_year;

        #region Propriedades de Get
        public List<Student> Get_List_Of_Student
        {
            get
            {
                return _List_Of_Student;
            }
        }

        public List<Subject> Get_List_Of_Subject
        {
            get
            {
                return _List_Of_Subject;
            }
        }

        public string Get_class_name
        {
            get
            {
                return _class_name;
            }
        }

        public string Get_class_acronym
        {
            get
            {
                return _class_acronym;
            }
        }

        public int Get_ClassID
        {
            get
            {
                return _classID;
            }
        }

        public int Get_school_year
        {
            get
            {
                return _school_year;
            }
        }



        #endregion

        #region Propriedades de Set
        public List<Student> Set_List_Of_Student
        {
            set
            {
                _List_Of_Student = value;
            }
        }

        public List<Subject> Set_List_Of_Subject
        {
            set
            {
                _List_Of_Subject = value;
            }
        }

        public string Set_class_name
        {
            set
            {
                _class_name = value;
            }
        }

        public string Set_class_acronym
        {
            set
            {
                _class_acronym = value;
            }
        }

        public int Set_ClassID
        {
            set
            {
                _classID = value;
            }
        }

        public int Set_school_year
        {
            set
            {
                 _school_year=value;
            }
        }

        #endregion



    }
}
