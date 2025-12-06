using MauiPlanets.Models;


namespace MauiPlanets.Views;

public partial class PlanetDetailsPage : ContentPage
{
	public PlanetDetailsPage(Planet planet)
	{
		InitializeComponent();

		this.BindingContext = planet;
	}
    
	protected override void OnAppearing()
    {
        base.OnAppearing();
        this.InvalidateMeasure();
        this.ForceLayout();
    }
    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
		await Navigation.PopAsync();
    }
}