using FoxRedCompany.Models;


namespace FoxRedCompany.Views;

public partial class PaginaInicio : ContentPage
{
	public PaginaInicio()
	{
		InitializeComponent();

        var items = new List<CollectionItem>
        {
            new CollectionItem{Imagen ="sa.jpg", Title="Coding Droplets", Description="Welcome to coding droplets"},
            new CollectionItem{Imagen ="fo.png",  Title="Title 2", Description="Description 2"},
            new CollectionItem{Imagen = "li.jpg", Title="Title 3", Description="Description 3"},
            new CollectionItem{Imagen ="sev.jpg", Title="Title 4", Description="Description 4"},
            new CollectionItem{Imagen = "sw.jpg", Title="Title 5", Description="Description 5"},
            new CollectionItem{Imagen = "zu.jpg", Title="Title 5", Description="Description 5"}
        };
        carouselView.ItemsSource = items;

    }
}