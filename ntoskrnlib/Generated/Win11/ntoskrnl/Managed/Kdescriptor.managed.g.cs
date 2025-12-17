using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KDESCRIPTOR")]
    public sealed class Kdescriptor : DynamicStructure
    {
        [Offset(0UL)]
        [Length(3)]
        public DynamicArray Pad { get => ReadStructure<DynamicArray>(nameof(Pad)); set => WriteStructure(nameof(Pad), value); }

        [Offset(6UL)]
        public ushort Limit { get => ReadHere<ushort>(nameof(Limit)); set => WriteHere(nameof(Limit), value); }

        [Offset(8UL)]
        public IntPtr Base { get => ReadHere<IntPtr>(nameof(Base)); set => WriteHere(nameof(Base), value); }

        public Kdescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Kdescriptor>();
        }
    }
}