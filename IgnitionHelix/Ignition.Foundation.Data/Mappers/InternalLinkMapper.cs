using Glass.Mapper.Sc.Maps;
using Ignition.Foundation.Core.Contracts;
using Ignition.Foundation.Core.Factories;
using Ignition.Foundation.Core.Installers.Mappers;
using Ignition.Foundation.Core.Models.BaseModels;
using Ignition.Foundation.Data.Fields;

namespace Ignition.Foundation.Data.Mappers
{
	public class InternalLinkMapper : SitecoreGlassMap<IInternalLink>, IGlassSettingsConsumer
	{
		public override void Configure()
		{
			Map(x =>
			{
				ImportMap<IModelBase>();
				x.TemplateId(SettingsFactory.GetSitecoreSetting("Ignition.Map.Id.InternalLink"));
				x.Cachable();
				x.Field(a => a.InternalLink).FieldId(SettingsFactory.GetSitecoreSetting("Models.Fields.Id.InternalLink"));
			});
		}
		public ISitecoreSettingsFactory SettingsFactory { get; set; }
	}
}