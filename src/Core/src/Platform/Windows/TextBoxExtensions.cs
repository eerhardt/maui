using Microsoft.Maui.Graphics;

namespace Microsoft.Maui
{
	public static class TextBoxExtensions
	{
		public static void UpdateText(this MauiTextBox textBox, IEntry entry)
		{
			textBox.Text = entry.Text;
		}

		public static void UpdateForeground(this MauiTextBox textBox, ITextStyle textStyle)
		{
			if (textStyle.Foreground == null)
				return;

			Paint? paint = textStyle.Foreground;
			var foreground = paint.ToNative();

			textBox.Foreground = foreground;
			textBox.ForegroundFocusBrush = foreground;
		}

		public static void UpdatePlaceholder(this MauiTextBox textBox, IEntry entry)
		{
			textBox.PlaceholderText = entry.Placeholder ?? string.Empty;
		}

		public static void UpdateIsReadOnly(this MauiTextBox textBox, IEntry entry)
		{
			textBox.IsReadOnly = entry.IsReadOnly;
    }
    
		public static void UpdateMaxLength(this MauiTextBox textBox, IEntry entry)
		{
			var maxLength = entry.MaxLength;

			if (maxLength == -1)
				maxLength = int.MaxValue;

			textBox.MaxLength = maxLength;

			var currentControlText = textBox.Text;

			if (currentControlText.Length > maxLength)
				textBox.Text = currentControlText.Substring(0, maxLength);
		}
	}
}
