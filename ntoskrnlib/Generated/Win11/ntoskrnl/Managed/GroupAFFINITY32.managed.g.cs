using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_GROUP_AFFINITY32")]
    public sealed class GroupAFFINITY32 : DynamicStructure
    {
        [Offset(0UL)]
        public uint Mask { get => ReadHere<uint>(nameof(Mask)); set => WriteHere(nameof(Mask), value); }

        [Offset(4UL)]
        public ushort Group { get => ReadHere<ushort>(nameof(Group)); set => WriteHere(nameof(Group), value); }

        [Offset(6UL)]
        [Length(3)]
        public DynamicArray Reserved { get => ReadStructure<DynamicArray>(nameof(Reserved)); set => WriteStructure(nameof(Reserved), value); }

        public GroupAFFINITY32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<GroupAFFINITY32>();
        }
    }
}