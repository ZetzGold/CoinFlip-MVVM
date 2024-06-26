using CoinFlip.ViewModels;

namespace CoinFlip.Views;

public partial class MoedaView : ContentPage
{
	public MoedaView()
	{
        InitializeComponent();
        BindingContext = new MoedaViewModel();
	}
}