using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EPROCESS_QUOTA_BLOCK")]
    public sealed class EprocessQuotaBlock : DynamicStructure
    {
        public EprocessQuotaBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EprocessQuotaBlock>();
        }
    }
}