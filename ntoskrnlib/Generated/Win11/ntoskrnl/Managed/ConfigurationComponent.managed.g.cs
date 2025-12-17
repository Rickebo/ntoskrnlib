using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CONFIGURATION_COMPONENT")]
    public sealed class ConfigurationComponent : DynamicStructure
    {
        [Offset(0UL)]
        public uint Class { get => ReadHere<uint>(nameof(Class)); set => WriteHere(nameof(Class), value); }

        [Offset(4UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(8UL)]
        public DeviceFlags Flags { get => ReadStructure<DeviceFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(12UL)]
        public ushort Version { get => ReadHere<ushort>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(14UL)]
        public ushort Revision { get => ReadHere<ushort>(nameof(Revision)); set => WriteHere(nameof(Revision), value); }

        [Offset(16UL)]
        public uint Key { get => ReadHere<uint>(nameof(Key)); set => WriteHere(nameof(Key), value); }

        [Offset(20UL)]
        public uint AffinityMask { get => ReadHere<uint>(nameof(AffinityMask)); set => WriteHere(nameof(AffinityMask), value); }

        [Offset(20UL)]
        public ushort Group { get => ReadHere<ushort>(nameof(Group)); set => WriteHere(nameof(Group), value); }

        [Offset(22UL)]
        public ushort GroupIndex { get => ReadHere<ushort>(nameof(GroupIndex)); set => WriteHere(nameof(GroupIndex), value); }

        [Offset(24UL)]
        public uint ConfigurationDataLength { get => ReadHere<uint>(nameof(ConfigurationDataLength)); set => WriteHere(nameof(ConfigurationDataLength), value); }

        [Offset(28UL)]
        public uint IdentifierLength { get => ReadHere<uint>(nameof(IdentifierLength)); set => WriteHere(nameof(IdentifierLength), value); }

        [Offset(32UL)]
        public IntPtr Identifier { get => ReadHere<IntPtr>(nameof(Identifier)); set => WriteHere(nameof(Identifier), value); }

        public ConfigurationComponent(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ConfigurationComponent>();
        }
    }
}