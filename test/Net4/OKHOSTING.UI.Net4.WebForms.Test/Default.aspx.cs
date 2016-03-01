﻿using OKHOSTING.UI.Test;
using System;

namespace OKHOSTING.UI.Net4.WebForms.Test
{
	public partial class Default : OKHOSTING.UI.Net4.WebForms.Page
	{
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (Platform.Current.Controller == null)
			{
				new IndexController().Start();
			}
		}
	}
}