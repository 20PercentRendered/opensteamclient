using Common.Utils;
using ReactiveUI;

namespace ClientUI.ViewModels;

public class ProgressWindowViewModel : ReactiveViewModel
{
    public bool Throbber => _progress.Throbber;
    public int InitialProgress => _progress.InitialProgress;
    public int Progress => _progress.Progress;
    public int MaxProgress => _progress.MaxProgress;
    public string Operation => _progress.Operation;
    public string SubOperation => _progress.SubOperation;
    ExtendedProgress<int> _progress;
    public ProgressWindowViewModel(ExtendedProgress<int> prog) {
        _progress = prog;
        _progress.ProgressChanged += (object? sender, int newProgress) => {
            this.RaisePropertyChanged("Throbber");
            this.RaisePropertyChanged("Progress");
            this.RaisePropertyChanged("MaxProgress");
            this.RaisePropertyChanged("Operation");
            this.RaisePropertyChanged("SubOperation");
        };
        
    }
}
