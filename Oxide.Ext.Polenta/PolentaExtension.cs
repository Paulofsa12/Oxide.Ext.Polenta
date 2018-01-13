using Oxide.Core;
using Oxide.Core.Extensions;
using Oxide.Core.RemoteConsole;
using Oxide.Game.RustLegacy.Libraries;
using Oxide.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace Oxide.Ext.Polenta
{
    public class PolentaExtension : Extension
    {
        internal static readonly Version AssemblyVersion = Assembly.GetExecutingAssembly().GetName().Version;

        /// <summary>
        /// Gets whether this extension is for a specific game
        /// </summary>
        public override bool IsGameExtension => true;

        /// <summary>
        /// Gets the name of this extension
        /// </summary>
        public override string Name => "PluginsPolenta";

        /// <summary>
        /// Gets the author of this extension
        /// </summary>
        public override string Author => "P0LENT4";

        /// <summary>
        /// Gets the version of this extension
        /// </summary>
        public override VersionNumber Version => new VersionNumber(AssemblyVersion.Major, AssemblyVersion.Minor, AssemblyVersion.Build);

        /// <summary>
        /// Default game-specific references for use in plugins
        /// </summary>
        internal static readonly HashSet<string> DefaultReferences = new HashSet<string>
        {
        };

        /// <summary>
        /// List of assemblies allowed for use in plugins
        /// </summary>
        public override string[] WhitelistAssemblies => new[]
        {
            "Assembly-CSharp", "DestMath", "mscorlib", "Oxide.Core", "RustBuild", "System", "System.Core", "UnityEngine", "uLink"
        };

        /// <summary>
        /// Initializes a new instance of the RustExtension class
        /// </summary>
        /// <param name="manager"></param>
        public PolentaExtension(ExtensionManager manager) : base(manager)
        {
        }

        /// <summary>
        /// Loads this extension
        /// </summary>
        public override void Load()
        {
            Interface.Oxide.LogInfo("Inicio a extenção");
        }

        /// <summary>
        /// Loads plugin watchers used by this extension
        /// </summary>
        /// <param name="directory"></param>
        public override void LoadPluginWatchers(string directory)
        {
        }
        
        public static void teste()
        {
            Interface.Oxide.LogInfo("Teste 1 2 3");
        }
    }
}
