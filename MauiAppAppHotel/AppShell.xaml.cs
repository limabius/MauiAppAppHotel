using MauiAppAppHotel.Views;

namespace MauiAppAppHotel;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Registro manual da rota
        Routing.RegisterRoute("HospedagemContratada", typeof(HospedagemContratada));
    }
}
