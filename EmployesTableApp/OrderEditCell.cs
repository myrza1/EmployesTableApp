using Foundation;
using System;
using UIKit;

namespace EmployesTableApp
{
    public partial class OrderEditCell : UITableViewCell
    {
        public OrderEditCell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(string orderName, string orderStatus)
        {
            //OrderNameField.Text = orderName;
            //OrderStatusField.Text = orderStatus;
        }
    }
}