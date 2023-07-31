using System;
using System.ComponentModel;
using MvvmDialogs.DialogTypeLocators;

namespace FPlanner.Model
{
    public class DialogTypeLocator : IDialogTypeLocator
    {
        /// <summary>
        ///     Locates a dialog type based on the specified view model.
        /// </summary>
        public Type Locate(INotifyPropertyChanged viewModel)
        {
            Type vmType = viewModel.GetType();

            string vmName = vmType.FullName;

            if (vmName == null)
            {
                throw new Exception("Type name not available.");
            }

            string vName = vmName.Replace("ViewModel", "View");

            return vmType.Assembly.GetType(vName);
        }
    }
}