using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TIMEZONE_CHANGE_EVENT")]
    public sealed class _TIMEZONE_CHANGE_EVENT : DynamicStructure
    {
        public _KDPC Dpc { get; }
        public _KTIMER Timer { get; }
        public _WORK_QUEUE_ITEM WorkItem { get; }

        public _TIMEZONE_CHANGE_EVENT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TIMEZONE_CHANGE_EVENT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TIMEZONE_CHANGE_EVENT.Dpc),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TIMEZONE_CHANGE_EVENT.Timer),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_TIMEZONE_CHANGE_EVENT.WorkItem),
                    new ulong[]
                    {
                        128UL
                    }
                }
            };
            Register<_TIMEZONE_CHANGE_EVENT>((mem, ptr) => new _TIMEZONE_CHANGE_EVENT(mem, ptr), offsets);
        }
    }
}