using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KTIMER")]
    public sealed class _KTIMER : DynamicStructure
    {
        public _DISPATCHER_HEADER Header { get; }
        public _ULARGE_INTEGER DueTime { get; }
        public _LIST_ENTRY TimerListEntry { get; }
        public IntPtr Dpc { get; }
        public ushort Processor { get; }
        public ushort TimerType { get; }
        public uint Period { get; }

        public _KTIMER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KTIMER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KTIMER.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KTIMER.DueTime),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KTIMER.TimerListEntry),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KTIMER.Dpc),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KTIMER.Processor),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_KTIMER.TimerType),
                    new ulong[]
                    {
                        58UL
                    }
                },
                {
                    nameof(_KTIMER.Period),
                    new ulong[]
                    {
                        60UL
                    }
                }
            };
            Register<_KTIMER>((mem, ptr) => new _KTIMER(mem, ptr), offsets);
        }
    }
}