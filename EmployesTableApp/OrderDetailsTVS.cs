using System;
using Foundation;
using UIKit;

namespace EmployesTableApp
{
    internal class OrderDetailsTVS : UITableViewSource
    {
        private string orderName;
        private string orderStatus;

        public OrderDetailsTVS(int flight_id, string orderName, string orderStatus)
        {
            this.orderName = orderName;
            this.orderStatus = orderStatus;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (OrderEditCell)tableView.DequeueReusableCell("title", indexPath);

            cell.UpdateCell(orderName, orderStatus);

            return cell;

        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return 1;
        }
    }
}