﻿using JolliTradersHope.Pages;

namespace JolliTradersHope;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(CartPage), typeof(CartPage));
	}
}
