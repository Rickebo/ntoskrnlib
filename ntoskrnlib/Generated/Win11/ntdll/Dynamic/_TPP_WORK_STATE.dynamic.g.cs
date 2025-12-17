using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TPP_WORK_STATE")]
    public sealed class _TPP_WORK_STATE : DynamicStructure
    {
        public int Exchange { get; }
        public uint Insertable { get; }
        public uint PendingCallbackCount { get; }

        public _TPP_WORK_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TPP_WORK_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TPP_WORK_STATE.Exchange),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TPP_WORK_STATE.Insertable),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TPP_WORK_STATE.PendingCallbackCount),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_TPP_WORK_STATE>((mem, ptr) => new _TPP_WORK_STATE(mem, ptr), offsets);
        }
    }
}