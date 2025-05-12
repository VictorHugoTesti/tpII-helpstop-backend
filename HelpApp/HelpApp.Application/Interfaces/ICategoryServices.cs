
namespace HelpApp.Application.Interfaces
{
    internal interface ICategoryServices
    {
        Task<IEnumerable<CategoryDTo>> GetFategory();
    }
}
