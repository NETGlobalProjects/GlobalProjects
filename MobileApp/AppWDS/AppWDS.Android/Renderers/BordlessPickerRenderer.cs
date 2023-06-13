
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Service.Controls;
using Android.Text;
using AppWDS.Controls;
using AppWDS.Droid.Renderers;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.ComboBox;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(PickerEditText), typeof(BordlessPickerRenderer))]
namespace AppWDS.Droid.Renderers
{
    //public class BordlessPickerRenderer : PickerRenderer
    //{
    //    public BordlessPickerRenderer(Context context) : base(context)
    //    {
    //    }
    //    //public BorderlessPicker ElementV2 => Element as BorderlessPicker;
    //    //protected override Piker CreateNativeControl()
    //    //{
    //    //    var control = base.CreateNativeControl();
    //    //    UpdateBackground((PickerEditText)control);
    //    //    return (PickerEditText)control;
    //    //}

    //    //protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
    //    //{
    //    //    if (e.PropertyName == BorderlessPicker.CornerRadiusProperty.PropertyName)
    //    //    {
    //    //        UpdateBackground();
    //    //    }
    //    //    else if (e.PropertyName == BorderlessPicker.BorderThicknessProperty.PropertyName)
    //    //    {
    //    //        UpdateBackground();
    //    //    }
    //    //    else if (e.PropertyName == BorderlessPicker.BorderColorProperty.PropertyName)
    //    //    {
    //    //        UpdateBackground();
    //    //    }

    //    //    base.OnElementPropertyChanged(sender, e);
    //    //}

    //    protected override void UpdateBackgroundColor()
    //    {
    //        UpdateBackground();
    //    }
    //    protected void UpdateBackground(PickerEditText control)
    //    {
    //        if (control == null) return;

    //        var gd = new GradientDrawable();
    //        gd.SetColor(Element.BackgroundColor.ToAndroid());
    //        //gd.SetCornerRadius(Context.ToPixels(ElementV2.CornerRadius));
    //        //gd.SetStroke((int)Context.ToPixels(ElementV2.BorderThickness), ElementV2.BorderColor.ToAndroid());
    //        control.SetBackground(gd);

    //        //var padTop = (int)Context.ToPixels(ElementV2.PaddingTop);
    //        //var padBottom = (int)Context.ToPixels(ElementV2.PaddingBottom);
    //        //var padLeft = (int)Context.ToPixels(ElementV2.PaddingLeft);
    //        //var padRight = (int)Context.ToPixels(ElementV2.PaddingRight);

    //        //control.SetPadding(padLeft, padTop, padRight, padBottom);
    //    }
    //    protected void UpdateBackground()
    //    {
    //        UpdateBackground((PickerEditText)Control);
    //    }

    //}

    ////{
    ////    private Context context;
    ////    public BordlessPickerRenderer(Context context) : base(context)
    ////    {
    ////        this.context = context;
    ////    }

    ////    [System.Obsolete]

    //protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
    //{
    //    base.OnElementChanged(e);

    //    if (e.OldElement == null)
    //    {
    //        Control.Background = null;
    //    }
    //}
    public class BordlessPickerRenderer : PickerRenderer
    {
        public BordlessPickerRenderer(Context context) : base(context)
        {
        }

        [System.Obsolete]
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
           
            if (e.OldElement == null)
            {
                Control.Background = null;
                
            }
        }

    }

}