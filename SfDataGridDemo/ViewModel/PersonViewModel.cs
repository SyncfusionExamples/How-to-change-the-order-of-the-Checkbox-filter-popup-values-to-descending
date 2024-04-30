using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Globalization.NumberFormatting;
using WINUI_DataGridDemos.Model;

namespace WINUI_DataGridDemos.ViewModel
{
    public class ViewModel
    {
        private ObservableCollection<OrderInfo> _orders;
        public ObservableCollection<OrderInfo> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        public ViewModel()
        {
            _orders = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }

        private void GenerateOrders()
        {
            _orders.Add(new OrderInfo(1001, "Maria Anders", "Germany", "ALFKI", "Berlin", new DateTime(2024,03,02)));
            _orders.Add(new OrderInfo(1002, "Ana Trujilo", "Mexico", "ANATR", "Mexico D.F.", new DateTime(1970, 03, 04)));
            _orders.Add(new OrderInfo(1003, "Antonio Moreno", "Mexico", "ANTON", "Mexico D.F.", new DateTime(2024, 02, 01)));
            _orders.Add(new OrderInfo(1004, "Thomas Hardy", "UK", "AROUT", "London", new DateTime(1990, 03, 02)));
            _orders.Add(new OrderInfo(1005, "Christina Berglund", "Sweden", "BERGS", "Lula", new DateTime(2024, 03, 03)));
            //_orders.Add(new OrderInfo(1006, "Hanna Moos", "Germany", "BLAUS", "Mannheim", new DateTime(2023, 01, 02)));
            //_orders.Add(new OrderInfo(1007, "Frederique Citeaux", "France", "BLONP", "Strasbourg", new DateTime(2024, 05, 02)));
            //_orders.Add(new OrderInfo(1008, "Martin Sommer", "Spain", "BOLID", "Madrid", new DateTime(2023, 06, 02)));
            //_orders.Add(new OrderInfo(1009, "Laurence Lebihan", "France", "BONAP", "Marseille", new DateTime(2023, 03, 30)));
            //_orders.Add(new OrderInfo(1010, "Elizabeth Lincoln", "Canada", "BOTTM", "Tsawassen", new DateTime(2023, 03, 05)));
        }
    }
}
