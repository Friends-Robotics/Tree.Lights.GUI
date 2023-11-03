using System.ComponentModel;

namespace Tree_Lights_GUI.ViewModel;

public abstract class ViewModelBase : INotifyPropertyChanged {
    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged(string propertyName) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
