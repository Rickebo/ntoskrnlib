using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RELATION_LIST")]
    public sealed class RelationList : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr DeviceObjectList { get => ReadHere<IntPtr>(nameof(DeviceObjectList)); set => WriteHere(nameof(DeviceObjectList), value); }

        [Offset(8UL)]
        public byte Sorted { get => ReadHere<byte>(nameof(Sorted)); set => WriteHere(nameof(Sorted), value); }

        public RelationList(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RelationList>();
        }
    }
}