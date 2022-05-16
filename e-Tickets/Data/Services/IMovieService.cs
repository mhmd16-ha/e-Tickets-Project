using e_Tickets.Data.Base;
using e_Tickets.Data.ViewModels;
using e_Tickets.Models;
using System.Threading.Tasks;

namespace e_Tickets.Data.Services
{
    public interface IMovieService: IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task UpdateMovieAsync(NewMovieVM data);
        Task AddNewMovieAsync(NewMovieVM data);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();

    }
}
