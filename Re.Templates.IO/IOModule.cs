using ReDI;
using Re.Templates.IO;

namespace Re.Templates.IO;

public class IOModule : Module
{
    public override void BindDependencies(TypeManager typeBinder)
    {
        typeBinder.AddSingleton<TemplateConfigurationReader>();
        typeBinder.AddSingleton<TemplateConfigurationWriter>();
        typeBinder.AddSingleton<TemplateConfigurationManager>();
        
        typeBinder.AddSingleton<TemplateReader>();
        typeBinder.AddSingleton<TemplateWriter>();
        
        typeBinder.AddSingleton<ArtifactWriter>();
        
        typeBinder.AddSingleton<DirectoryManager>(); 
    }

    public override void BindModuleDependencies(ModuleManager moduleBinder)
    {
        
    }
}