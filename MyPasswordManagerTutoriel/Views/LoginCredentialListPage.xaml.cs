using MyPasswordManagerTutoriel.Data;
using MyPasswordManagerTutoriel.Models;

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

    private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    private async void OnItemAdd(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(LoginCredentialItemPage), true, new Dictionary<string, object>
        {
            ["Item"] = new LoginCredential()
        });
    }
}