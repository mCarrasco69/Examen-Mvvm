using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ExamenMvvm.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private decimal producto1;

        [ObservableProperty]
        private decimal producto2;

        [ObservableProperty]
        private decimal producto3;

        [ObservableProperty]
        private decimal subtotal;

        [ObservableProperty]
        private decimal descuento;

        [ObservableProperty]
        private decimal total;

        [RelayCommand]
        private void Calcular()
        {
            Subtotal = Producto1 + Producto2 + Producto3;

            if (Subtotal >= 10000)
            {
                Descuento = Subtotal * 0.3m;
            }
            else if (Subtotal >= 5000)
            {
                Descuento = Subtotal * 0.2m;
            }
            else if (Subtotal >= 1000)
            {
                Descuento = Subtotal * 0.1m;
            }
            else
            {
                Descuento = 0;
            }

            Total = Subtotal - Descuento;
        }

        [RelayCommand]
        private void Limpiar()
        {
            Producto1 = 0;
            Producto2 = 0;
            Producto3 = 0;
            Subtotal = 0;
            Descuento = 0;
            Total = 0;
        }
    }
}
