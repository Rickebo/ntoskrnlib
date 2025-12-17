using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PROC_IDLE_SNAP")]
    public sealed class _PROC_IDLE_SNAP : DynamicStructure
    {
        public ulong Time { get; }
        public ulong Idle { get; }

        public _PROC_IDLE_SNAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROC_IDLE_SNAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROC_IDLE_SNAP.Time),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROC_IDLE_SNAP.Idle),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PROC_IDLE_SNAP>((mem, ptr) => new _PROC_IDLE_SNAP(mem, ptr), offsets);
        }
    }
}