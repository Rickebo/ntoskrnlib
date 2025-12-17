using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WDT_HANDLE")]
    public sealed class WdtHandle : DynamicStructure
    {
        [Offset(0UL)]
        public sbyte Reserved { get => ReadHere<sbyte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        public WdtHandle(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WdtHandle>();
        }
    }
}