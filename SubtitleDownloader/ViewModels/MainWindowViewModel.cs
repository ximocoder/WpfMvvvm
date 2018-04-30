using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using SubtitleDownloader.Models;

namespace SubtitleDownloader.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool canExecute = true;


        public bool CanExecute
        {
            get
            {
                return this.canExecute;
            }

            set
            {
                if (this.canExecute == value)
                {
                    return;
                }

                this.canExecute = value;
            }
        }

        private ICommand searchCommand;
        public ICommand SearchCommand
        {
            get => searchCommand;
            set => searchCommand = value;
        }

        private string _subtitleContent;
        public string SubtitleContent
        {
            get => _subtitleContent;
            set
            {
                _subtitleContent = value;
                OnPropertyChanged();
            } 
        }

        public MainWindowViewModel()
        {
            SubtitleContent = string.Empty;
            searchCommand = new RelayCommand(SearchSubtitle, param => this.canExecute);
        }

        private void SearchSubtitle(object obj)
        {
            var content = new Subtitle().Content;
            SubtitleContent = content;
        }


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}