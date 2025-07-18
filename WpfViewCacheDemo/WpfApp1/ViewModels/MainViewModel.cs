using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WpfApp1.Interfaces;
using WpfApp1.Services;

namespace WpfApp1.ViewModels;
internal partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private IViewModel? loadedVm;

    [RelayCommand]
    private void OpenExampleViewModel()
    {
        if (this.LoadedVm is not null)
        {
            return;
        }

        this.LoadedVm = new ExampleViewModel();
    }

    [RelayCommand]
    private void MoveExampleViewModel()
    {
        if (this.LoadedVm is null)
        {
            return;
        }

        // Open the loaded ViewModel in a new window
        WindowService.OpenNewWindow(this.LoadedVm);

        // Clear the loaded VM after moving it to a new window
        this.LoadedVm = null;
    }
}
