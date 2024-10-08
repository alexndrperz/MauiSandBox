using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace MauiApp1.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty] public bool _isBusy;
        [ObservableProperty] public bool _title;
    }
}
