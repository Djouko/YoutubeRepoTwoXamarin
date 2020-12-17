using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeRepoTwo.Views.MasterDetail
{
    public class MyMasterDetailPageMasterMenuItem
    {
        public MyMasterDetailPageMasterMenuItem()
        {
            TargetType = typeof(MyMasterDetailPageMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }

        public Type TargetType { get; set; }
    }
}