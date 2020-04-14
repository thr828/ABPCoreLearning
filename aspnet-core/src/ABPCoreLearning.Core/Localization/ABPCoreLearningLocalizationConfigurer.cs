using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ABPCoreLearning.Localization
{
    public static class ABPCoreLearningLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ABPCoreLearningConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ABPCoreLearningLocalizationConfigurer).GetAssembly(),
                        "ABPCoreLearning.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
