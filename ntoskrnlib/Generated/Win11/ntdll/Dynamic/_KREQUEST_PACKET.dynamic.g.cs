using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KREQUEST_PACKET")]
    public sealed class _KREQUEST_PACKET : DynamicStructure
    {
        public byte[] CurrentPacket { get; }
        public IntPtr WorkerRoutine { get; }

        public _KREQUEST_PACKET(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KREQUEST_PACKET()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KREQUEST_PACKET.CurrentPacket),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KREQUEST_PACKET.WorkerRoutine),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_KREQUEST_PACKET>((mem, ptr) => new _KREQUEST_PACKET(mem, ptr), offsets);
        }
    }
}