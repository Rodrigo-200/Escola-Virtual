using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_Virtual
{
    public class Student
    {
        private List<Grade> _List_Of_Grades = new List<Grade>();
        private List<string> _History = new List<string>();
        private string _name;
        private string _address;
        private string _contact;
        private string _NIF;
        private string _password;
        private string _studentID;
        private int _saldo;
        private string _className;
        
        //lista de chat (classe - chat (ainda necessario criar esta classe) ) - Para guardar mensagens

        #region Propriedades de Set
        public List<Grade> Get_List_Of_Grades
        {
            get
            {
                return _List_Of_Grades;
            }
        }

        public string Get_Name
        {
            get
            {
                return _name;
            }
        }
        public string Get_Address
        {
            get
            {
                return _address;
            }
        }
        public string Get_Contact
        {
            get
            {
                return _contact;
            }
        }
        public string Get_NIF
        {
            get
            {
                return _NIF;
            }
        }
        public string Get_password
        {
            get
            {
                return _password;
            }
        }
        public string Get_studentID
        {
            get
            {
                return _studentID;
            }
        }
        public int Get_saldo
        {
            get
            {
                return _saldo;
            }
        }

        public string Get_ClassName
        {
            get
            {
                return _className;
            }
        }

        public List<string> Get_History
        {
            get
            {
                return _History;
            }
        }

        #endregion

        #region Propriedades de Set
        public List<Grade> Set_List_Of_Grades
        {
            set
            {
                _List_Of_Grades = value;
            }
        }
        public string Set_Name
        {
            set
            {
                _name = value;
            }
        }
        public string Set_Address
        {
            set
            {
                _address = value;
            }
        }
        public string Set_Contact
        {
            set
            {
                _contact = value;
            }
        }
        public string Set_NIF
        {
            set
            {
                _NIF = value;
            }
        }
        public string Set_Password
        {
            set
            {
                _password = value;
            }
        }
        public string Set_StudentID
        {
            set
            {
                _studentID = value;
            }
        }
        public int Set_saldo
        {
            set
            {
               _saldo = value;
            }
        }

        public string Set_ClassName
        {
            set
            {
                _className = value;
            }
        }

        public List<string> Set_History
        {
            set
            {
                _History = value;
            }
        }

        #endregion


    }
}
