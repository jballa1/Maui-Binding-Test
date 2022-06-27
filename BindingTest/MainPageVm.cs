using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace BindingTest
{
    public partial class MainPageVm : ObservableObject
    {
        [ObservableProperty]
        int batch;
    }
}
