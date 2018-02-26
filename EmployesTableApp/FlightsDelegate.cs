using Foundation;
using UIKit;

namespace EmployesTableApp
{
    internal class FlightsDelegate : UITableViewDelegate
    {
        public override UITableViewRowAction[] EditActionsForRow(UITableView tableView, NSIndexPath indexPath)
        {
            var action = UITableViewRowAction.Create(
                UITableViewRowActionStyle.Default,
                "like",
                (arg1, arg2) =>
                {
                    var cell = (FlightsCell)tableView.CellAt(arg2);
                    cell.LikeCell();
                    
                });
            return new UITableViewRowAction[]
            {
                action
            };
        }
    }
}