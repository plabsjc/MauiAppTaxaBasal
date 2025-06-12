

namespace MauiAppTaxaBasal.Views;
public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
       

    }
    bool isPasswordVisible = false;
    private void PasswordViewButton_Clicked(object sender, EventArgs e)
    {
        isPasswordVisible = !isPasswordVisible;

        PasswordEntry.IsPassword = !isPasswordVisible;

        PasswordViewButton.Source = isPasswordVisible
            ? "olho_open.png"
            : "olho_closed.png";
    }
}