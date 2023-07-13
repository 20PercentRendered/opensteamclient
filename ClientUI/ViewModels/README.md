# ViewModels
ViewModels drive the View's and provide data they can bind to.
All actions View's perform should change data on the ViewModel, which should then change the Model (application logic)

# I-prefixed ViewModels
ViewModels prefixed with "I" should be implemented by whatever embeds that ViewModel's view, such as a Login Window which uses an account picker should implement IAccountPickerViewModel.
This lets all the data be defined in that Window and lets us not have to worry about creating UI logic for all the small bits.