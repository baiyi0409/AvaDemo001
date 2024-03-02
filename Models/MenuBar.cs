using AvaDemo001.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;
using Material.Icons;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AvaDemo001.Models
{
    public partial class MenuBar : ViewModelBase
    {
        /// <summary>
        /// 标题
        /// </summary>
        [ObservableProperty]
        private string displayName;

        /// <summary>
        /// 图标
        /// </summary>
        [ObservableProperty] 
        private MaterialIconKind icon;

        /// <summary>
        /// 排序
        /// </summary>
        [ObservableProperty] 
        private int index;
    }
}
