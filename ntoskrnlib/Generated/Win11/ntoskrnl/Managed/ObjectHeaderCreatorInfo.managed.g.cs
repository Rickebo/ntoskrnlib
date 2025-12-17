using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OBJECT_HEADER_CREATOR_INFO")]
    public sealed class ObjectHeaderCreatorInfo : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry TypeList { get => ReadStructure<ListEntry>(nameof(TypeList)); set => WriteStructure(nameof(TypeList), value); }

        [Offset(16UL)]
        public IntPtr CreatorUniqueProcess { get => ReadHere<IntPtr>(nameof(CreatorUniqueProcess)); set => WriteHere(nameof(CreatorUniqueProcess), value); }

        [Offset(24UL)]
        public ushort CreatorBackTraceIndex { get => ReadHere<ushort>(nameof(CreatorBackTraceIndex)); set => WriteHere(nameof(CreatorBackTraceIndex), value); }

        [Offset(26UL)]
        public ushort Reserved1 { get => ReadHere<ushort>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(28UL)]
        public uint Reserved2 { get => ReadHere<uint>(nameof(Reserved2)); set => WriteHere(nameof(Reserved2), value); }

        public ObjectHeaderCreatorInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObjectHeaderCreatorInfo>();
        }
    }
}