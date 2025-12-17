using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KENTROPY_TIMING_STATE")]
    public sealed class _KENTROPY_TIMING_STATE : DynamicStructure
    {
        public uint EntropyCount { get; }
        public uint[] Buffer { get; }
        public _KDPC Dpc { get; }
        public uint LastDeliveredBuffer { get; }
        public IntPtr ReservedRawDataBuffer { get; }

        public _KENTROPY_TIMING_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KENTROPY_TIMING_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KENTROPY_TIMING_STATE.EntropyCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KENTROPY_TIMING_STATE.Buffer),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KENTROPY_TIMING_STATE.Dpc),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_KENTROPY_TIMING_STATE.LastDeliveredBuffer),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(_KENTROPY_TIMING_STATE.ReservedRawDataBuffer),
                    new ulong[]
                    {
                        336UL
                    }
                }
            };
            Register<_KENTROPY_TIMING_STATE>((mem, ptr) => new _KENTROPY_TIMING_STATE(mem, ptr), offsets);
        }
    }
}