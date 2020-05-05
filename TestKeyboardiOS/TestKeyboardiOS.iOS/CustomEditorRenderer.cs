using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using TestKeyboardiOS.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Editor), typeof(CustomEditorRenderer))]
namespace TestKeyboardiOS.iOS
{
    public class CustomEditorRenderer : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (Control == null && Element == null) return;

            Control.AutoresizingMask = UIViewAutoresizing.All;
        }
    }
}