using EmployesTableApp.Domain;
using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace EmployesTableApp
{
    public partial class DOAController : UITableViewController
    {
        Order currentOrder { get; set; }
        public ArrivalDetailViewController Delegate { get; set; }
        private string orderName;

        List<OrderType> orderTypes;

        public string X_Name
        {
            get;
            set;
        }

        public int Order_ID
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
        public string OrderName { get => orderName; set => orderName = value; }

        public void SetTask(ArrivalDetailViewController d, Order order)
        {
            Delegate = d;
            currentOrder = order;
        }

       

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            orderTypes = new List<OrderType>{
            new OrderType{Name = "Follow Me",Type = "BAS"},
            new OrderType{Name = "Towing",Type = "BAS"},
            new OrderType{Name = "PushBack",Type = "BAS"},
            new OrderType{Name = "Post Flight Maintenance",Type = "BAS"},
            new OrderType{Name = "Passenger Steps",Type = "BAS"},
            new OrderType{Name = "Towing",Type = "BAS"},
            new OrderType{Name = "Follow Me",Type = "BAS"},
            new OrderType{Name = "Towing",Type = "BAS"},
            new OrderType{Name = "Follow Me",Type = "BAS"},
            new OrderType{Name = "Towing",Type = "BAS"},
            new OrderType{Name = "Follow Me",Type = "BAS"},
            new OrderType{Name = "Towing",Type = "BAS"},
            new OrderType{Name = "Follow Me",Type = "BAS"},
            new OrderType{Name = "Towing",Type = "BAS"},

        };

       
            UIPickerViewModel orderNameModel = new OrderNameModel(orderTypes);
            //orderNameModel.set
            OrderNamePicker.Model = orderNameModel;


            if (OrderName != null)
            {
                NameField0202.Text = OrderName;
                DoneSwich.On = OrderStatus.Length > 4 ? true : false;
            }
            Flight_ID = Flight_ID;
        }
        public DOAController (IntPtr handle) : base (handle)
        {
        }

        public void SaveOrderName(OrderType orderType){
            orderName = orderType.Name;
            X_Name = orderType.Type;
        }
        partial void SaveOrder(UIButton sender)
        {

            currentOrder.Name = orderTypes[(int)OrderNamePicker.SelectedRowInComponent(0)].Name;
            //    currentOrder.order = OrderStatus;
            currentOrder.Status = DoneSwich.On ? "Encluded" : "No";
            currentOrder.Order_ID = Order_ID;
            currentOrder.X_name = orderTypes[(int)OrderNamePicker.SelectedRowInComponent(0)].Type;
            Delegate.SaveTask(currentOrder);
        }
    }
}