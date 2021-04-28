#nullable enable
namespace Microsoft.Maui.Graphics
{
	public static partial class BrushExtensions
	{
		public static bool IsNullOrEmpty(this Paint? paint)
		{
			if (paint is SolidPaint solidPaint)
				return solidPaint == null || solidPaint.Color == null;

			if (paint is GradientPaint gradientPaint)
				return gradientPaint == null || gradientPaint.GradientStops.Length == 0;

			return paint == null;
		}
	}
}