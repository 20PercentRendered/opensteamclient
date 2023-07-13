using Avalonia.Controls;
using ClientUI.ViewModels;
using Common.Utils;

namespace ClientUI.Views;

public partial class ProgressWindow : Window
{
    public ProgressWindow()
    {
        InitializeComponent();
    }
    public void SetViewModel(ExtendedProgress<int> prog) {
        this.DataContext = new ProgressWindowViewModel(prog);
    }
}