using MyPasswordManagerTutoriel.Data;

namespace MyPasswordManagerTutoriel.Views;

public partial class LoginCredentialListPage : ContentPage
{
    private readonly Database database;
    int count = 0;

    public LoginCredentialListPage(Database database)
    {
        InitializeComponent();

        this.database = database;
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