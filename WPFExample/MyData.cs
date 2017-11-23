using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFExample
{
    public class MyData : INotifyPropertyChanged
    {
        private string _user;
        public bool IsLecturer { get; set; }
        private string _password;

        #region Properties
        public string User
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("User"));
                }
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Password"));
                }
            }
        }
        #endregion

        public override string ToString()
        {
            return string.Format("First name: {0}, Last name: {1}, Is lecturer: {2}",
              FirstName, LastName, IsLecturer);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
