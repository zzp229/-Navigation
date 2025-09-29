using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kevin的导航.ViewModels
{
    public class Page3ViewModel : PageViewModelBase
    {
        public Page3ViewModel()
        {
            Header = "页面3";
        }

        public string PageMessage { get; set; } = "Hello, Page 3";
    }
}
