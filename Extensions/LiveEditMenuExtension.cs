using Frosty.Core;
using LiveEditorPlugin.Controls;
using System;

namespace LiveEditorPlugin.Extensions
{
    // This is an example of a menu extension. It will build a new menu item under the Tools
    // menu called 'InitFS Viewer'. When clicked it will open a new InitFS viewer editor.

    public class LiveEditorMenuExtension : MenuExtension
    {
        // The top level menu item to place this menu item into.
        public override string TopLevelMenuName => "Tools";

        // The name of the menu item.
        public override string MenuItemName => "Live Editor";

        // The action to perform when the menu item is clicked
        public override RelayCommand MenuItemClicked => new RelayCommand((o) =>
        {
            GC.Collect();
            // Open a new editor
            App.EditorWindow.OpenEditor("Live Editor", new LiveEditor());
        });
    }
}
