using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_IRP_WORKER_ENTRY")]
    public sealed class _POP_IRP_WORKER_ENTRY : DynamicStructure
    {
        public _LIST_ENTRY Link { get; }
        public IntPtr Thread { get; }
        public IntPtr Irp { get; }
        public IntPtr Device { get; }
        public byte Static { get; }

        public _POP_IRP_WORKER_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_IRP_WORKER_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_IRP_WORKER_ENTRY.Link),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_IRP_WORKER_ENTRY.Thread),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_IRP_WORKER_ENTRY.Irp),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_POP_IRP_WORKER_ENTRY.Device),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_POP_IRP_WORKER_ENTRY.Static),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_POP_IRP_WORKER_ENTRY>((mem, ptr) => new _POP_IRP_WORKER_ENTRY(mem, ptr), offsets);
        }
    }
}