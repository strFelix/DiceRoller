namespace DiceRoller;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnButtonClicked(object sender, EventArgs e)
	{
		int min = 1;
        //int max = 101;

        var numeroSelecionado = picker.SelectedItem;
		string numeroTxt = numeroSelecionado.ToString();
		int max = int.Parse(numeroTxt) + 1;
		
		Random random = new Random();

		int numeroGerado = random.Next(min, max);
		numberOutput.Text = numeroGerado.ToString();
    }
}

