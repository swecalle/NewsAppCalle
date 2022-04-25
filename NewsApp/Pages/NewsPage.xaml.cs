using NewsApp.Models;
using NewsApp.Services;

namespace NewsApp;

public partial class NewsPage : ContentPage
{
    public List<Article> ArticlesList { get; set; }




	public NewsPage()
	{
		InitializeComponent();
        ArticlesList = new List<Article>();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        ApiService apiService = new ApiService();
        apiService.GetNews();
        var newsResult = await apiService.GetNews();
        foreach (var item in newsResult.Articles)
        {
            ArticlesList.Add(item);
        }


    }
    //protected override void OnDisappearing()
    //{
    //    base.OnDisappearing();
    //}
}