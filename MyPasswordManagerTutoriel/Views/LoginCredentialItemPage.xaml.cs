using MyPasswordManagerTutoriel.Data;
using MyPasswordManagerTutoriel.Models;

namespace MyPasswordManagerTutoriel.Views;

[QueryProperty("Item", "Item")]
public partial class LoginCredentialItemPage : ContentPage
{
	private readonly Database database;

	public LoginCredential Item
	{
		get => BindingContext as LoginCredential;
		set => BindingContext = value;
	}

	public LoginCredentialItemPage(Database database)
	{
		InitializeComponent();

		this.database = database;
    }
}