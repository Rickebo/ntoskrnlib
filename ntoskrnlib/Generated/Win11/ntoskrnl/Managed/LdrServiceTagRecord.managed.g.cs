using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_LDR_SERVICE_TAG_RECORD")]
    public sealed class LdrServiceTagRecord : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Next { get => ReadHere<IntPtr>(nameof(Next)); set => WriteHere(nameof(Next), value); }

        [Offset(8UL)]
        public uint ServiceTag { get => ReadHere<uint>(nameof(ServiceTag)); set => WriteHere(nameof(ServiceTag), value); }

        public LdrServiceTagRecord(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LdrServiceTagRecord>();
        }
    }
}