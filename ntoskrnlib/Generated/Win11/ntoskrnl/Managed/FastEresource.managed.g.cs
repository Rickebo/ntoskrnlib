using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_FAST_ERESOURCE")]
    public sealed class FastEresource : DynamicStructure
    {
        [Offset(0UL)]
        [Length(3)]
        public DynamicArray Reserved1 { get => ReadStructure<DynamicArray>(nameof(Reserved1)); set => WriteStructure(nameof(Reserved1), value); }

        [Offset(24UL)]
        public uint Reserved2 { get => ReadHere<uint>(nameof(Reserved2)); set => WriteHere(nameof(Reserved2), value); }

        [Offset(32UL)]
        [Length(4)]
        public DynamicArray Reserved3 { get => ReadStructure<DynamicArray>(nameof(Reserved3)); set => WriteStructure(nameof(Reserved3), value); }

        [Offset(64UL)]
        [Length(4)]
        public DynamicArray Reserved4 { get => ReadStructure<DynamicArray>(nameof(Reserved4)); set => WriteStructure(nameof(Reserved4), value); }

        [Offset(80UL)]
        public IntPtr Reserved5 { get => ReadHere<IntPtr>(nameof(Reserved5)); set => WriteHere(nameof(Reserved5), value); }

        [Offset(88UL)]
        [Length(2)]
        public DynamicArray Reserved6 { get => ReadStructure<DynamicArray>(nameof(Reserved6)); set => WriteStructure(nameof(Reserved6), value); }

        public FastEresource(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FastEresource>();
        }
    }
}