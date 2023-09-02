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
        var numeroSelecionado = picker.SelectedItem;
        //int max = 101;
		int max = int.Parse(numeroSelecionado.ToString()) + 1;
		
		Random random = new Random();

		int numeroGerado = random.Next(min, max);
		numberOutput.Text = numeroGerado.ToString();
    }
}

