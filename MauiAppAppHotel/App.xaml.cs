using Microsoft.Maui.Controls;

namespace MauiAppAppHotel;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        // NÃO coloque "MainPage = new AppShell();" aqui!
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        // É aqui que você define a página inicial dentro da Window
        return new Window(new AppShell())
        {
            Width = 400,
            Height = 600
        };
    }
}
