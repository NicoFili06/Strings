using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Filippini.Nicolò._3i.MAUIString;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
