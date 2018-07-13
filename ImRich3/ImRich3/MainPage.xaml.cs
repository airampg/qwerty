using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ImRich3;

namespace ImRich3
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            Button btn1 = new Button();
            btn1.HeightRequest = 200;
            pepe.Children.Add(btn1);
            btn1.Text = "Soy pepe";
            btn1.Clicked += Btn1_Clicked;
		}

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("pepe", "pepe es guay", "jaja xD");
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page2());
            //DisplayAlert("Enhorabuena", "Ahora nosotros tenemos tu dinero :)", "cerrar >:-(");
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            rotatingLabel.Rotation = value;
            displayLabel.Text = String.Format("The Slider value is {0}", value);
        }
    }
}
