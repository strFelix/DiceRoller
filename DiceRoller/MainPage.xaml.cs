namespace DiceRoller;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnButtonClicked(object sender, EventArgs e)
	{
		//eleciona valor picker
		var maxValue = picker.SelectedItem;
		//instancia do objeto gerando um numero com minimo e maximo (+1)
		var numeroSorteado = new Random().Next(1, (int)maxValue + 1);

		//Mostrando o numero na tela"
		numberOutput.Text= numeroSorteado.ToString();
    }
}

