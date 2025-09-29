using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kevin的导航.ViewModels
{
    public class Page2ViewModel : PageViewModelBase
    {
        public Page2ViewModel()
        {
            Header = "页面2";
        }

        public string PageMessage { get; set; } = "Hello, Page 2";
    }
}
