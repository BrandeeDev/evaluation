namespace BNP.SensiorTesting.Api.ViewModels;


public class AuthorViewModel
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<string> BookTitles { get; set; }
}