using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Notes
{
    public class DetailPageViewModel:INotifyPropertyChanged
    {
        public DetailPageViewModel()
        {
            ExitCommand = new Command(async() => await Application.Current.MainPage.Navigation.PopAsync());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string noteText;
        public string NoteText
        {
            get => noteText;

            set
            {
                noteText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NoteText)));
            }

        }

        public Command ExitCommand { get; }
    }
}
