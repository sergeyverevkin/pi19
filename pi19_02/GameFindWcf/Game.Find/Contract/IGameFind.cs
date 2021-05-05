using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Game.Find
{
  /// <summary>
  /// Игра "Поиск"
  /// </summary>
  [ServiceContract]
  public interface IGameFind
  {
    /// <summary>
    /// Старт игры
    /// </summary>
    /// <returns></returns>
    [OperationContract]
    bool StartGame(string sPlayer);

    /// <summary>
    /// Ход в игре
    /// </summary>
    /// <returns></returns>
    [OperationContract]
    bool Turn(string sPlayer, ETurn enTurn);

    [OperationContract]
    void EndGame(string sPlayer);

    [OperationContract]
    GameState GetState(string sPlayer);

    [OperationContract]
    string GetVersion();
  }

  [DataContract]
  public class GameState
  {
    /// <summary>
    /// Текущий ход
    /// </summary>
    [DataMember]
    public string CurrentPlayer { get; set; }
    /// <summary>
    /// Расстояние до выхода
    /// </summary>
    [DataMember]
    public double Distance { get; set; }
    /// <summary>
    /// Состояние игры
    /// </summary>
    [DataMember]
    public EGameState State { get; set; }

  }

  [DataContract]
  public enum EGameState
  {
    [EnumMember]
    GameWait,
    [EnumMember]
    GameProcess,
    [EnumMember]
    GameOver,
  }


  [DataContract]
  public enum ETurn
  {
    [EnumMember]
    Left,
    [EnumMember]
    Right,
    [EnumMember]
    Top,
    [EnumMember]
    Bottom
  }
}
