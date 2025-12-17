using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TPP_ITE")]
    public sealed class TppIte : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr First { get => ReadHere<IntPtr>(nameof(First)); set => WriteHere(nameof(First), value); }

        public TppIte(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TppIte>();
        }
    }
}