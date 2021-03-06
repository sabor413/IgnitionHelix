using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Maps;
using Ignition.Foundation.Core.Contracts;
using Ignition.Foundation.Core.Factories;
using Ignition.Foundation.Core.Models.BaseModels.Concrete;
using Sitecore.Data;

namespace Ignition.Foundation.Core.Installers.Mappers
{
	public class ModelBaseConcreteMap : SitecoreGlassMap<ModelBase>, IGlassSettingsConsumer
	{
		public override void Configure()
		{
			Map(x =>
			{
				x.AutoMap();
				x.Id(a => a.Id);
				x.Config.TemplateId = new ID(SettingsFactory.GetSitecoreSetting("Ignition.Map.Id.ModelBase"));
				x.Info(a => a.Language).InfoType(SitecoreInfoType.Language);
				x.Info(a => a.Path).InfoType(SitecoreInfoType.Path);
				x.Info(a => a.DisplayName).InfoType(SitecoreInfoType.DisplayName);
				x.Info(a => a.Version).InfoType(SitecoreInfoType.Version);
				x.Info(a => a.Name).InfoType(SitecoreInfoType.Name);
				x.Info(a => a.Url).InfoType(SitecoreInfoType.Url);
				x.Cachable();
			});
		}
		public ISitecoreSettingsFactory SettingsFactory { get; set; }
	}
}