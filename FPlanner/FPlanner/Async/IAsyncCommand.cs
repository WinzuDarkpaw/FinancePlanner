using System.Threading.Tasks;
using System.Windows.Input;

namespace FPlanner.Async
{
    public interface IAsyncCommand : ICommand
    {
        Task ExecuteAsync(object parameter);
    }
}
