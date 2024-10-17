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
        private string _message;
        private string _name_Of_Field;
        private string _new_content;

        public string Get_UserID
        {
            get
            {
                return _userID;
            }
        }
        public string Get_Message
        {
            get
            {
                return _message;
            }
        }
        public string Get_Name_Of_Field
        {
            get 
            {
                return _name_Of_Field;
            }
        }
        
        public string Get_New_Content
        {
            get 
            {
                return _new_content;
            }
        }

        public string Set_UserID
        {
            set
            {
                _userID = value;
            }
        }
        
        public string Set_Message
        {
            set
            {
                _message = value;
            }
        }
        
        public string Set_Name_Of_Field

        {
            set
            {
                _name_Of_Field = value;
            }
        }
        
        public string Set_New_Content

        {
            set
            {
                _new_content = value;
            }
        }
    }
}
