// Decompiled with JetBrains decompiler
// Type: YahooManaged_TestApp_WPF.Application
// Assembly: YahooManaged_TestApp_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA8C4AB2-267A-4FEE-8822-9CB917E02609
// Assembly location: C:\StockAnalysis\YahooFinaceManaged\Yahoo Managed Showcase\YahooManaged_TestApp_WPF.exe

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;

namespace YahooManaged_TestApp_WPF
{
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public class Application : System.Windows.Application
  {
    internal AssemblyInfo Info
    {
      [DebuggerHidden] get
      {
        return new AssemblyInfo(Assembly.GetExecutingAssembly());
      }
    }

    [DebuggerNonUserCode]
    public void InitializeComponent()
    {
      this.StartupUri = new Uri("Window1.xaml", UriKind.Relative);
    }

    [STAThread]
    [DebuggerNonUserCode]
    public static void Main()
    {
      Application application = new Application();
      application.InitializeComponent();
      application.Run();
    }
  }
}
