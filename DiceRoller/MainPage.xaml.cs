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
		int max = 10;

		Random random = new Random();

		int numeroGerado = random.Next(min, max + 1);
		numberOutput.Text = numeroGerado.ToString();
    }
}

