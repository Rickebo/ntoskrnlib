using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!RTL_HP_ENV_HANDLE")]
    public sealed class RtlHpEnvHandle : DynamicStructure
    {
        [Offset(0UL)]
        [Length(2)]
        public DynamicArray h { get => ReadStructure<DynamicArray>(nameof(h)); set => WriteStructure(nameof(h), value); }

        public RtlHpEnvHandle(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlHpEnvHandle>();
        }
    }
}