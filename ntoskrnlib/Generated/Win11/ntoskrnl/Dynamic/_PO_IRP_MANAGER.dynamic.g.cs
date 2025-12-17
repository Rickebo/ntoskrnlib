using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PO_IRP_MANAGER")]
    public sealed class _PO_IRP_MANAGER : DynamicStructure
    {
        public _PO_IRP_QUEUE DeviceIrpQueue { get; }
        public _PO_IRP_QUEUE SystemIrpQueue { get; }

        public _PO_IRP_MANAGER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PO_IRP_MANAGER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PO_IRP_MANAGER.DeviceIrpQueue),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PO_IRP_MANAGER.SystemIrpQueue),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_PO_IRP_MANAGER>((mem, ptr) => new _PO_IRP_MANAGER(mem, ptr), offsets);
        }
    }
}