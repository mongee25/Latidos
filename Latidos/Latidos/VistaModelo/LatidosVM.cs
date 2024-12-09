using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Latidos.VistaModelo
{
        public class LatidosVM : BaseViewModel
        {
            #region VARIABLES
            int _Latidos;
            int _FrecuenciaCardiaca;
            string _FrecuenciaTexto;
            string _FrecuenciaCardiacaTextoOP;

            #endregion
            #region CONSTRUCTOR
            public LatidosVM(INavigation navigation)
            {
                Navigation = navigation;

            }
            #endregion
            #region OBJETOS
            public string FrecuenciaTexto
            {
                get { return _FrecuenciaTexto; }
                set { SetValue(ref _FrecuenciaTexto, value); }
            }
        public string FrecuenciaCardiacaTextoOP
        {   
            get { return _FrecuenciaCardiacaTextoOP; }
            set { SetValue(ref _FrecuenciaCardiacaTextoOP, value); }
        }
            public int Latidos
            {
                get { return _Latidos; }
                set { SetValue(ref _Latidos, value); }
            }
            public int FrecuenciaCardiacaOP
            {
                get { return _FrecuenciaCardiaca; }
                set { SetValue(ref _FrecuenciaCardiaca, value); }
            }
            #endregion
            #region PROCESOS
            public void FrecuenciaCardiaca()
            {
                FrecuenciaCardiacaOP = Latidos * 4;

                if (FrecuenciaCardiacaOP < 60)
                {
                    FrecuenciaTexto = "Frecuencia Cardiaca BAJA";
                }
                else if (FrecuenciaCardiacaOP > 100) 
                {
                    FrecuenciaTexto = "Frecuencia cardiaca ALTA";
                }
                else
                {
                    FrecuenciaTexto = "Frecuencia cardiaca NORMAL";
                }

                FrecuenciaCardiacaTextoOP = $"Frecuencia Cardiaca: {FrecuenciaCardiacaOP}";
        }
            #endregion
            #region COMANDOS
            public ICommand FrecuenciaCardiacacommand => new Command(FrecuenciaCardiaca);
            #endregion
    }
}
