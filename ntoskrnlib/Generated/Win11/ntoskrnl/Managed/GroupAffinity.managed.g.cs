using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_GROUP_AFFINITY")]
    public sealed class GroupAffinity : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Mask { get => ReadHere<ulong>(nameof(Mask)); set => WriteHere(nameof(Mask), value); }

        [Offset(8UL)]
        public ushort Group { get => ReadHere<ushort>(nameof(Group)); set => WriteHere(nameof(Group), value); }

        [Offset(10UL)]
        [Length(3)]
        public DynamicArray Reserved { get => ReadStructure<DynamicArray>(nameof(Reserved)); set => WriteStructure(nameof(Reserved), value); }

        public GroupAffinity(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<GroupAffinity>();
        }
    }
}