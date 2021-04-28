using WBrush = Microsoft.UI.Xaml.Media.Brush;

namespace Microsoft.Maui.Graphics
{
	public static class ForegroundExtensions
	{
		public static void SetForeground(this FrameworkElement nativeView, Paint? paint, WBrush? defaultTextColor = null)
		{
			nativeView.SetForeground = paint?.toNative() ?? defaultTextColor;
		}
	}
}