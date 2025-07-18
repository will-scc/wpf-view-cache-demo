using System.Windows;
using WpfApp1.Interfaces;

namespace WpfApp1.Services;

internal static class WindowService
{
    public static void OpenNewWindow(IViewModel vm)
    {
        Window win = new()
        {
            Title = vm.Title,
            Content = vm,
            Height = 450,
            Width = 800
        };

        win.Show();
    }
}
