WPFCustomMessageBoxAdv
=====================

*WPFCustomMessageBoxAdv* is a WPF clone of the native Windows/.NET MessageBox with many extra features.

I created this library because I wanted to use verbs for my MessageBox buttons to [help users better understand the functionality of the buttons](http://ux.stackexchange.com/a/9960/12349) - which isn't possible in the standard Windows MessageBox. With this library, you can offer your users button descriptions like `Save/Don't Save` or `Shutdown Reactor/Eject Spent Fuel Rods` rather than the standard `OK/Cancel` or `Yes/No` (although you can still use those too, if you like).

The WPFCustomMessageBoxAdv message boxes return [standard .NET DialogResults](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.dialogresult).

## Downloading and Installing ##

[WPFCustomMessageBoxAdv is available via NuGet](https://www.nuget.org/packages/WPFCustomMessageBoxAdv/).

## Usage ##

This documentation is still in progress, so in the meantime you can explore the `CustomMessageBoxDemo` project which should have a variety of demos.

WPFCustomMessageBoxAdv uses static methods just like the standard .NET MessageBox, so you can plug-and-play the new library without modifying any code. When you want to add custom text, just use the special methods outlined below.

**Standard .NET Message Box**


```csharp
MessageBox.Show("Hello World!", "This is the title of the MessageBox", MessageBoxButtons.OKCancel);
```

**WPFCustomMessageBoxAdv Equivalent**


```csharp
using WPFCustomMessageBoxAdv;

CustomMessageBox.Show("Hello World!", "This is the title of the MessageBox", MessageBoxButtons.OKCancel);
```

**Adding custom button text to WPFCustomMessageBoxAdv**

```csharp
using WPFCustomMessageBoxAdv;

CustomMessageBox.ShowOKCancel(
    "Are you sure you want to eject the nuclear fuel rods?",
    "Confirm Fuel Ejection",
    "Eject Fuel Rods",
    "Don't do it!");
```

**Custom Button Methods**

The WPFCustomMessageBoxAdv library provides customizable equivalents of all .NET MessageBox button types:

* `CustomMessageBox.Show()` - Standard MessageBox
* `CustomMessageBox.ShowOK()` - MessageBox with single customizable "OK" button. Returns `DialogResult.OK`.
* `CustomMessageBox.ShowOKCancel()` - MessageBox with customizable "OK" and "Cancel" buttons. Returns either `DialogResult.OK` or `DialogResult.Cancel`.
* `CustomMessageBox.ShowYesNo()` - MessageBox with customizable "Yes" and "No" buttons. Returns either `DialogResult.Yes` or `DialogResult.No`.
* `CustomMessageBox.ShowYesNoCancel()` - MessageBox with customizable "Yes", "No", and "Cancel" buttons. Returns either `DialogResult.Yes`, `DialogResult.No`, or `DialogResult.Cancel`.
* `CustomMessageBox.ShowRetryCancel()` - MessageBox with customizable "Retry", and "Cancel" buttons. Returns either `DialogResult.Retry`, `DialogResult.Cancel`.
* `CustomMessageBox.ShowAbortRetryIgnore()` - MessageBox with customizable "Abort", "Retry", and "Ignore" buttons. Returns either `DialogResult.Abort`, `DialogResult.Retry`, or `DialogResult.Ignore`.

**MessageBoxModel**

For maximum customization or live access to the message box while it is open (e.g. to update the displayed text), the class MessageBoModel can be used.
It allows to updates various widths and heights of UI components, button texts and much more.

**Removed features/changes compared to WPFCustomMessageBoxAdv**

* Removed support for keyboard accelerators
* System.Windows.Forms.MessageBox is being used for reference instead of System.Windows.MessageBox (more button options available by default)s


## License ##

**The MIT License**

Copyright (c) 2023 Kai Clemens Liebich / Evan Wondrasek

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
