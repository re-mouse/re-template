using ReDI;
using Re.Templates.IO;
using YamlDotNet.Serialization;

namespace Re.Templates.IO;

public class TemplateConfigurationWriter
{
    [Inject] private TemplateConfigurationManager _manager;
    
    public void Write(string path, TemplateConfiguration configuration)
    {
        var configPath = _manager.GetConfigurationPath(path);
        
        using (var fs = File.Open(configPath, FileMode.OpenOrCreate))
        {
            using (var sw = new StreamWriter(fs))
            {
                var serializer = new Serializer();
                serializer.Serialize(sw, configuration);
            }
        }
    }
}