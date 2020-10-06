using System.Windows.Forms;
using Pizzeria.Core;
using Pizzeria.Data.Models;

namespace Pizzeria.UI
{
    public partial class HistoryForm : Form
    {
        private User _user;
        public HistoryForm(User user)
        {
            InitializeComponent();
            _user = user;
            
            OrderHistoryHelper.PopulateOrderHistory(tableHistory, _user);
        }

        
    }
}