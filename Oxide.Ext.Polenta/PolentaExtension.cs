namespace Oxide.Ext.Polenta
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Oxide.Core;
    using Oxide.Core.Extensions;

    public class PolentaExtension : Extension
    {
        internal static readonly Version AssemblyVersion = Assembly.GetExecutingAssembly().GetName().Version;
        public override VersionNumber Version => new VersionNumber(AssemblyVersion.Major, AssemblyVersion.Minor, AssemblyVersion.Build);
        public override string Name => "PluginsManager";
        public override string Author => "P0LENT4";

        public PolentaExtension(ExtensionManager manager) : base(manager)
        {
        }
    }
}
