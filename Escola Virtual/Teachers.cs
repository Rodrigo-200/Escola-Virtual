using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_Virtual
{
    public class Teachers
    {
        private List<string> _list_Of_Subjects_Teaching = new List<string>();
        private string _name;
        private string _address;
        private string _contact;
        private string _NIF;
        private string _password;
        private string _teacherID;
        private Int64 _classID;
        //chat igual ao aluno



        #region Propriedades de Get
        public List<string> Get_List_Of_Subjects_Teaching
        {
            get
            {
                return _list_Of_Subjects_Teaching;
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
        public string Get_TeacherID
        {
            get
            {
                return _teacherID;
            }
        }

        public Int64 Get_ClassID
        {
            get
            {
                return _classID;
            }
        }

        #endregion

        #region Propriedades de Set
        public List<string> Set_List_Of_Subjects_Teaching
        {
            set
            {
                _list_Of_Subjects_Teaching = value;
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
        public string Set_TeacherID
        {
            set
            {
                _teacherID = value;
            }
        }

        public Int64 Set_ClassID
        {
            set
            {
                _classID = value;
            }
        }

        #endregion


    }
}
