using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TPP_REFCOUNT")]
    public sealed class TppRefcount : DynamicStructure
    {
        [Offset(0UL)]
        public int Refcount { get => ReadHere<int>(nameof(Refcount)); set => WriteHere(nameof(Refcount), value); }

        public TppRefcount(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TppRefcount>();
        }
    }
}