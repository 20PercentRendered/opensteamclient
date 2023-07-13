using System.Collections.ObjectModel;

namespace ClientUI.ViewModels;

public class LoginWindowViewModel : ReactiveViewModel, IAccountPickerViewModel, ICredentialInputViewModel
{
    public ObservableCollection<AccountViewModel> Accounts { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public bool RememberPassword { get; set; }

    public bool HasSavedAccounts { 
        get {
            return this.Accounts.Count > 0;
        }
    } 

    public void OnClosed() {
        
    }
}
