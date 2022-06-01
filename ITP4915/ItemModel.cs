using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace ITP4915
{
    public class ItemModel : INotifyPropertyChanged
    {
        private string itemId;
        private string itemName;
        private string wsid;
        private decimal qty, price;

        public string ItemId
        {
            get => itemId;
            set { itemId = value; OnPropertyChanged(); }
        }
        public string ItemName
        {
            get => itemName;
            set { itemName = value; OnPropertyChanged(); }
        }
        public decimal Quantity
        {
            get => qty;
            set { qty = value; OnPropertyChanged(); }
        }

        public decimal Price
        {
            get => price;
            set { price = value; OnPropertyChanged(); }
        }

        public string Wsid
        {
            get => wsid;
            set { wsid = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        // This is to notify the grid if any of the properties are updated
        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
    public static class SharedData
    {
        public static BindingList<ItemModel> Items { get; set; } = new BindingList<ItemModel>();
    }

}
