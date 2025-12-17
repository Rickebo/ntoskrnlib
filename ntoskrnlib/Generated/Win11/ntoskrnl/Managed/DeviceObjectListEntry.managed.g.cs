using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DEVICE_OBJECT_LIST_ENTRY")]
    public sealed class DeviceObjectListEntry : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr DeviceObject { get => ReadHere<IntPtr>(nameof(DeviceObject)); set => WriteHere(nameof(DeviceObject), value); }

        [Offset(8UL)]
        public uint RelationLevel { get => ReadHere<uint>(nameof(RelationLevel)); set => WriteHere(nameof(RelationLevel), value); }

        [Offset(12UL)]
        public uint Ordinal { get => ReadHere<uint>(nameof(Ordinal)); set => WriteHere(nameof(Ordinal), value); }

        [Offset(16UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        public DeviceObjectListEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DeviceObjectListEntry>();
        }
    }
}