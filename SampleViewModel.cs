using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;

namespace MyTouchEffect
{
    public class SampleViewModel : ObservableObject
    {
        int count;
        ICommand increaseCommand;
        ICommand increaseByTenCommand;


        public int Count
        {
            get => count;
            set => SetProperty(ref count, value);
        }

        public ICommand IncreaseCommand => increaseCommand ??= new Command(() =>
        {
            Count++;
        });

        public ICommand IncreaseByTenCommand => increaseByTenCommand ??= new Command(() => Count += 10);
    }
}
