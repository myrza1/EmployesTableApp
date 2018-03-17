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

        public OrderNameModel(List<OrderType> orderTypes)
        {
            this.orderTypes = orderTypes;

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
            //Delegate.SaveOrderName(
            //    orderTypes[(int)row]
            //);«
		}
	}
}