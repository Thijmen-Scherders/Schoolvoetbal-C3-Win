using ultiemhoofdpijn.Model;
using GalaSoft.MvvmLight;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using System.Diagnostics;

namespace ultiemhoofdpijn.ViewModel
{
    public class ApplicationViewModel : Microsoft.Toolkit.Mvvm.ComponentModel.ObservableObject
    {
        private int c3coin;
        public int C3COIN
        {
            get { return c3coin; }
            set { c3coin = value; Debug.WriteLine($"C3COIN now: {c3coin}");}
        }

        public int amount;
        public int Amount
        {
            get { return amount; }
            set { amount = value; }

        }
        public ICommand BettingCommand { get; }

        private void Betting()
        {
            C3COIN = C3COIN - Amount;
            Debug.WriteLine(Amount);
            Debug.WriteLine(C3COIN);
            Debug.WriteLine(c3coin);
        }
        public ApplicationViewModel()
        {
            BettingCommand = new RelayCommand(Betting);
            c3coin = 150;
        }



    }
}
