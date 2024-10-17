using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_Virtual
{
    public class Chat
    {
        private string _message;
        private string _origin;
        private string _destinatary;
        private bool _isRead;

        #region Propriedades de Get
        public string Get_Message
        {
            get
            { 
                return _message; 
            }
        }

        public string Get_origin
        {
            get
            {
                return _origin;
            }
        }

        public string Get_destinatary
        {
            get
            {
                return _destinatary;
            }
        }

        public bool Get_isRead
        {
            get
            {
                return _isRead;
            }
        }
        #endregion

        #region Propriedades de Set
        public string Set_Message
        {
            set
            {
                _message = value;
            }
        }

        public string Set_origin
        {
            set
            {
                _origin = value;
            }
        }

        public string Set_destinatary
        {
            set
            {
                _destinatary = value;
            }
        }

        public bool Set_isRead
        {
            set
            {
                _isRead = value;
            }
        }
        #endregion

    }
}
