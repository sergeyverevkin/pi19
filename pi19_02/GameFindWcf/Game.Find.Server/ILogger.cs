namespace Game.Find.Server
{
  public interface ILogger
  {
    void WriteError(string sErrorText);
    void Write(string sText);
  }
}