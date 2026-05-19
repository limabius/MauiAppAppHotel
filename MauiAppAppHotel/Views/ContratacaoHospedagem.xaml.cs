using System;
using Microsoft.Maui.Controls;

namespace MauiAppAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            // 1. Verificação de segurança: impede erro se os campos estiverem vazios ou sem suíte selecionada
            if (pckSuite.SelectedItem == null ||
                string.IsNullOrEmpty(edtHospedes.Text) ||
                string.IsNullOrEmpty(edtDias.Text))
            {
                await DisplayAlert("Atenção", "Por favor, preencha todos os campos e selecione uma suíte.", "OK");
                return;
            }

            // 2. Coleta e validação dos dados dos campos de texto
            if (!int.TryParse(edtHospedes.Text, out int hospedes))
            {
                await DisplayAlert("Erro de Entrada", "Por favor, insira um número válido para a quantidade de hóspedes.", "OK");
                return;
            }

            if (!int.TryParse(edtDias.Text, out int dias))
            {
                await DisplayAlert("Erro de Entrada", "Por favor, insira um número válido para a quantidade de dias.", "OK");
                return;
            }

            double valor = 0;

            // 3. Definição do valor da diária com base na suíte escolhida
            switch (pckSuite.SelectedItem.ToString())
            {
                case "Premium":
                    valor = 200.0;
                    break;

                case "Luxo":
                    valor = 350.0;
                    break;

                case "Master":
                    valor = 500.0;
                    break;

                default:
                    valor = 0;
                    break;
            }

            // 4. Cálculo do total
            double total = valor * dias;

            // 5. Exibição do resultado formatado e navegação para a página de confirmação
            string resumoReserva = $"Resumo da Reserva:\n" +
                                  $"-------------------\n" +
                                  $"Hóspedes: {hospedes}\n" +
                                  $"Estadia: {dias} dias\n" +
                                  $"Total: {total:C2}";

            // Navegar para a página HospedagemContratada e passar os dados
            await Shell.Current.GoToAsync("HospedagemContratada?resumo=" + Uri.EscapeDataString(resumoReserva));



        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", "Ocorreu um erro ao calcular: " + ex.Message, "OK");
        }
    }
}
