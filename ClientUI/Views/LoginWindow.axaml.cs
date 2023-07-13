using Avalonia.Controls;
using ClientUI.ViewModels;

namespace ClientUI.Views;

public partial class LoginWindow : Window
{
    public LoginWindow()
    {
        InitializeComponent();
        this.DataContext = new LoginWindowViewModel();
    }
}