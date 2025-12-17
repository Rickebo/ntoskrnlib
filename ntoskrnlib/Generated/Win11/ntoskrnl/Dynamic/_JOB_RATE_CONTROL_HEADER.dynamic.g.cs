using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_JOB_RATE_CONTROL_HEADER")]
    public sealed class _JOB_RATE_CONTROL_HEADER : DynamicStructure
    {
        public IntPtr RateControlQuotaReference { get; }
        public _RTL_BITMAP OverQuotaHistory { get; }
        public IntPtr BitMapBuffer { get; }
        public ulong BitMapBufferSize { get; }

        public _JOB_RATE_CONTROL_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _JOB_RATE_CONTROL_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_JOB_RATE_CONTROL_HEADER.RateControlQuotaReference),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_JOB_RATE_CONTROL_HEADER.OverQuotaHistory),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_JOB_RATE_CONTROL_HEADER.BitMapBuffer),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_JOB_RATE_CONTROL_HEADER.BitMapBufferSize),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_JOB_RATE_CONTROL_HEADER>((mem, ptr) => new _JOB_RATE_CONTROL_HEADER(mem, ptr), offsets);
        }
    }
}