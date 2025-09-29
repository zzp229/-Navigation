using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kevin的导航
{
    public abstract class PageViewModelBase : ViewModelBase
    {
        public string Header { get; set; }
    }

    public class Page1ViewModel : PageViewModelBase
    {
        public Page1ViewModel()
        {
            Header = "页面1";
        }

        public string PageMessage { get; set; } = "Hello, Page 1";
    }

    public class Page2ViewModel : PageViewModelBase
    {
        public Page2ViewModel()
        {
            Header = "页面2";
        }

        public string PageMessage { get; set; } = "Hello, Page 2";
    }

    public class Page3ViewModel : PageViewModelBase
    {
        public Page3ViewModel()
        {
            Header = "页面3";
        }

        public string PageMessage { get; set; } = "Hello, Page 3";
    }
}
