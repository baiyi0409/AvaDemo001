using AvaDemo001.Models;
using Avalonia.Collections;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Material.Icons;
using System.Linq;
using CommunityToolkit.Mvvm.Input;
using Avalonia.Controls;
using System;
using System.Reflection;

namespace AvaDemo001.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            CreatMenu();
        }

        [ObservableProperty]
        private ObservableCollection<MenuBar> menuBars;

        private void CreatMenu()
        {
            MenuBars = new ObservableCollection<MenuBar>();
            MenuBars.Add(new MenuBar { DisplayName = "Dashboard", Icon = MaterialIconKind.ViewDashboard, Index = 0 });
            MenuBars.Add(new MenuBar { DisplayName = "Inbox", Icon = MaterialIconKind.Inbox, Index = 1 });
            MenuBars.Add(new MenuBar { DisplayName = "Analytics", Icon = MaterialIconKind.ChartArc, Index = 2 });
            MenuBars.Add(new MenuBar { DisplayName = "Contacts", Icon = MaterialIconKind.AccountMultiple, Index = 3 });
            MenuBars.Add(new MenuBar { DisplayName = "Projects", Icon = MaterialIconKind.ProjectorScreenVariantOutline, Index = 4 });
            //对导航菜单进行排序
            MenuBars = new ObservableCollection<MenuBar>(MenuBars.OrderBy(m => m.Index));
        }

        /// <summary>
        /// 用于右侧界面显示
        /// </summary>
        [ObservableProperty]
        private object content;

        [RelayCommand]
        void Navigate(MenuBar item)
        {
            if (item == null || string.IsNullOrWhiteSpace(item.DisplayName))
                return;
            //1.获取当前的命名空间
            string nameSpace = MethodBase.GetCurrentMethod().DeclaringType.Namespace + ".";
            //string fullName = MethodBase.GetCurrentMethod().DeclaringType.FullName;  //获取命名空间+类名
            //string name = MethodBase.GetCurrentMethod().DeclaringType.Name;  //获取类名
            if (!string.IsNullOrWhiteSpace(nameSpace.Trim('.')))
            {
                //2.将命名空间转成View
                var name = nameSpace.Replace("ViewModel", "View", StringComparison.Ordinal);
                //3.name + displayName 就是需要实例化的类型
                var view = name + item.DisplayName + "View";
                var viewType = Type.GetType(view);
                if (viewType is null) return;
                //4.实例化view
                var control = (Control)Activator.CreateInstance(viewType)!;
                //5.实例化viewmodel
                var viewModel = nameSpace + item.DisplayName + "ViewModel";
                var viewModelType = Type.GetType(viewModel);
                if (viewModelType != null) 
                {
                    //注意:这里默认使用的类型是ViewModelBase，所以每个ViewModel应该继承于ViewModelBase
                    var dataContext = (ViewModelBase)Activator.CreateInstance(viewModelType)!;
                    //6.设置联系上下文
                    control.DataContext = dataContext;
                };
                // 设置 Content
                Content = control;
            }
        }
    }
}
