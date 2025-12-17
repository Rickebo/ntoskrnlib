using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SID_AND_ATTRIBUTES_HASH")]
    public sealed class SidAndAttributesHash : DynamicStructure
    {
        [Offset(0UL)]
        public uint SidCount { get => ReadHere<uint>(nameof(SidCount)); set => WriteHere(nameof(SidCount), value); }

        [Offset(8UL)]
        public IntPtr SidAttr { get => ReadHere<IntPtr>(nameof(SidAttr)); set => WriteHere(nameof(SidAttr), value); }

        [Offset(16UL)]
        [Length(32)]
        public DynamicArray Hash { get => ReadStructure<DynamicArray>(nameof(Hash)); set => WriteStructure(nameof(Hash), value); }

        public SidAndAttributesHash(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SidAndAttributesHash>();
        }
    }
}