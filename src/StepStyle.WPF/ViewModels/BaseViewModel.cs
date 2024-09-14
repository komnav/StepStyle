using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace StepStyle.WPF.ViewModels
{
    public class BaseViewModel
    {
        public event EventHandler OnRequestClose;

        protected void Close()
        {
            OnRequestClose?.Invoke(this, EventArgs.Empty);
        }
    }
}
