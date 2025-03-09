using Minhascompras.Models;

namespace Minhascompras.Views;

public partial class Novoproduto : ContentPage
{
	public Novoproduto()
	{
		InitializeComponent();
	}

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
		try
		{
			Produto p = new Produto
			{
				Descricao = txt_preco.Text,
                Quantidade = Convert.ToDouble(txt_quantidade.Text),
                Preco = Convert.ToDouble(txt_preco.Text)
            };

			await App.Db.Insert(p);
			await DisplayAlert("Sucesso!", "Registrado Inserido", "OK");

		}
		catch (Exception ex) 
		{
			await DisplayAlert("Ops", ex.Message, "Ok");
		}
    }
}