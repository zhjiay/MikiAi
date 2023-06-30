using Label.bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Label.views.startRegion.RegionModel
{
    public class ProjectInfoModel:BindingBase
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value, nameof(Title)); }
        }

        private int processNumber;
        public int ProcessNumber
        {
            get { return processNumber; }
            set { SetProperty(ref processNumber, value, nameof(ProcessNumber));}
        }

        private string creatTime;
        public string CreatTime
        {
            get { return creatTime; }
            set { SetProperty(ref creatTime, value, nameof(CreatTime)); }
        }

        public ProjectInfoModel()
        {

        }
        public ProjectInfoModel(string t,int i,string ctime)
        {
            Title= t;
            ProcessNumber= i;
            CreatTime= ctime;
        }

    }
}
