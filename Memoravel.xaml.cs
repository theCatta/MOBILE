namespace AulaTres;

public partial class Memoravel : ContentPage
{
	int count = 0;

	public Memoravel()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

	}
}

