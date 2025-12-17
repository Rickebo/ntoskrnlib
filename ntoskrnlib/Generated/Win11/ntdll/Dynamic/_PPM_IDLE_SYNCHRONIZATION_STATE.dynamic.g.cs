using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PPM_IDLE_SYNCHRONIZATION_STATE")]
    public sealed class _PPM_IDLE_SYNCHRONIZATION_STATE : DynamicStructure
    {
        public int AsLong { get; }
        public int RefCount { get; }
        public uint State { get; }

        public _PPM_IDLE_SYNCHRONIZATION_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PPM_IDLE_SYNCHRONIZATION_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PPM_IDLE_SYNCHRONIZATION_STATE.AsLong),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_IDLE_SYNCHRONIZATION_STATE.RefCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_IDLE_SYNCHRONIZATION_STATE.State),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_PPM_IDLE_SYNCHRONIZATION_STATE>((mem, ptr) => new _PPM_IDLE_SYNCHRONIZATION_STATE(mem, ptr), offsets);
        }
    }
}