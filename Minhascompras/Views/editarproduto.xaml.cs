using Minhascompras.Models;

namespace Minhascompras.Views;

public partial class editarproduto : ContentPage
{
	public editarproduto()
	{
		InitializeComponent();
	}

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        try
        {
            Produto produto_anexado = BindingContext as Produto;

            Produto p = new Produto
            {
                Id = produto_anexado.Id,
                Descricao = txt_preco.Text,
                Quantidade = Convert.ToDouble(txt_quantidade.Text),
                Preco = Convert.ToDouble(txt_preco.Text)
            };

            await App.Db.Update(p);
            await DisplayAlert("Sucesso!", "Registrado Atualizado", "OK");
            await Navigation.PopAsync();

        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "Ok");
        }
    }
}