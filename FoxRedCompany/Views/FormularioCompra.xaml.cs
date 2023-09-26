namespace FoxRedCompany.Views;

public partial class FormularioCompra : ContentPage
{
	public FormularioCompra()
	{
		InitializeComponent();
	}

    async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new DetalleProducto());
    }
}