using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using 区域导航.Views;

namespace 区域导航.Converters
{
    public class ApplicationPageViewConverter : IValueConverter
    {
        //public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        //{
        //    switch ((ApplicationPage)value)
        //    {
        //        case ApplicationPage.Empty:
        //            return null;
        //        case ApplicationPage.Login:
        //            return new Login();
        //        case ApplicationPage.Home:
        //            return new Home();
        //        default:
        //            throw new ArgumentOutOfRangeException();
        //    }
        //}

        #region 改为缓存的试试

        
        private static readonly Dictionary<ApplicationPage, UserControl> _pageCache = new();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var page = (ApplicationPage)value;

            if (page == ApplicationPage.Empty)
                return null;

            // 如果缓存中已存在，直接返回缓存的实例
            if (_pageCache.TryGetValue(page, out var cachedPage))
            {
                // 可以拦截页面，登录写这里挺好
                //MessageBox.Show("使用缓存页面");
                return cachedPage;
            }
                

            // 创建新实例并缓存
            UserControl newPage = page switch
            {
                ApplicationPage.Login => new Login(),
                ApplicationPage.Home => new Home(),
                _ => throw new ArgumentOutOfRangeException()
            };

            _pageCache[page] = newPage;
            return newPage;
        }

        #endregion

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
