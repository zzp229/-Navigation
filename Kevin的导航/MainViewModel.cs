using Kevin的导航.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kevin的导航
{
    public class MainViewModel : ViewModelBase
    {
        public List<ViewModelBase> ViewModels { get; set; }
        public MainViewModel(Page1ViewModel p1, Page2ViewModel p2, Page3ViewModel p3)
        {
            ViewModels = new List<ViewModelBase>() { p1, p2, p3 };
        }
    }
}
