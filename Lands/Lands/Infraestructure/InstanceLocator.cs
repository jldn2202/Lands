using System;
using System.Collections.Generic;
using System.Text;

namespace Lands.Infraestructure
{
    using ViewModels;

   
    public class InstanceLocator
    {
        #region Porperties
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
