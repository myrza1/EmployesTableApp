using UIKit;
using EmployesTableApp.Domain;
using System.Collections.Generic;
using System;

namespace EmployesTableApp
{
    internal class OrderNameModel : UIPickerViewModel
    {
        private string orderName;
        private string x_Name;
        List<OrderType> orderTypes;
        UITableViewCell fuelViewCell;

        public OrderNameModel(List<OrderType> orderTypes, UITableViewCell fuelViewCell)
        {
            this.orderTypes = orderTypes;
            this.fuelViewCell = fuelViewCell;

        }

 

		public override nint GetComponentCount(UIPickerView pickerView)
		{
            return 1;
		}

		public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
		{
            return orderTypes.Count;
		}

		public override string GetTitle(UIPickerView pickerView, nint row, nint component)
		{
            if (component == 0)
                return orderTypes[(int)row].Name;
            else
                return orderTypes[(int)row].Type;
		}

		public override void Selected(UIPickerView pickerView, nint row, nint component)
		{
            orderName = orderTypes[(int)row].Name;
            x_Name = orderTypes[(int)row].Type;
            if (x_Name == "FUE") fuelViewCell.Hidden = false;
            else fuelViewCell.Hidden = true;
            //Delegate.SaveOrderName(
            //    orderTypes[(int)row]
            //);«
		}
	}
}