using Frosty.Core.Attributes;
using LiveEditorPlugin.Extensions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

[assembly: ThemeInfo(
    ResourceDictionaryLocation.None, //where theme specific resource dictionaries are located
                                     //(used if a resource is not found in the page, 
                                     // or application resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
                                              //(used if a resource is not found in the page, 
                                              // app, or any theme specific resource dictionaries)
)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("4b191968-9b6a-4ab4-8da5-0e5114514b4e")]

[assembly: PluginDisplayName("Live Editor")]
[assembly: PluginAuthor("shoushou1106")]
[assembly: PluginVersion("0.1.3.1")]

[assembly: RegisterMenuExtension(typeof(LiveEditorMenuExtension))]
