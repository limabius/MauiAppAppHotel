using Microsoft.Maui.Controls;

namespace MauiAppAppHotel
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            // Garante que o CounterBtn seja tratado como um Button para acessar a propriedade Text
            if (CounterBtn != null)
            {
                if (count == 1)
                    CounterBtn.Text = $"Clicked {count} time";
                else
                    CounterBtn.Text = $"Clicked {count} times";

                SemanticScreenReader.Announce(CounterBtn.Text);
            }
        }
    }
}
