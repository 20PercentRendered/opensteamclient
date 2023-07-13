# Views
Views define the UI. They don't define any logic, that is driven by properties in ViewModels, which all views should bind to.
In something like a login window with multiple possible "sub-views" like an account picker and credential input, you can use a property in a ViewModel to define what View should be visible.