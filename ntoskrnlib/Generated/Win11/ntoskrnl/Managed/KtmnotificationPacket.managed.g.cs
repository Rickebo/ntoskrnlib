using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KTMNOTIFICATION_PACKET")]
    public sealed class KtmnotificationPacket : DynamicStructure
    {
        public KtmnotificationPacket(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KtmnotificationPacket>();
        }
    }
}