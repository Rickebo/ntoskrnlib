using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ACCESS_REASONS")]
    public sealed class AccessReasons : DynamicStructure
    {
        [Offset(0UL)]
        [Length(32)]
        public DynamicArray Data { get => ReadStructure<DynamicArray>(nameof(Data)); set => WriteStructure(nameof(Data), value); }

        public AccessReasons(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AccessReasons>();
        }
    }
}