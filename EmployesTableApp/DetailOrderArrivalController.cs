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
        //    currentOrder.Status = OrderStatus;
            currentOrder.Status = DoneSwich.On ? "Encluded" : "No";
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

            if (OrderName != null){
                NameField.Text = OrderName;
                
                DoneSwich.On = OrderStatus.Length > 4 ? true : false;
            }
            Flight_ID = Flight_ID;
        }
    }


}