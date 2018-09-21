

namespace Lands.ViewModels
{
    using System.Windows.Input;

    public class LoginViewModel
    {
        #region Properties
        public string Email
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        public bool IsRunnning
        {
            get;
            set;
        }
        public bool IsRememberd
        {
            get;
            set;
        }


        #endregion

        #region Constructors
        public LoginViewModel()
            {
            this.IsRememberd = true;
            }
        #endregion



        #region Commands
        public ICommand LoginCommand
        {
            get;
            set;
        }
        #endregion

    }
}
