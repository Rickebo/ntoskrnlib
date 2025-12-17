using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TPP_CALLER")]
    public sealed class TppCaller : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ReturnAddress { get => ReadHere<IntPtr>(nameof(ReturnAddress)); set => WriteHere(nameof(ReturnAddress), value); }

        public TppCaller(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TppCaller>();
        }
    }
}