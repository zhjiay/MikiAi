using Label.views.startRegion.RegionModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Label.views.startRegion
{
    /// <summary>
    /// WorkSpaceRegion.xaml 的交互逻辑
    /// </summary>
    public partial class WorkSpaceRegion : UserControl
    {
        public WorkSpaceRegion()
        {
            InitializeComponent();
            this.DataContext= this;
        }

        public ObservableCollection<ProjectInfoModel> ProjectInfos { get; set; } = new ObservableCollection<ProjectInfoModel>()
        {
            new ProjectInfoModel("Project1",100,"2023/06/30"),
            new ProjectInfoModel("Project2",98,"2023/06/30"),
            new ProjectInfoModel("Project3",94,"2023/06/30"),
            new ProjectInfoModel("Project4",89,"2023/06/30"),
            new ProjectInfoModel("Project3",94,"2023/06/30"),
            new ProjectInfoModel("Project4",89,"2023/06/30"),
            new ProjectInfoModel("Project3",94,"2023/06/30"),
            new ProjectInfoModel("Project4",89,"2023/06/30"),
            new ProjectInfoModel("Project3",94,"2023/06/30"),
            new ProjectInfoModel("Project3",94,"2023/06/30"),
            new ProjectInfoModel("Project4",89,"2023/06/30"),
            new ProjectInfoModel("Project4",89,"2023/06/30"),
            new ProjectInfoModel("Project5",75,"2023/07/01"),
        };

        private void xAddProject_Click(object sender, RoutedEventArgs e)
        {
            Button btn=(Button)sender;
            Console.WriteLine("test");
            Console.WriteLine(btn.Background.ToString());
        }

        private void xEditProject_Click(object sender, RoutedEventArgs e)
        {

        }

        private void xWorkProject_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void ListView_MouseWheel(object sender, MouseWheelEventArgs e)
        {

        }
    }
}
