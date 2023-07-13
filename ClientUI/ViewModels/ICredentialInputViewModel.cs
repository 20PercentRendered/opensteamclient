using System.Collections.ObjectModel;

namespace ClientUI.ViewModels;

public interface ICredentialInputViewModel {
    public string Username { get; set; }
    public string Password { get; set; }
    public bool RememberPassword { get; set; }
}