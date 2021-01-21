using System;
using System.ComponentModel;
using System.Windows.Data;

namespace Case04
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _input = "hello world!!";
        private string _output = "HELLO WORLD!!";

        public event PropertyChangedEventHandler PropertyChanged;

        public string Input
        {
            get
            {
                return _input;
            }
            set
            {
                _input = value;
                Output = value.ToUpper();
            }
        }
        public string Output
        {
            get
            {
                return _output;
            }
            set
            {
                _output = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Output)));
            }
        }
    }
}
