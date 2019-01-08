using System;
using Xamarin.Forms;

namespace ColorPicker
{
    public partial class ColorPickerPage : ContentPage
    {
        Random random = new Random();
        TapGestureRecognizer tapGestureRecognizer;
        TapGestureRecognizer bxViewtapGestureRecognizer;
        public ColorPickerPage()
        {
            InitializeComponent();
            BindingContext = this;
            tapGestureRecognizer = new TapGestureRecognizer();
            bxViewtapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped;
            bxViewtapGestureRecognizer.Tapped += BoxViewTapGestureRecognizer_Tapped;
            SetIntialValues();
            bxCode.GestureRecognizers.Add(bxViewtapGestureRecognizer);

        }
        public string BoColor
        {
            get
            {
                return String.Format("#{0:X6}", random.Next(0x1000000));
            }
        }
        private void SetIntialValues()
        {
            for (int i = 0; i < 50; i++)
            {
                BoxView bxView = new BoxView
                {
                    HeightRequest = 60,
                    WidthRequest = 40,

                };
                bxView.SetBinding(BoxView.ColorProperty, new Binding(nameof(BoColor), source: this));
                bxView.GestureRecognizers.Add(tapGestureRecognizer);
                stackColors.Children.Add(bxView);
            }          
        }

        void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            BoxView s = (BoxView)sender;
            bxViewSelected.Color = s.Color;
        }
        void BoxViewTapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            frmCode.IsVisible = false;
            bxCode.IsVisible = false;
        }

        void AddChooseColor(object sender, EventArgs e)
        {
            txtColorCode.Text = string.Empty;
            frmCode.IsVisible = true;
            bxCode.IsVisible = true;
        }

        void AddColor(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.Match("#" + txtColorCode.Text, "^#(?:[0-9a-fA-F]{3}){1,2}$").Success)
            {
                BoxView bxView = new BoxView
                {
                    HeightRequest = 60,
                    WidthRequest = 40,
                    Color = Color.FromHex("#" + txtColorCode.Text)
                };
                bxView.GestureRecognizers.Add(tapGestureRecognizer);
                stackColors.Children.Add(bxView);
                frmCode.IsVisible = false;
                bxCode.IsVisible = false;
            }
            else
            {
                DisplayAlert("Alert", "Invalid color code!!", "ok");
            }
        }


    }
}
