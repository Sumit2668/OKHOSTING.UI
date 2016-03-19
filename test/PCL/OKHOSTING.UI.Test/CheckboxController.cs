﻿using System;
using OKHOSTING.UI.Controls;
using OKHOSTING.UI.Controls.Layout;

namespace OKHOSTING.UI.Test
{
	public class CheckboxController: Controller
	{
        ICheckBox cbxColor;
        ILabel lblLabel;

        public override void Start()
		{
			base.Start();

			IStack stack = Platform.Current.CreateControl<IStack>();

			lblLabel = Platform.Current.CreateControl<ILabel>();
			lblLabel.Text = "This is a label";
			lblLabel.Height = 30;
			stack.Children.Add(lblLabel);

            cbxColor = Platform.Current.CreateControl<ICheckBox>();
            cbxColor.Name = "color";
            cbxColor.Value = true;
            stack.Children.Add(cbxColor);

            IButton cmdChange = Platform.Current.CreateControl<IButton>();
            cmdChange.Text = "Change";
            cmdChange.Click += CmdChange_Click;
            stack.Children.Add(cmdChange);

            IButton cmdClose = Platform.Current.CreateControl<IButton>();
            cmdClose.Text = "Close";
            cmdClose.Click += CmdClose_Click;
            stack.Children.Add(cmdClose);

            Platform.Current.Page.Title = "Test label";
			Platform.Current.Page.Content = stack;
		}

        private void CmdChange_Click(object sender, EventArgs e)
        {
            if(cbxColor.Value == true)
            {
                lblLabel.FontColor = new Color(1, 255, 0, 0);
            }
            else
            {
                lblLabel.FontColor = new Color(1, 0, 0, 0);
            }
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Finish();
        }
    }
}