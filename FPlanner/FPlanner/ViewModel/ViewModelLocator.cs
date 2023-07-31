using FPlanner.Properties;
using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using MvvmDialogs;
using FPlanner.Model;

namespace FPlanner.ViewModel
{
    /// <summary>
    ///     Diese Klasse beinhaltet statische Referenzen zu allen ViewModels in der
    ///     Anwendung und bietet einen Einstiegspunkt für alle Bindings an.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        ///     Initialisiert eine neue Instanz der <see cref="ViewModelLocator" />-Klasse.
        /// </summary>
        static ViewModelLocator()
        {
            // Ioc-Container zurücksetzen und neu initialisieren.
            SimpleIoc.Default.Reset();
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            // Dialogservice registrieren.
            SimpleIoc.Default.Register<IDialogService>(
                () => new DialogService(dialogTypeLocator: new DialogTypeLocator()));

            // ViewModel registrieren.
            SimpleIoc.Default.Register<MainViewModel>();
        }

        /// <summary>
        ///     ActivationException: Type not found in cache: CleanUpApplication.Database.Job.
        ///     Gibt die einzige Instanz der <see cref="MainViewModel" />-Klasse zurück.
        /// </summary>
        public MainViewModel Main
        {
            get { return ServiceLocator.Current.GetInstance<MainViewModel>(); }
        }
    }
}