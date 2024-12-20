using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaTool.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private string? _greeting;

    partial void OnGreetingChanged(string? oldValue, string? newValue)
    {
        if (string.IsNullOrWhiteSpace(newValue))
        {
            Greeting = "Empty";
        }
    }
}
