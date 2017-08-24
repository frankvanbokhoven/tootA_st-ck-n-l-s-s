// Decompiled with JetBrains decompiler
// Type: YahooManaged_TestApp_WPF.My.MyWpfExtension
// Assembly: YahooManaged_TestApp_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA8C4AB2-267A-4FEE-8822-9CB917E02609
// Assembly location: C:\StockAnalysis\YahooFinaceManaged\Yahoo Managed Showcase\YahooManaged_TestApp_WPF.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;

namespace YahooManaged_TestApp_WPF.My
{
  [HideModuleName]
  [StandardModule]
  internal sealed class MyWpfExtension
  {
    private static MyProject.ThreadSafeObjectProvider<Computer> s_Computer = new MyProject.ThreadSafeObjectProvider<Computer>();
    private static MyProject.ThreadSafeObjectProvider<User> s_User = new MyProject.ThreadSafeObjectProvider<User>();
    private static MyProject.ThreadSafeObjectProvider<MyWpfExtension.MyWindows> s_Windows = new MyProject.ThreadSafeObjectProvider<MyWpfExtension.MyWindows>();
    private static MyProject.ThreadSafeObjectProvider<Microsoft.VisualBasic.Logging.Log> s_Log = new MyProject.ThreadSafeObjectProvider<Microsoft.VisualBasic.Logging.Log>();

    internal static YahooManaged_TestApp_WPF.Application Application
    {
      get
      {
        return (YahooManaged_TestApp_WPF.Application) System.Windows.Application.Current;
      }
    }

    internal static Computer Computer
    {
      get
      {
        return MyWpfExtension.s_Computer.GetInstance;
      }
    }

    internal static User User
    {
      get
      {
        return MyWpfExtension.s_User.GetInstance;
      }
    }

    internal static Microsoft.VisualBasic.Logging.Log Log
    {
      get
      {
        return MyWpfExtension.s_Log.GetInstance;
      }
    }

    internal static MyWpfExtension.MyWindows Windows
    {
      [DebuggerHidden] get
      {
        return MyWpfExtension.s_Windows.GetInstance;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [MyGroupCollection("System.Windows.Window", "Create__Instance__", "Dispose__Instance__", "My.MyWpfExtenstionModule.Windows")]
    internal sealed class MyWindows
    {
      public Window1 m_Window1;
      [ThreadStatic]
      private static Hashtable s_WindowBeingCreated;

      public Window1 Window1
      {
        get
        {
          this.m_Window1 = MyWpfExtension.MyWindows.Create__Instance__<Window1>(this.m_Window1);
          return this.m_Window1;
        }
        set
        {
          if (value == this.m_Window1)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Window1>(ref this.m_Window1);
        }
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public MyWindows()
      {
      }

      [DebuggerHidden]
      private static T Create__Instance__<T>(T Instance) where T : Window, new()
      {
        if ((object) Instance != null)
          return Instance;
        if (MyWpfExtension.MyWindows.s_WindowBeingCreated != null)
        {
          if (MyWpfExtension.MyWindows.s_WindowBeingCreated.ContainsKey((object) typeof (T)))
            throw new InvalidOperationException("The window cannot be accessed via My.Windows from the Window constructor.");
        }
        else
          MyWpfExtension.MyWindows.s_WindowBeingCreated = new Hashtable();
        MyWpfExtension.MyWindows.s_WindowBeingCreated.Add((object) typeof (T), (object) null);
        return Activator.CreateInstance<T>();
      }

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance) where T : Window
      {
        instance = default (T);
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override bool Equals(object o)
      {
        return base.Equals(RuntimeHelpers.GetObjectValue(o));
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override int GetHashCode()
      {
        return base.GetHashCode();
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      internal new Type GetType()
      {
        return typeof (MyWpfExtension.MyWindows);
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override string ToString()
      {
        return base.ToString();
      }
    }
  }
}
