using MyPasswordManagerTutoriel.Views;

namespace MyPasswordManagerTutoriel
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(LoginCredentialItemPage), typeof(LoginCredentialItemPage));
        }
    }
}