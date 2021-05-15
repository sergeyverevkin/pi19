using Game.Find.Server;
using System;
using Game.Find;

namespace GameFindServer
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      ILogger pLogger = new CConsoleLogger();

      string sUrlService = "http://127.0.0.1:8000/GameFind";
      ServerHost<CGameFind, IGameFind> pHost = new ServerHost<CGameFind, IGameFind>(sUrlService);
      CGameFind.SetLogger(pLogger);
      pHost.Start();

      pLogger.Write("Press any key to stop");
      Console.ReadKey(true);
    }
  }
}
