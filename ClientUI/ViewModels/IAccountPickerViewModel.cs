using System.Collections.ObjectModel;

namespace ClientUI.ViewModels;

public interface IAccountPickerViewModel {
    ObservableCollection<AccountViewModel> Accounts { get; set; }
}