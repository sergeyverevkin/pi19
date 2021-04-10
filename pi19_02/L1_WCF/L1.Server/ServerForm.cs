using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using L1.WcfServiceLibrary;

namespace L1.Server
{
  public partial class ServerForm : Form
  {
    private ServiceHost m_pHost;

    public ServerForm()
    {
      InitializeComponent();

      string sUrlService = "http://127.0.0.1:8000/Service1";
      string sUrlServiceMeta = "http://127.0.0.1:8000/Service1/Meta";
      // Привязка для основного сервиса
      BasicHttpBinding pBinding = new BasicHttpBinding();
      pBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
      pBinding.Security.Mode = BasicHttpSecurityMode.None;
      // Поведение для публикации информации о сервисе
      ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
      smb.HttpGetEnabled = true;
      smb.HttpGetUrl = new Uri(sUrlServiceMeta);
      smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;

      // Создаем хост
      m_pHost = new ServiceHost(typeof(EncyclopediaService));
      m_pHost.Description.Behaviors.Add(smb);
      // Добавляем обслуживание основного функционала
      m_pHost.AddServiceEndpoint(typeof(IEncyclopediaService), pBinding, sUrlService);
      // Добавляем обслуживание публикации информации о сервисе
      m_pHost.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), sUrlServiceMeta);
      m_pHost.Opened += h_OnServerOpened;
      m_pHost.Closed += h_OnServerClosed;

    }

    private void h_OnServerClosed(object sender, EventArgs e)
    {
      button1.Text = "Start";
    }

    private void h_OnServerOpened(object sender, EventArgs e)
    {
      button1.Text = "Stop";
    }

    private void button1_Click(object sender, EventArgs e)
    {
      m_pHost.Open();
    }
  }
}
