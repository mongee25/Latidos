using Latidos.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Latidos.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VistaLatidos : ContentPage
    {
        public VistaLatidos()
        {
            InitializeComponent();
            BindingContext = new LatidosVM(Navigation);
        }
    }
}