using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Label.views.startRegion;

namespace Label.views
{
    /// <summary>
    /// StartView.xaml 的交互逻辑
    /// </summary>
    public partial class StartView : Window,INotifyPropertyChanged
    {
        public StartView()
        {
            InitializeComponent();

            
            this.DataContext = this;
            CurrentView = new WorkSpaceRegion();
        }
        private object currentView;

        #region notify property changed
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public bool SetProperty(ref object property,object value, [CallerMemberName] string propertyName = null)
        {
            if (object.Equals(property, value)) return false;
            property = value;
            this.OnPropertyChanged(propertyName);
            return true;
        }
        #endregion
        public object CurrentView
        {
            get { return currentView; }
            set { SetProperty(ref currentView, value,nameof(CurrentView)); }
        }

        private void Click_Navigate(object sender, RoutedEventArgs e)
        {
            RadioButton btn=(RadioButton)sender;
            if(int.TryParse(btn.CommandParameter.ToString(), out int id))
            {
                switch(id)
                {
                    case 0:
                        CurrentView=new SettingRegion();
                        break;
                    case 1:
                        CurrentView=new WorkSpaceRegion();
                        break;
                    case 6:
                        CurrentView=new ImageToolRegion();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
