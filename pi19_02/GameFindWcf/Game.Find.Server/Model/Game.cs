using System;
using System.Collections.Generic;
using System.Linq;

namespace Game.Find.Server.Model
{
  /// <summary>
  /// Класс игры
  /// </summary>
  public class CGame
  {
    #region private variables

    private const int MaxPlayerCount = 2;
    private Random m_pRand = new Random();

    #endregion

    #region constructors

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

    #endregion

    #region public properties
    /// <summary>
    /// Ширина игрового поля
    /// </summary>
    public int Width { get; set; }
    /// <summary>
    /// Высота игрового поля
    /// </summary>
    public int Height { get; set; }
    /// <summary>
    /// Дата активности игры: если ее бросили, то она насильно завершается (очистка)
    /// </summary>
    public DateTime LastDateTime { get; set; }
    /// <summary>
    /// Список участников игры
    /// </summary>
    public List<CPlayer> PlayerList { get; private set; }
    /// <summary>
    /// Текущий игрок: заполняется для победителя при состоянии игры "окончена"
    /// </summary>
    public string CurrentPlayer { get; set; }
    /// <summary>
    /// Состояние игры
    /// </summary>
    public EGameState State { get; set; }
    /// <summary>
    /// Идентификатор игры
    /// </summary>
    public string Guid { get; set; }
    /// <summary>
    /// Координаты выхода
    /// </summary>
    public int ExitX { get; set; }
    /// <summary>
    /// Координаты выхода
    /// </summary>
    public int ExitY { get; set; }
    /// <summary>
    /// Можно ли присоединиться к игре
    /// </summary>
    public bool IsJoinable => PlayerList.Count < MaxPlayerCount;
    #endregion

    #region public methods

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

    #endregion
  }
}