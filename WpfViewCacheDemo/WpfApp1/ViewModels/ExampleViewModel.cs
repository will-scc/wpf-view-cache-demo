using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using WpfApp1.Interfaces;

namespace WpfApp1.ViewModels;

internal partial class ExampleViewModel : ObservableObject, IViewModel
{
    [ObservableProperty]
    private string title = "Example ViewModel";

    [ObservableProperty]
    private ObservableCollection<string> items = [];

    public ExampleViewModel()
    {
        for (int i = 0; i < 100; i++)
        {
            this.Items.Add(Guid.NewGuid().ToString());
        }
    }
}
