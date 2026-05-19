using Microsoft.Maui.Controls;
using System.Web;

namespace MauiAppAppHotel.Views;

[QueryProperty(nameof(ResumoReserva), "resumo")]
public partial class HospedagemContratada : ContentPage
{
    private string _resumoReserva = string.Empty;

    public string ResumoReserva
    {
        get => _resumoReserva;
        set
        {
            _resumoReserva = HttpUtility.UrlDecode(value);
            OnPropertyChanged();
            UpdateUI();
        }
    }

    public HospedagemContratada()
    {
        InitializeComponent();
    }

    private void UpdateUI()
    {
        // O uso do operador ? garante que não haverá erro se o lblResumo for nulo
        if (lblResumo != null)
        {
            lblResumo.Text = ResumoReserva;
        }
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        // Usa ".." para voltar uma página ou vai direto para a rota raiz
        await Shell.Current.GoToAsync("..");
    }
}
