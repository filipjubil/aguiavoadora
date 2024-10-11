namespace aguiavoadora;

public partial class MainPage : ContentPage
{
	const int granidade=1;//px/ms
	const int tempoEntreFrames=25;//ms
	bool estaMorto=false; 
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}
void Aplica Gravidade()
{
	img pardol.Translation y+= gravidade;
}
    protected override void OnAppearing()
    {
        base.OnAppearing();
		desenha();
    }
    private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

