using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using EmployesTableApp.Domain;

namespace EmployesTableApp
{
    public partial class DetailOrderArrivalController : UITableViewController
    {
        Order currentOrder { get; set; }
        public ArrivalDetailViewController Delegate { get; set; }


        partial void SaveOrder(UIButton sender)
        {
            
            currentOrder.Name = NameField.Text;
            currentOrder.Status = "dddd";
            Delegate.SaveTask(currentOrder);
        }

        public string OrderName
        {
            get;
            set;
        }

        partial void DeteleOrder(UIButton sender)
        {
            Delegate.DeleteTask(currentOrder);
        }

        public string OrderStatus
        {
            get;
            set;
        }

        public int Flight_ID
        {
            get;
            set;
        }

        public void SetTask(ArrivalDetailViewController d, Order order){
            Delegate = d;
            currentOrder = order;
        }

        public DetailOrderArrivalController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var statusLists = new List<string>{
                "Басталды","Аяқталды"
            };

            StatusPicker.Model = new StatusViewModel(statusLists);

            NameField.Text = OrderName;
            Flight_ID = Flight_ID;
        }
    }
}