using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Label.bases
{
    public class BindingBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool SetProperty<T>(ref T property,T value, [CallerMemberName]string propertyName = null)
        {
            if(object.Equals(property,value)) return false;
            property = value;
            this.OnPropertyChanged(propertyName);
            return true;
        }
    }
 }
