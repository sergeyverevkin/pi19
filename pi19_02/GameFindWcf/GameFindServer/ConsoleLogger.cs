using System;
using Game.Find.Server;

namespace GameFindServer
{
  internal class CConsoleLogger : Game.Find.Server.ILogger
  {
    public void WriteError(string sErrorText)
    {
      Console.WriteLine($"[ERROR] {sErrorText}");
    }

    public void Write(string sText)
    {
      Console.WriteLine($"[INFO] {sText}");
    }
  }
}