using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Volumen_Gases_JLAP.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Calculador : ContentPage
	{
		double presion;
		double temperatura;
		double moles;
		double litros;
		double metros;
		public Calculador ()
		{
			InitializeComponent ();
		}
		private void Calcular()
		{
			presion = Convert.ToDouble(txtPresion.Text);
			temperatura = Convert.ToDouble(txtTemperatura.Text);
			moles = Convert.ToDouble(txtMoles.Text);

			litros = (moles * temperatura/presion)* 0.08205784;
			metros = litros / 1000;
			lblResultado.Text = litros.ToString("0.##") + " L";
			lblResultadoMetros.Text = metros.ToString("0.####") + " m3";
		}

        private void btnvolver_Clicked(object sender, EventArgs e)
        {
			Navigation.PopAsync();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
			Calcular();
        }
    }
}