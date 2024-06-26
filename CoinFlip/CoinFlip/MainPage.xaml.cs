namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CoinFlipButton_Clicked(object sender, EventArgs e)
        {
            //1º passo: Pegar o que o usuário selecionou no picker
            //2º passo: Sortear um número que representa a nossa moeda
            //3º passo: Comparar o que o usuário selecionou e o resultado da moeda

            string ladoSelecionado = LadoPicker.SelectedItem.ToString();
            string ladoSorteado = new Random().Next(2).ToString();
            string resultado;
            if (ladoSorteado == "0")
            {
                ladoSorteado = "cara";
            }
            if (ladoSorteado == "1")
            {
                ladoSorteado = "coroa";
            }

            if (ladoSelecionado == ladoSorteado)
            {
                resultado = "Venceu";
            }
            else
            {
                resultado = "Perdeu";
            }
            MoedaImage.Source = $"{ladoSorteado}.png";
            ResultadoLabel.Text = resultado;
        }
    }
}
