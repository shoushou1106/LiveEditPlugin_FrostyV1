using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrostySdk.Interfaces;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.IO;
using System.Reflection;
using Path = System.Windows.Shapes.Path;
using FrostySdk.Managers;
using System.Text.RegularExpressions;
using System.Xml;
using Frosty.Core.Controls;
using Frosty.Core;
using Frosty.Core.Windows;
using FrostySdk.IO;

namespace LiveEditorPlugin.Controls
{
    //[TemplatePart(Name = PART_Canvas, Type = typeof(Viewbox))]
    class LiveEditor : FrostyBaseEditor
    {
        //private const string PART_Canvas = "PART_Canvas";

        private ILogger logger;

        //private Viewbox canvas;

        static LiveEditor()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LiveEditor), new FrameworkPropertyMetadata(typeof(LiveEditor)));
        }

        public LiveEditor()
        {
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            //dataExplorer = GetTemplateChild(PART_DataExplorer) as FrostyDataExplorer;

            //dataExplorer.SelectionChanged += DataExplorer_SelectionChanged;

            Loaded += LiveEditor_Loaded;
        }

        private void LiveEditor_Loaded(object sender, RoutedEventArgs e)
        {
        }
    }
}
