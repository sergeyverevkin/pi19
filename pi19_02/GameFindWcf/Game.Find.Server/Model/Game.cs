using System;
using System.Collections.Generic;
using System.Linq;

namespace Game.Find.Server.Model
{
  public class CGame
  {
    private Random m_pRand = new Random();
    public CGame()
    {
      PlayerList = new List<CPlayer>();
      Guid = new Guid().ToString("N");
      State = EGameState.GameWait;
      LastDateTime = DateTime.Now;
      Width = 100;
      Height = 100;

      ExitX = m_pRand.Next(0, Width);
      ExitY = m_pRand.Next(0, Height);
    }

    public int Width { get; set; }
    public int Height { get; set; }

    public DateTime LastDateTime { get; set; }

    public List<CPlayer> PlayerList { get; private set; }
    public string CurrentPlayer { get; set; }
    public EGameState State { get; set; }
    public string Guid { get; set; }
    public int ExitX { get; set; }
    public int ExitY { get; set; }

    public double GetDistance(string sPlayer)
    {
      CPlayer pP = PlayerList.First(p => p.Guid == sPlayer);
      return Math.Sqrt(
        (pP.X - ExitX) * (pP.X - ExitX) + 
        (pP.Y - ExitY) * (pP.Y - ExitY));
    }

    public bool AddPlayer(string sPlayer)
    {
      if (State == EGameState.GameWait) {
        LastDateTime = DateTime.Now;
        CPlayer pPlayer = new CPlayer(sPlayer);

        pPlayer.X = m_pRand.Next(0, Width);
        pPlayer.Y = m_pRand.Next(0, Height);

        PlayerList.Add(pPlayer);
        if (PlayerList.Count == 2) {
          State = EGameState.GameProcess;
        }
        return true;
      }

      return false;
    }

    public bool Turn(string sPlayer, ETurn enTurn)
    {
      CPlayer pPl = PlayerList.First(p => p.Guid == sPlayer);
      if (State == EGameState.GameProcess) {
        pPl.Turn(enTurn);
        if (pPl.X == ExitX && pPl.Y == ExitY)
        {
          CurrentPlayer = sPlayer;
          State = EGameState.GameOver;
        }

        return true;
      }

      return false;
    }

    public void EndGame()
    {
      State = EGameState.GameOver;
    }
  }
}