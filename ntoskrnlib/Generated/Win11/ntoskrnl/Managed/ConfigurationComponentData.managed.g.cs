using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CONFIGURATION_COMPONENT_DATA")]
    public sealed class ConfigurationComponentData : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Parent { get => ReadHere<IntPtr>(nameof(Parent)); set => WriteHere(nameof(Parent), value); }

        [Offset(8UL)]
        public IntPtr Child { get => ReadHere<IntPtr>(nameof(Child)); set => WriteHere(nameof(Child), value); }

        [Offset(16UL)]
        public IntPtr Sibling { get => ReadHere<IntPtr>(nameof(Sibling)); set => WriteHere(nameof(Sibling), value); }

        [Offset(24UL)]
        public ConfigurationComponent ComponentEntry { get => ReadStructure<ConfigurationComponent>(nameof(ComponentEntry)); set => WriteStructure(nameof(ComponentEntry), value); }

        [Offset(64UL)]
        public IntPtr ConfigurationData { get => ReadHere<IntPtr>(nameof(ConfigurationData)); set => WriteHere(nameof(ConfigurationData), value); }

        public ConfigurationComponentData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ConfigurationComponentData>();
        }
    }
}