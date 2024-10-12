using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_Virtual
{
    public class Subject
    {
        private string _name;
        private int _subject_number;
        private string _subject_acronym;
        private Int64 _classID;

        #region Propriedades de Get

        public string Get_name
        {
            get
            {
                return _name;
            }
        }

        public int Get_subject_number
        {
            get
            {
                return _subject_number;
            }
        }

        public string Get_subject_acronym
        {
            get
            {
                return _subject_acronym;
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
        public string Set_name
        {
            set
            {
                _name = value;
            }
        }

        public int Set_subject_number
        {
            set
            {
                _subject_number = value;
            }
        }

        public string Set_subject_acronym
        {
            set
            {
                _subject_acronym = value;
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
