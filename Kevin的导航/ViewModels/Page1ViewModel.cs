using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kevin的导航.ViewModels
{
    public class Page1ViewModel : PageViewModelBase
    {
        public Page1ViewModel()
        {
            Header = "页面1";
        }

        public string PageMessage { get; set; } = "Hello, Page 1";
    }


}
