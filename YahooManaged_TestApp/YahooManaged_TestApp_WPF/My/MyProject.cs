// Decompiled with JetBrains decompiler
// Type: YahooManaged_TestApp_WPF.My.MyProject
// Assembly: YahooManaged_TestApp_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA8C4AB2-267A-4FEE-8822-9CB917E02609
// Assembly location: C:\StockAnalysis\YahooFinaceManaged\Yahoo Managed Showcase\YahooManaged_TestApp_WPF.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace YahooManaged_TestApp_WPF.My
{
  [StandardModule]
  [GeneratedCode("MyTemplate", "10.0.0.0")]
  [HideModuleName]
  internal sealed class MyProject
  {
    [ComVisible(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class ThreadSafeObjectProvider<T> where T : new()
    {
      internal T GetInstance
      {
        [DebuggerHidden] get
        {
          if ((object) MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
            MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
          return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
        }
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public ThreadSafeObjectProvider()
      {
      }
    }
  }
}
