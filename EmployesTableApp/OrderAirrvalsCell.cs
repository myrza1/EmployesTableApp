using Foundation;
using System;
using UIKit;
using EmployesTableApp.Domain;

namespace EmployesTableApp
{
    public partial class OrderAirrvalsCell : UITableViewCell
    {
        public OrderAirrvalsCell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(Order order)
        {
            OrderName.Text = order.Name;
            OrderStatus.Text = order.Status;
        }
    }
}