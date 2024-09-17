using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace StepStyle.WPF.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event EventHandler OnRequestClose;
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void Close()
        {
            OnRequestClose?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
