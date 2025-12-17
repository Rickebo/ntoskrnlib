using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_FX_WORK_ORDER_WATCHDOG_INFO")]
    public sealed class _POP_FX_WORK_ORDER_WATCHDOG_INFO : DynamicStructure
    {
        public _LIST_ENTRY Link { get; }
        public _KTIMER Timer { get; }
        public _KDPC Dpc { get; }
        public IntPtr WorkOrder { get; }
        public IntPtr CurrentWorkInfo { get; }
        public ulong WatchdogStart { get; }
        public IntPtr WorkerThread { get; }

        public _POP_FX_WORK_ORDER_WATCHDOG_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_FX_WORK_ORDER_WATCHDOG_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_FX_WORK_ORDER_WATCHDOG_INFO.Link),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_WORK_ORDER_WATCHDOG_INFO.Timer),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_FX_WORK_ORDER_WATCHDOG_INFO.Dpc),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_POP_FX_WORK_ORDER_WATCHDOG_INFO.WorkOrder),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_POP_FX_WORK_ORDER_WATCHDOG_INFO.CurrentWorkInfo),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_POP_FX_WORK_ORDER_WATCHDOG_INFO.WatchdogStart),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_POP_FX_WORK_ORDER_WATCHDOG_INFO.WorkerThread),
                    new ulong[]
                    {
                        168UL
                    }
                }
            };
            Register<_POP_FX_WORK_ORDER_WATCHDOG_INFO>((mem, ptr) => new _POP_FX_WORK_ORDER_WATCHDOG_INFO(mem, ptr), offsets);
        }
    }
}