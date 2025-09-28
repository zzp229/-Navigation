using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using 区域导航.ViewModels;

namespace 区域导航.Views
{
    public abstract class BasePage<VM> : UserControl where VM : ViewModelBase, new()
    {
        public BasePage()
        {
            DataContext = new VM();
        }
    }
}
