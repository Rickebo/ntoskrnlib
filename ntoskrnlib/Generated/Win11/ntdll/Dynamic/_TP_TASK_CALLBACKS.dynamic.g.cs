using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TP_TASK_CALLBACKS")]
    public sealed class _TP_TASK_CALLBACKS : DynamicStructure
    {
        public IntPtr ExecuteCallback { get; }
        public IntPtr Unposted { get; }

        public _TP_TASK_CALLBACKS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TP_TASK_CALLBACKS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TP_TASK_CALLBACKS.ExecuteCallback),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TP_TASK_CALLBACKS.Unposted),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_TP_TASK_CALLBACKS>((mem, ptr) => new _TP_TASK_CALLBACKS(mem, ptr), offsets);
        }
    }
}