using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

/* Why using WPF:
 * A. Wny where Execution (XAML), dscription create UI could run any where in windows and web.
 * B. Binding for two object to transfor each other without code.
 * C. Common look & feel (Styles).
 * D. Directive Programming
 * E. Expression blend and Animation
 * F. Faster Exection (Hardware Rendering), WPF using DirectX and using GPU/ WinForm uisng GDI cpu
 * G. Graphic Independency (DIP)
 * 
 * 
 * MVVM
 * Viwe: UI only
 * Module: data, bussiness logic. nothing to UI.
 * View Module: data binding UI and logical
 * Disign code lose conncetion. Moduels, Views, ViewModules.
 * 
 */ 

namespace MixwellWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
    }
}
