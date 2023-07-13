using System;
using Autofac;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using ClientUI.ViewModels;
using ClientUI.Views;
using Common;
using Common.Startup;
using Common.Utils;
using OpenSteamworks;

namespace ClientUI;

public partial class App : Application
{
    public new IClassicDesktopStyleApplicationLifetime ApplicationLifetime;
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override async void OnFrameworkInitializationCompleted()
    {
        // This hack lets us use ApplicationLifetime without having to cast it every time
        if (base.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime lifetime) {
            ApplicationLifetime = lifetime;
        } else {
            throw new Exception("Invalid lifetime");
        }
        ExtendedProgress<int> prog = new ExtendedProgress<int>(0, 100);
        
        var progressWindow = new ProgressWindow();
        progressWindow.SetViewModel(prog);
        //ApplicationLifetime.MainWindow = progressWindow;

        progressWindow.Show();
        Program.container = await StartupController.Startup<ClientUIAutofacRegistrar>(prog);
        progressWindow.Close();

        ApplicationLifetime.MainWindow = new MainWindow
        {
            DataContext = new MainWindowViewModel()
        };

        base.OnFrameworkInitializationCompleted();
    }

    public void Exit(int exitCode = 0) {
        ApplicationLifetime.Shutdown(exitCode);
    }
    
}