using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Game.Find.Server
{
  public class ServerHost<TClass, TContract>
  {
    private ServiceHost m_pHost;

    public ServerHost(string sUrlService)
    {
      string sUrlServiceMeta = $"{sUrlService}/Meta";
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
      m_pHost = new ServiceHost(typeof(TClass));
      m_pHost.Description.Behaviors.Add(smb);
      // Добавляем обслуживание основного функционала
      m_pHost.AddServiceEndpoint(typeof(TContract), pBinding, sUrlService);
      // Добавляем обслуживание публикации информации о сервисе
      m_pHost.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), sUrlServiceMeta);

    }

    public void Start()
    {
      m_pHost.Open();
    }

  }

}
