namespace LocalizationTest;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		DateLabel.Text = DateTime.Now.ToString();
	}

	private void OnButtonClicked(object sender, EventArgs e)
	{
		if(System.Globalization.CultureInfo.CurrentCulture.Name.Contains("en"))
		{
            System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo("ar");
            System.Globalization.CultureInfo.CurrentUICulture = new System.Globalization.CultureInfo("ar");
        }
		else
		{
            System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo("en");
            System.Globalization.CultureInfo.CurrentUICulture = new System.Globalization.CultureInfo("en");
        }
		// Refresh
		Application.Current.MainPage = new AppShell();
    }
}

