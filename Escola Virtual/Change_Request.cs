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
        private List<string> _list_new_content = new List<string>();

        #region Propriedades Get
        public string Get_UserID
        {
            get
            {
                return _userID;
            }
        }
        public List<string> Get_List_New_Content
        {
            get
            {
                return _list_new_content;
            }
        }
        public List<string> Get_List_Of_Fields_To_Change
        {
            get
            {
                return _list_Of_Fields_To_Change;
            }
        }
        #endregion

        #region Propriedades Set
        public string Set_UserID
        {
            set
            {
                _userID = value;
            }
        }

        public List<string> Set_List_New_Content
        {
            set
            {
                _list_new_content = value;
            }
        }

        public List<string> Set_List_Of_Fields_To_Change

        {
            set
            {
                _list_Of_Fields_To_Change = value;
            }
        }
        #endregion
    }
}
