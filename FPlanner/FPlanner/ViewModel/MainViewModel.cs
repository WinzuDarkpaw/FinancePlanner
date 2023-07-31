using FPlanner.Async;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPlanner.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private string _appInfo;

        /// <summary>
        ///     Represents the app info or sets it.
        /// </summary>
        public string AppInfo
        {
            get => _appInfo;
            set => Set(nameof(AppInfo), ref _appInfo, value);
        }

        private AsyncCommand _testCommand;

        public AsyncCommand TestCommand =>
            _testCommand ?? (_testCommand = new AsyncCommand(TestMethod));

        /// <summary>
        ///     Initializes a new instance of the <see cref="MainViewModel"/>-class.
        /// </summary>
        public MainViewModel()
        {
            AppInfo = "TEST APP";
        }

        private async Task TestMethod()
        {
            await Task.Run(() => Console.WriteLine("TEST"));
        }
    }
}
