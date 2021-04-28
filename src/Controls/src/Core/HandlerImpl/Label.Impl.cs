using Microsoft.Maui.Graphics;

namespace Microsoft.Maui.Controls
{
	public partial class Label : ILabel
	{
		Font? _font;

		public Paint Foreground { get; set; }

		Font ITextStyle.Font => _font ??= Font.OfSize(FontFamily, FontSize).WithAttributes(FontAttributes);
	}
}