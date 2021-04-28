﻿using Microsoft.Maui.Graphics;

namespace Microsoft.Maui.Controls
{
	public partial class TimePicker : ITimePicker
	{
		Font? _font;

		public Paint Foreground { get; set; }

		Font ITextStyle.Font => _font ??= Font.OfSize(FontFamily, FontSize).WithAttributes(FontAttributes);
	}
}