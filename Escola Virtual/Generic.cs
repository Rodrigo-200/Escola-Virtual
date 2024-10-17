using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_Virtual
{
    class Generic
    {
        public static List<School_Year> _list_Of_School_Years = new List<School_Year>()
        {
            new School_Year { Set_Year = 5},
            new School_Year { Set_Year = 6}
        };

        public static List<Teachers> _listOf_Teachers = new List<Teachers>();

        public static List<Change_Request> _list_Of_Changes = new List<Change_Request>();

        public static List<Chat> _List_Of_Chats = new List<Chat>();

        //public static List<Int64> _list_Of_Ids = new List<Int64>();

        public static Student CurrentStudent = new Student();
        public static Teachers CurrentTeacher = new Teachers();

        public static Int64 StudentID;
        public static Int64 TeacherID;


    }
}
