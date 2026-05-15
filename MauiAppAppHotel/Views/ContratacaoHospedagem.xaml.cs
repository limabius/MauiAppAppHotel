namespace MauiAppAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        int hospedes = Convert.ToInt32(edtHospedes.Text);
        int dias = Convert.ToInt32(edtDias.Text);

        double valor = 0;

        switch (pckSuite.SelectedItem.ToString())
        {
            case "Premium":
                valor = 200;
                break;

            case "Luxo":
                valor = 350;
                break;

            case "Master":
                valor = 500;
                break;
        }

        double total = valor * dias;

        lblResultado.Text =
            $"Hospedes: {hospedes}\n" +
            $"Dias: {dias}\n" +
            $"Total: R$ {total}";
    }
}