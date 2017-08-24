// Decompiled with JetBrains decompiler
// Type: YahooManaged_TestApp_WPF.Window1
// Assembly: YahooManaged_TestApp_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA8C4AB2-267A-4FEE-8822-9CB917E02609
// Assembly location: C:\StockAnalysis\YahooFinaceManaged\Yahoo Managed Showcase\YahooManaged_TestApp_WPF.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using YahooManaged_TestApp_WPF_Controls.FinanceCtrl;

namespace YahooManaged_TestApp_WPF
{
  [DesignerGenerated]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public partial class Window1 : Window, IComponentConnector
  {
    [AccessedThroughProperty("YFinanceCtrl1")]
    private YFinanceCtrl _YFinanceCtrl1;
    [AccessedThroughProperty("Grid1")]
    private Grid _Grid1;
    [AccessedThroughProperty("TextBlock1")]
    private TextBlock _TextBlock1;
    [AccessedThroughProperty("TextBlock2")]
    private TextBlock _TextBlock2;
    [AccessedThroughProperty("TextBlock3")]
    private TextBlock _TextBlock3;
    [AccessedThroughProperty("TextBlock4")]
    private TextBlock _TextBlock4;
    [AccessedThroughProperty("txtVersion")]
    private TextBlock _txtVersion;
    [AccessedThroughProperty("btnDonate")]
    private Button _btnDonate;
    [AccessedThroughProperty("btnSupport")]
    private Button _btnSupport;
    [AccessedThroughProperty("TextBlock5")]
    private TextBlock _TextBlock5;
    [AccessedThroughProperty("btnHomepage")]
    private Button _btnHomepage;
    private bool _contentLoaded;

    internal virtual YFinanceCtrl YFinanceCtrl1
    {
      get
      {
        return this._YFinanceCtrl1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._YFinanceCtrl1 = value;
      }
    }

    internal virtual Grid Grid1
    {
      get
      {
        return this._Grid1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Grid1 = value;
      }
    }

    internal virtual TextBlock TextBlock1
    {
      get
      {
        return this._TextBlock1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBlock1 = value;
      }
    }

    internal virtual TextBlock TextBlock2
    {
      get
      {
        return this._TextBlock2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBlock2 = value;
      }
    }

    internal virtual TextBlock TextBlock3
    {
      get
      {
        return this._TextBlock3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBlock3 = value;
      }
    }

    internal virtual TextBlock TextBlock4
    {
      get
      {
        return this._TextBlock4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBlock4 = value;
      }
    }

    internal virtual TextBlock txtVersion
    {
      get
      {
        return this._txtVersion;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtVersion = value;
      }
    }

    internal virtual Button btnDonate
    {
      get
      {
        return this._btnDonate;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        RoutedEventHandler routedEventHandler = new RoutedEventHandler(this.btnDonate_Click);
        if (this._btnDonate != null)
          this._btnDonate.Click -= routedEventHandler;
        this._btnDonate = value;
        if (this._btnDonate == null)
          return;
        this._btnDonate.Click += routedEventHandler;
      }
    }

    internal virtual Button btnSupport
    {
      get
      {
        return this._btnSupport;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        RoutedEventHandler routedEventHandler = new RoutedEventHandler(this.btnSupport_Click);
        if (this._btnSupport != null)
          this._btnSupport.Click -= routedEventHandler;
        this._btnSupport = value;
        if (this._btnSupport == null)
          return;
        this._btnSupport.Click += routedEventHandler;
      }
    }

    internal virtual TextBlock TextBlock5
    {
      get
      {
        return this._TextBlock5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBlock5 = value;
      }
    }

    internal virtual Button btnHomepage
    {
      get
      {
        return this._btnHomepage;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        RoutedEventHandler routedEventHandler = new RoutedEventHandler(this.btnHomepage_Click);
        if (this._btnHomepage != null)
          this._btnHomepage.Click -= routedEventHandler;
        this._btnHomepage = value;
        if (this._btnHomepage == null)
          return;
        this._btnHomepage.Click += routedEventHandler;
      }
    }

    public Window1()
    {
      this.Loaded += new RoutedEventHandler(this.Window_Loaded);
      this.InitializeComponent();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      this.txtVersion.Text = AssemblyName.GetAssemblyName(Path.Combine(new FileInfo(Assembly.GetExecutingAssembly().Location).Directory.FullName, "MaasOne.YahooManaged.dll")).Version.ToString();
    }

    private void btnDonate_Click(object sender, RoutedEventArgs e)
    {
      Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=872N4R6HAL9KJ");
    }

    private void btnSupport_Click(object sender, RoutedEventArgs e)
    {
      Process.Start("http://code.google.com/p/yahoo-finance-managed/issues/list");
    }

    private void btnHomepage_Click(object sender, RoutedEventArgs e)
    {
      Process.Start("http://code.google.com/p/yahoo-finance-managed/");
    }

    [DebuggerNonUserCode]
    public void InitializeComponent()
    {
      if (this._contentLoaded)
        return;
      this._contentLoaded = true;
      System.Windows.Application.LoadComponent((object) this, new Uri("/YahooManaged_TestApp_WPF;component/window1.xaml", UriKind.Relative));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerNonUserCode]
    public void System_Windows_Markup_IComponentConnector_Connect(int connectionId, object target)
    {
      if (connectionId == 1)
        this.YFinanceCtrl1 = (YFinanceCtrl) target;
      else if (connectionId == 2)
        this.Grid1 = (Grid) target;
      else if (connectionId == 3)
        this.TextBlock1 = (TextBlock) target;
      else if (connectionId == 4)
        this.TextBlock2 = (TextBlock) target;
      else if (connectionId == 5)
        this.TextBlock3 = (TextBlock) target;
      else if (connectionId == 6)
        this.TextBlock4 = (TextBlock) target;
      else if (connectionId == 7)
        this.txtVersion = (TextBlock) target;
      else if (connectionId == 8)
        this.btnDonate = (Button) target;
      else if (connectionId == 9)
        this.btnSupport = (Button) target;
      else if (connectionId == 10)
        this.TextBlock5 = (TextBlock) target;
      else if (connectionId == 11)
        this.btnHomepage = (Button) target;
      else
        this._contentLoaded = true;
    }
  }
}
