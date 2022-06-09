using Darts.MAUI.App.Services;

namespace Darts.MAUI.App;

public partial class AuthPage : ContentPage
{
    int count = 0;

    public AuthPage() 
	{
		InitializeComponent();
        this.Title = "Login";
	}

    private async void OnLogin(object sender, EventArgs e)
    {
        string enteredEmail = EmailText.Text;
        string enteredPassword = PasswordText.Text;

        bool isAuthenticated = false;

        await AuthService.Login("test", "test");

        if (!isAuthenticated)
        {
            await this.DisplayAlert(
            "Wrong credentials",
            "Your credentials are wrong, please try again!",
            "OK");
            // TODO: empty password and close the dialog
            PasswordText.Text = "";
        }

        
    }
}