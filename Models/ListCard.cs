using AvaDemo001.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaDemo001.Models
{
    public partial class ListCard : ViewModelBase
    {
        /// <summary>
        /// 标题
        /// </summary>
        [ObservableProperty]
        private string title;

        /// <summary>
        /// 应当为图片的url路径,或者可以写成图标的路径
        /// </summary>
        [ObservableProperty]
        private string imageUrl;

        /// <summary>
        /// 总额
        /// </summary>
        [ObservableProperty]
        private string total;

        /// <summary>
        /// 统计类型
        /// </summary>
        [ObservableProperty]
        private string type;

        /// <summary>
        /// 描述
        /// </summary>
        [ObservableProperty]
        private string description;

        /// <summary>
        /// 用户头像
        /// </summary>
        [ObservableProperty]
        private string userAvatar;

        /// <summary>
        /// 用户名
        /// </summary>
        [ObservableProperty]
        private string userName;

        [ObservableProperty]
        private string date;
    }
}
