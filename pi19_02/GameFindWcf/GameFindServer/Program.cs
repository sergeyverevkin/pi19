using Game.Find.Server;
using System;
using Game.Find;

namespace GameFindServer
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      string sUrlService = "http://127.0.0.1:8000/GameFind";
      ServerHost<CGameFind, IGameFind> pHost = new ServerHost<CGameFind, IGameFind>(sUrlService);
      pHost.Start();
      Console.WriteLine("Press any key to stop");
      Console.ReadKey(true);
    }
  }
}
