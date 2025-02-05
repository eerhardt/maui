using System;
using System.Collections.Generic;
using System.Diagnostics;
using Maui.Controls.Sample.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;

namespace Maui.Controls.Sample
{
	public class MyApp : IApplication
	{
		List<IWindow> _windows = new List<IWindow>();
		public IReadOnlyList<IWindow> Windows => _windows.AsReadOnly();

		public MyApp(IServiceProvider services, ITextService textService)
		{
			Services = services;
			Debug.WriteLine($"The injected text service had a message: '{textService.GetText()}'");
		}

		public IServiceProvider Services { get; }

		public IWindow CreateWindow(IActivationState activationState)
		{
			Microsoft.Maui.Controls.Compatibility.Forms.Init(activationState);
			var window = Services.GetRequiredService<IWindow>();
			_windows.Add(window);
			return window;
		}
	}
}