using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game.Find;

namespace GameFindClient
{
  public partial class Form1 : Form
  {
    private string m_sPlayerGuid;


    public Form1()
    {
      InitializeComponent();
      string sUrlService = "http://127.0.0.1:8000/GameFind";
      txtUrl.Text = sUrlService;
    }

    private void h_Refresh()
    {
      Game.Find.GameFindClient pClient = new Game.Find.GameFindClient(txtUrl.Text);
      GameState pState = pClient.GetState(m_sPlayerGuid);
      switch (pState.State)
      {
        case EGameState.GameWait:
          panTop.BackColor = Color.Gray;
          break;
        case EGameState.GameProcess:
          panTop.BackColor = Color.Green;
          break;
        case EGameState.GameOver:
          panTop.BackColor = Color.Bisque;
          break;
      }

    }

    private void btnStart_Click(object sender, EventArgs e)
    {
      m_sPlayerGuid = new Guid().ToString("N");
      Game.Find.GameFindClient pClient = new Game.Find.GameFindClient(txtUrl.Text);
      Text = pClient.GetVersion();
      pClient.StartGame(m_sPlayerGuid);
    }

    private void btnFinish_Click(object sender, EventArgs e)
    {
      Game.Find.GameFindClient pClient = new Game.Find.GameFindClient(txtUrl.Text);
      pClient.EndGame(m_sPlayerGuid);

    }
  }
}
