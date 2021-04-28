#nullable enable
using System.Collections.Generic;
using System.Linq;
using WBrush = Microsoft.UI.Xaml.Media.Brush;
using WGradientStop = Microsoft.UI.Xaml.Media.GradientStop;
using WLinearGradientBrush = Microsoft.UI.Xaml.Media.LinearGradientBrush;
using WRadialGradientBrush = Microsoft.UI.Xaml.Media.RadialGradientBrush;
using WSolidColorBrush = Microsoft.UI.Xaml.Media.SolidColorBrush;

namespace Microsoft.Maui.Graphics
{
	public static partial class PaintExtensions
	{
		public static WBrush? CreateBrush(this SolidColorPaint solidColorPaint)
		{
			var brush = new WSolidColorBrush
			{
				Color = solidColorPaint.Color.ToWindowsColor()
			};

			return brush;
		}

		public static WBrush? CreateBrush(this LinearGradientPaint linearGradientPaint)
		{
			var brush = new WLinearGradientBrush
			{
				StartPoint = linearGradientPaint.StartPoint.ToNative(),
				EndPoint = linearGradientPaint.EndPoint.ToNative()
			};

			brush.GradientStops.AddRange(linearGradientPaint.GradientStops);

			return brush;
		}

		public static WBrush? CreateBrush(this RadialGradientPaint radialGradientPaint)
		{
			var brush = new WRadialGradientBrush
			{
				Center = radialGradientPaint.Center.ToNative(),
				RadiusX = radialGradientPaint.Radius,
				RadiusY = radialGradientPaint.Radius
			};

			brush.GradientStops.AddRange(radialGradientPaint.GradientStops);

			return brush;
		}

		static void AddRange(this IList<WGradientStop> nativeStops, IEnumerable<GradientStop> stops)
		{
			foreach (var stop in stops.OrderBy(x => x.Offset))
			{
				var nativeStop = new WGradientStop
				{
					Color = stop.Color.ToWindowsColor(),
					Offset = stop.Offset
				};
				nativeStops.Add(nativeStop);
			}
		}
	}
}