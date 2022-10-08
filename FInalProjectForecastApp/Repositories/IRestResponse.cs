namespace ForecastApp.Repositories
{
    internal interface IRestResponse
    {
        bool IsSuccessful { get; set; }
        string Content { get; set; }
    }
}