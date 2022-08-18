namespace MauiApp1.Pages;

public partial class BotPage
{
    int _count = 0;

    public BotPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        _count++;

        CounterBtn.Text = $"Clicked {_count} times{(_count > 1 ? string.Empty: 's')}";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}