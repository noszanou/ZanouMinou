using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaTool.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _greeting = "Kewk";
}
