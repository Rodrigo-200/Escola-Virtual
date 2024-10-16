using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_Virtual
{
    public class Change_Request
    {
        private string _userID;
        private List<string> _list_Of_Fields_To_Change = new List<string>();
        private List<string> _list_Of_Changes = new List<string>();

        public string Get_UserID
        {
            get
            {
                return _userID;
            }
        }
        public List<string> Get_List_Of_Fields_To_Change
        {
            get 
            {
                return _list_Of_Fields_To_Change;
            }
        }

        public List<string> Get_List_Of_Changes
        {
            get
            {
                return _list_Of_Changes;
            }
        }

        public string Set_UserID
        {
            set
            {
                _userID = value;
            }
        }
        
        public List<string> Set_List_Of_Fields_To_Change

        {
            set
            {
                _list_Of_Fields_To_Change = value;
            }
        }

        public List<string> Set_List_Of_Changes
        {
            set
            {
                _list_Of_Changes = value;
            }
        }
    }
}
