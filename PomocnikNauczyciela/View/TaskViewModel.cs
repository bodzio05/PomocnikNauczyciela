using PomocnikNauczyciela.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomocnikNauczyciela.View
{
    public class TaskViewModel: BaseViewModel
    {
        #region Properties
        private int myProperty;
        public int MyProperty
        {
            get { return myProperty; }
            set
            {
                SetProperty(ref myProperty, value);
            }
        }
        #endregion

            #region Constructor
        public TaskViewModel()
        {

        }
        #endregion

        #region Methods
        #endregion
    }
}
