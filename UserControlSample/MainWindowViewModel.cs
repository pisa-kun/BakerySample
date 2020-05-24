using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControlSample
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string input = "Default Message";
        public string Input
        {
            get => input;
            set
            {
                input = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Input)));
            }
        }

    }
}
