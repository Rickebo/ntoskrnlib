using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_RESAVAIL_FAILURES")]
    public sealed class _MI_RESAVAIL_FAILURES : DynamicStructure
    {
        public uint Wrap { get; }
        public uint NoCharge { get; }

        public _MI_RESAVAIL_FAILURES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_RESAVAIL_FAILURES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_RESAVAIL_FAILURES.Wrap),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_RESAVAIL_FAILURES.NoCharge),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_MI_RESAVAIL_FAILURES>((mem, ptr) => new _MI_RESAVAIL_FAILURES(mem, ptr), offsets);
        }
    }
}