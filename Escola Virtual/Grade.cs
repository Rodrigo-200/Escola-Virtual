using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_Virtual
{
    public class Grade
    {
        private Subject _subject = new Subject();
        private int _grade;

        #region Propriedades de Get

        public Subject Get_subject
        {
            get
            {
                return _subject;
            }
        }

        public int Get_Grade
        {
            get
            {
                return _grade;
            }
        }

        #endregion

        #region Propriedades de Set

        public Subject Set_subject
        {
            set
            {
                _subject = value;
            }
        }

        public int Set_Grade
        {
            set
            {
                _grade = value;
            }
        }
        #endregion


    }
}
