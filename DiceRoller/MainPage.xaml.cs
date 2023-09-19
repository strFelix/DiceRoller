namespace DiceRoller;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        seletorQuantidadeLados.SelectedIndex = 0;
    }

    public class Dice
    {
        private int NumSides {get; set;}

        //overload
        public Dice() { } //metodo construtor padrão

        public Dice(int numSides) //construtor com argumentos
        {
            NumSides = numSides; //definindo que o numero de lados é o parametro do ARGUMENTO
        }

        //gerando numero aleatório
        public int RollDice() 
        {
            int random = new Random().Next(1, NumSides + 1);
            return random;
        }
    }

    public void OnChangedOptions(object sender, EventArgs e)
    {
        int numside = (int)seletorQuantidadeLados.SelectedItem;
        Image image = new Image();
        diceImage.Source = ImageSource.FromFile($"dice_d{numside}.png");
    }

    private void OnSortearNumeroClicked(object sender, EventArgs e)
	{
        //Dice dice = new Dice(7); || Dice dice = new Dice(); Diferentes formas de instanciar a classe 
        int numSides = (Int32)seletorQuantidadeLados.SelectedItem; //casting --> altera a forma que o parametro é enxergado (convert)

        //seleciona valor picker como limitador
        Dice dice = new Dice(numSides); 
        
		//referenciando o método de sorteio a uma variavel
		var numeroSorteado = dice.RollDice();

		//Mostrando o numero na tela
		numberOutput.Text= numeroSorteado.ToString();
        diceImage.Source = ImageSource.FromFile($"dice_d{numSides}.png");
      
    }
}

