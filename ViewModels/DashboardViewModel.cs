using AvaDemo001.Models;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using Material.Icons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaDemo001.ViewModels
{
    public partial class DashboardViewModel : ViewModelBase
    {
        public DashboardViewModel()
        {
            CreatList();
        }

        [ObservableProperty]
        private ObservableCollection<ListCard> listCards;

        private void CreatList()
        {
            ListCards = new ObservableCollection<ListCard>();
            ListCards.Add(new ListCard { Title="Figma", Total="$112.00", Type="Annualy",Description="wo gei ni bu ge dan!",UserAvatar= "/Assets/tx.jpg",UserName="yao",Date= "2Mar,12:00" });
            ListCards.Add(new ListCard { Title="Figma", Total="$112.00", Type="Annualy",Description="wo gei ni bu ge dan!",UserAvatar= "/Assets/tx.jpg",UserName="yao",Date= "2Mar,12:00" });
            ListCards.Add(new ListCard { Title="Figma", Total="$112.00", Type="Annualy",Description="wo gei ni bu ge dan!",UserAvatar= "/Assets/tx.jpg",UserName="yao",Date= "2Mar,12:00" });
            ListCards.Add(new ListCard { Title="Figma", Total="$112.00", Type="Annualy",Description="wo gei ni bu ge dan!",UserAvatar= "/Assets/tx.jpg",UserName="yao",Date= "2Mar,12:00" });
            ListCards.Add(new ListCard { Title="Figma", Total="$112.00", Type="Annualy",Description="wo gei ni bu ge dan!",UserAvatar= "/Assets/tx.jpg",UserName="yao",Date= "2Mar,12:00" });
            ListCards.Add(new ListCard { Title="Figma", Total="$112.00", Type="Annualy",Description="wo gei ni bu ge dan!",UserAvatar= "/Assets/tx.jpg",UserName="yao",Date= "2Mar,12:00" });
            ListCards.Add(new ListCard { Title="Figma", Total="$112.00", Type="Annualy",Description="wo gei ni bu ge dan!",UserAvatar= "/Assets/tx.jpg",UserName="yao",Date= "2Mar,12:00" });
            ListCards.Add(new ListCard { Title="Figma", Total="$112.00", Type="Annualy",Description="wo gei ni bu ge dan!",UserAvatar= "/Assets/tx.jpg",UserName="yao",Date= "2Mar,12:00" });
            ListCards.Add(new ListCard { Title="Figma", Total="$112.00", Type="Annualy",Description="wo gei ni bu ge dan!",UserAvatar= "/Assets/tx.jpg",UserName="yao",Date= "2Mar,12:00" });
            ListCards.Add(new ListCard { Title="Figma", Total="$112.00", Type="Annualy",Description="wo gei ni bu ge dan!",UserAvatar= "/Assets/tx.jpg",UserName="yao",Date= "2Mar,12:00" });
            ListCards.Add(new ListCard { Title="Figma", Total="$112.00", Type="Annualy",Description="wo gei ni bu ge dan!",UserAvatar= "/Assets/tx.jpg",UserName="yao",Date= "2Mar,12:00" });
        }
    }
}
