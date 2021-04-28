using Android.Content.Res;
using Android.Graphics;
using AndroidX.AppCompat.Widget;
using AndroidX.Core.Widget;
using AAttribute = Android.Resource.Attribute;
using AColor = Android.Graphics.Color;
using XColor = Microsoft.Maui.Graphics.Color;

namespace Microsoft.Maui
{
	public static class CheckBoxExtensions
	{
		public static void UpdateBackground(this AppCompatCheckBox nativeCheckBox, ICheckBox check)
		{
			var paint = check.Background;

			if (paint?.IsNullOrEmpty())
				nativeCheckBox.SetBackgroundColor(AColor.Transparent);
			else
				nativeCheckBox.UpdateBackground((IView)check);
		}

		public static void UpdateIsChecked(this AppCompatCheckBox nativeCheckBox, ICheckBox check)
		{
			nativeCheckBox.Checked = check.IsChecked;
		}
	}
}