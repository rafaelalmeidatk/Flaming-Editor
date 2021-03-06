﻿using Gemini.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flaming_Editor.Modules.Startup
{
    [Export(typeof(IModule))]
    class Module : ModuleBase
    {
        public override void Initialize()
        {
            MainWindow.Title = "Flaming Editor";
            MainWindow.WindowState = System.Windows.WindowState.Maximized;
            Shell.ToolBars.Visible = true;
        }
    }
}
