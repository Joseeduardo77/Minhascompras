namespace Minhascompras.Views;

public partial class ListaProduto : ContentPage
{
	public ListaProduto()
	{
		InitializeComponent();
	}

    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new Views.Novoproduto());

		}
		catch (Exception ex) 
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}
		 
		
		
    }
}