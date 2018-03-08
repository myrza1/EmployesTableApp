using System;
using System.Collections.Generic;
using EmployesTableApp.Domain;
using Foundation;
using UIKit;

namespace EmployesTableApp
{
    internal class OrdersTVS : UITableViewSource
    {
        private List<Order> orders;

        public OrdersTVS(List<Order> orders)
        {
            this.orders = orders;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (OrderAirrvalsCell)tableView.DequeueReusableCell("cell_id", indexPath);

            var order = orders[indexPath.Row];

            cell.UpdateCell(order);

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return orders.Count;

        }

    }
}