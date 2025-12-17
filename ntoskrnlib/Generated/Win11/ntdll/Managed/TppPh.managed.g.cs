using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TPP_PH")]
    public sealed class TppPh : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Root { get => ReadHere<IntPtr>(nameof(Root)); set => WriteHere(nameof(Root), value); }

        public TppPh(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TppPh>();
        }
    }
}