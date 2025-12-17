using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_NAME_CONTROL_BLOCK")]
    public sealed class CmNameControlBlock : DynamicStructure
    {
        [Offset(0UL)]
        public uint Compressed { get => ReadHere<uint>(nameof(Compressed)); set => WriteHere(nameof(Compressed), value); }

        [Offset(0UL)]
        public uint RefCount { get => ReadHere<uint>(nameof(RefCount)); set => WriteHere(nameof(RefCount), value); }

        [Offset(8UL)]
        public CmNameHash NameHash { get => ReadStructure<CmNameHash>(nameof(NameHash)); set => WriteStructure(nameof(NameHash), value); }

        [Offset(8UL)]
        public CmComponentHash ConvKey { get => ReadStructure<CmComponentHash>(nameof(ConvKey)); set => WriteStructure(nameof(ConvKey), value); }

        [Offset(16UL)]
        public IntPtr NextHash { get => ReadHere<IntPtr>(nameof(NextHash)); set => WriteHere(nameof(NextHash), value); }

        [Offset(24UL)]
        public ushort NameLength { get => ReadHere<ushort>(nameof(NameLength)); set => WriteHere(nameof(NameLength), value); }

        [Offset(26UL)]
        [Length(1)]
        public DynamicArray Name { get => ReadStructure<DynamicArray>(nameof(Name)); set => WriteStructure(nameof(Name), value); }

        public CmNameControlBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmNameControlBlock>();
        }
    }
}