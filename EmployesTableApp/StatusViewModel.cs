﻿using System;
using System.Collections.Generic;
using UIKit;

namespace EmployesTableApp
{
    internal class StatusViewModel : UIPickerViewModel
    {
        private List<string> statusLists;

        public string SelectedStatus { get; private set; }


        public StatusViewModel(List<string> statusLists)
        {
            this.statusLists = statusLists;
        }

        public override System.nint GetRowsInComponent(UIPickerView pickerView, System.nint component)
        {
            return statusLists.Count;
        }

        public override System.nint GetComponentCount(UIPickerView pickerView)
        {
            return 1;
        }

        public override string GetTitle(UIPickerView pickerView, nint row, nint component)
        {
            return statusLists[(int)row];
        }

        public override void Selected(UIPickerView pickerView, nint row, nint component)
        {
            var status = statusLists[(int)row];
            SelectedStatus = status;
        }
    }
}