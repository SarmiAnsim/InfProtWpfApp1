// Updated by XamlIntelliSenseFileGenerator 25.09.2021 17:37:22
#pragma checksum "..\..\..\Theme\MyListViewTheme.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C1FE860838263CED0CD5FEFA9593733B4942C47D4072DD63179C25A57C5987F9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;

namespace clr-namespace:InfProtWpfApp1.MVVM.ViewModel-namespace:InfProtWpfApp1.MVVM.ViewModel-namespace:InfProtWpfApp1.MVVM.ViewModel
{
    /// <summary>
    /// UsersViewModel
    /// </summary>
    public partial class UsersViewModel : System.Windows.ResourceDictionary, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector
{

    private bool _contentLoaded;

    /// <summary>
    /// InitializeComponent
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
        if (_contentLoaded)
        {
            return;
        }
        _contentLoaded = true;
        System.Uri resourceLocater = new System.Uri("/InfProtWpfApp1;component/theme/mylistviewtheme.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Theme\MyListViewTheme.xaml"
        System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
    }

    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
    void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
    {
        this._contentLoaded = true;
    }

    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
    void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
    {
        switch (connectionId)
        {
            case 1:

#line 41 "..\..\..\Theme\MyListViewTheme.xaml"
                ((System.Windows.Controls.CheckBox)(target)).Click += new System.Windows.RoutedEventHandler(this.UserChangedCommand);

#line default
#line hidden
                break;
            case 2:

#line 66 "..\..\..\Theme\MyListViewTheme.xaml"
                ((System.Windows.Controls.CheckBox)(target)).Click += new System.Windows.RoutedEventHandler(this.UserChangedCommand);

#line default
#line hidden
                break;
        }
    }
}
}