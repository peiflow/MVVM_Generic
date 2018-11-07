using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using ModuleGeneric.ViewModel;

namespace MVVM_Generic.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<ShellViewModel>();
            SimpleIoc.Default.Register<GenericModuleViewModel>();
        }

        public ShellViewModel Shell
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ShellViewModel>();
            }
        }

        public GenericModuleViewModel GenericModule
        {
            get
            {
                return ServiceLocator.Current.GetInstance<GenericModuleViewModel>();
            }
        }

        public GenericModuleViewModel GenericModule
        {
            get
            {
                return ServiceLocator.Current.GetInstance<GenericModuleViewModel>();
            }
        }
        
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}