﻿#nullable enable
using Microsoft.Maui.Graphics;
using Microsoft.UI.Xaml.Controls;
using WBrush = Microsoft.UI.Xaml.Media.Brush;

namespace Microsoft.Maui
{
	public static class PickerExtensions
	{
		public static void UpdateTitle(this MauiComboBox nativeComboBox, IPicker picker)
		{
			nativeComboBox.Header = null;

			nativeComboBox.HeaderTemplate = string.IsNullOrEmpty(picker.Title) ? null : 
				(UI.Xaml.DataTemplate)UI.Xaml.Application.Current.Resources["ComboBoxHeader"];

			nativeComboBox.DataContext = picker;
		}
		public static void UpdateForeground(this MauiComboBox nativeComboBox, IPicker picker)
		{
			nativeComboBox.UpdateForeground(picker, null);
		}
		
		public static void UpdateForeground(this MauiComboBox nativeComboBox, IPicker picker, WBrush? defaultForeground)
		{
			Paint? foreground = picker.Foreground;
			nativeComboBox.Foreground = foreground.IsNullOrEmpty() ? (defaultForeground ?? foreground?.ToNative()) : foreground?.ToNative();
		}

		public static void UpdateSelectedIndex(this MauiComboBox nativeComboBox, IPicker picker)
		{
			nativeComboBox.SelectedIndex = picker.SelectedIndex;
		}

		public static void UpdateCharacterSpacing(this MauiComboBox nativeComboBox, IPicker picker)
		{
			nativeComboBox.CharacterSpacing = picker.CharacterSpacing.ToEm();
		}

		public static void UpdateFont(this MauiComboBox nativeComboBox, IPicker picker, IFontManager fontManager) =>
			nativeComboBox.UpdateFont(picker.Font, fontManager);
	}
}