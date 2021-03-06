using System;
using System.ComponentModel;
using Android.Views;
using AView = Android.Views.View;

namespace Xamarin.Forms.Platform.Android
{
	public interface IVisualElementRenderer : IRegisterable, IDisposable
	{
		VisualElement Element { get; }

		VisualElementTracker Tracker { get; }

		[Obsolete("Use View instead")]
		ViewGroup ViewGroup { get; }

		AView View { get; }

		event EventHandler<VisualElementChangedEventArgs> ElementChanged;

		event EventHandler<PropertyChangedEventArgs> ElementPropertyChanged;

		SizeRequest GetDesiredSize(int widthConstraint, int heightConstraint);

		void SetElement(VisualElement element);

		void SetLabelFor(int? id);

		void UpdateLayout();
	}
}