using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HIVE_WAIT_PACKET")]
    public sealed class _HIVE_WAIT_PACKET : DynamicStructure
    {
        public _KEVENT WakeEvent { get; }
        public int Status { get; }
        public IntPtr Next { get; }

        public _HIVE_WAIT_PACKET(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HIVE_WAIT_PACKET()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HIVE_WAIT_PACKET.WakeEvent),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HIVE_WAIT_PACKET.Status),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HIVE_WAIT_PACKET.Next),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_HIVE_WAIT_PACKET>((mem, ptr) => new _HIVE_WAIT_PACKET(mem, ptr), offsets);
        }
    }
}