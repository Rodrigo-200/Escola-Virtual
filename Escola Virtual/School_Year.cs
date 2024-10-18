using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_Virtual
{
    public class School_Year
    {
          private int _year;
          private List<Class> _list_Of_Classes = new List<Class>()
          {
              new Class() { Set_class_name = "Técnico de Gestão e Programação de Sistemas Informáticos", Set_class_acronym = "TGPSI" , Set_AmountOfStudents = 30 },
              new Class() { Set_class_name = "Técnico de Eletrónica Automação e Comando", Set_class_acronym = "TEAC", Set_AmountOfStudents = 12 },
              new Class() { Set_class_name = "Técnico de Gestão", Set_class_acronym = "TG", Set_AmountOfStudents = 15  },
              new Class() { Set_class_name = "técnico de Mecatronica Automóvel", Set_class_acronym = "TMA", Set_AmountOfStudents = 20 }

          };

        #region Propriedades de Get

        public List<Class> Get_List_Of_Classes
        {
            get
            {
                return _list_Of_Classes;
            }
        }


        public int Get_Year
        {
            get
            {
                return _year;
            }
        }

        #endregion

        #region Propriedades de Set

        public List<Class> Set_List_Of_Classes
        {
            set
            {
                 _list_Of_Classes= value;
            }
        }


        public int Set_Year
        {
            set
            {
                 _year = value;
            }
        }

        #endregion


    }
}
