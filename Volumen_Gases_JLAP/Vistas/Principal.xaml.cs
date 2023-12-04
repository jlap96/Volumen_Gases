using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volumen_Gases_JLAP.Vistas;
using Xamarin.Forms;

namespace Volumen_Gases_JLAP
{
    public partial class Principal : ContentPage
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btniniciar_Clicked(object sender, EventArgs e) 
        {
            Navigation.PushAsync(new Calculador());
        }
    }
}
