using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_NAME_HASH")]
    public sealed class CmNameHash : DynamicStructure
    {
        [Offset(0UL)]
        public CmComponentHash ConvKey { get => ReadStructure<CmComponentHash>(nameof(ConvKey)); set => WriteStructure(nameof(ConvKey), value); }

        [Offset(8UL)]
        public IntPtr NextHash { get => ReadHere<IntPtr>(nameof(NextHash)); set => WriteHere(nameof(NextHash), value); }

        [Offset(16UL)]
        public ushort NameLength { get => ReadHere<ushort>(nameof(NameLength)); set => WriteHere(nameof(NameLength), value); }

        [Offset(18UL)]
        [Length(1)]
        public DynamicArray Name { get => ReadStructure<DynamicArray>(nameof(Name)); set => WriteStructure(nameof(Name), value); }

        public CmNameHash(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmNameHash>();
        }
    }
}