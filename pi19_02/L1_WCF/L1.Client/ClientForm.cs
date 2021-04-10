using System;
using System.ServiceModel;
using System.Windows.Forms;
using WindowsFormsApp1.ServiceReference1;

namespace WindowsFormsApp1
{
  public partial class ClientForm : Form
  {
    public ClientForm()
    {
      InitializeComponent();
      txtAddr.Text = "http://127.0.0.1:8000/Service1";
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
      BasicHttpBinding pBinding = new BasicHttpBinding();
      pBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
      pBinding.Security.Mode = BasicHttpSecurityMode.None;

      EncyclopediaServiceClient pClient =
        new EncyclopediaServiceClient(
          pBinding, 
          new EndpointAddress(txtAddr.Text));

      EncyclopediaType pEncyclopediaType = pClient.GetInfo();

      Text = pEncyclopediaType.Title;
      h_RefreshParts(pEncyclopediaType.PartList);
            
    }

    private void h_RefreshParts(EncyclopediaPartType[] partList)
    {
      lvParts.Items.Clear();
      foreach (EncyclopediaPartType pItem in partList)
      {
        ListViewItem pLvItem = lvParts.Items.Add(pItem.Title);
        pLvItem.SubItems.Add(pItem.ArticleInfoList.Length.ToString());
        pLvItem.Tag = pItem;
      }
    }

    private void lvParts_SelectedIndexChanged(object sender, EventArgs e)
    {

      if (lvParts.SelectedItems.Count == 0 || 
          lvParts.SelectedItems[0].Tag == null)
      {
        lvArticles.Visible = false;
        return;
      }
      lvArticles.Visible = true;

      h_RefreshArticles(lvParts.SelectedItems[0].Tag as EncyclopediaPartType);

    }

    private void h_RefreshArticles(EncyclopediaPartType encyclopediaPartType)
    {
//      lvArticles.Items.Add(encyclopediaPartType.ArticleInfoList[0])
      // ...TODO...
    }

    private void lvArticles_SelectedIndexChanged(object sender, EventArgs e)
    {
      // ...TODO...
    }
  }
}
