using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TRIAGE_POP_IRP_DATA")]
    public sealed class _TRIAGE_POP_IRP_DATA : DynamicStructure
    {
        public _LIST_ENTRY Link { get; }
        public IntPtr Irp { get; }
        public IntPtr Pdo { get; }

        public _TRIAGE_POP_IRP_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TRIAGE_POP_IRP_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TRIAGE_POP_IRP_DATA.Link),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TRIAGE_POP_IRP_DATA.Irp),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_TRIAGE_POP_IRP_DATA.Pdo),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_TRIAGE_POP_IRP_DATA>((mem, ptr) => new _TRIAGE_POP_IRP_DATA(mem, ptr), offsets);
        }
    }
}