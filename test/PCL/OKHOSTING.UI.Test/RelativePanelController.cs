﻿using System;
using OKHOSTING.UI.Controls;
using OKHOSTING.UI.Controls.Layout;

namespace OKHOSTING.UI.Test
{
	public class RelativePanelController : Controller
	{
		public override void Start()
		{
			base.Start();

			IRelativePanel panel = Platform.Current.Create<IRelativePanel>();

			ILabel lblLabel = Platform.Current.Create<ILabel>();
			lblLabel.Text = "This label is centered";
			lblLabel.Height = 30;
			lblLabel.BackgroundColor = new Color(255, 255, 0, 0);
			panel.Add(lblLabel, RelativePanelHorizontalContraint.CenterWith, RelativePanelVerticalContraint.CenterWith);

			ILabel lblLabel2 = Platform.Current.Create<ILabel>();
			lblLabel2.Text = "This label is below the centered one";
			lblLabel2.Height = 50;
			lblLabel2.BackgroundColor = new Color(255, 0, 255, 0);
			panel.Add(lblLabel2, RelativePanelHorizontalContraint.CenterWith, RelativePanelVerticalContraint.BelowOf, lblLabel);

			//should be a background image
			IImage image = Platform.Current.Create<IImage>();
			image.LoadFromUrl(new Uri("http://okhosting.com/resources/uploads/2015/09/diseno-de-paginas-responsivas.png"));
			panel.Add(image, RelativePanelHorizontalContraint.LeftWith, RelativePanelVerticalContraint.TopWith);

			IButton cmdClose = Platform.Current.Create<IButton>();
            cmdClose.Text = "Close";
            cmdClose.Click += CmdClose_Click;
			panel.Add(cmdClose, RelativePanelHorizontalContraint.RightOf, RelativePanelVerticalContraint.AboveOf, lblLabel);

            Platform.Current.Page.Title = "Test RelativePanel";
			Platform.Current.Page.Content = panel;
		}

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Finish();
        }
    }
}