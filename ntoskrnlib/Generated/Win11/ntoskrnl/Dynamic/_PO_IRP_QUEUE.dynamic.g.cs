using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PO_IRP_QUEUE")]
    public sealed class _PO_IRP_QUEUE : DynamicStructure
    {
        public IntPtr CurrentIrp { get; }
        public IntPtr PendingIrpList { get; }

        public _PO_IRP_QUEUE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PO_IRP_QUEUE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PO_IRP_QUEUE.CurrentIrp),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PO_IRP_QUEUE.PendingIrpList),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PO_IRP_QUEUE>((mem, ptr) => new _PO_IRP_QUEUE(mem, ptr), offsets);
        }
    }
}