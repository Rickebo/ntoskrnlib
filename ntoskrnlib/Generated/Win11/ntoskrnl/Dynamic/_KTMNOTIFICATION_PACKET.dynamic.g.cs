using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KTMNOTIFICATION_PACKET")]
    public sealed class _KTMNOTIFICATION_PACKET : DynamicStructure
    {
        public _KTMNOTIFICATION_PACKET(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KTMNOTIFICATION_PACKET()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_KTMNOTIFICATION_PACKET>((mem, ptr) => new _KTMNOTIFICATION_PACKET(mem, ptr), offsets);
        }
    }
}