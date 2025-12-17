using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PPM_VETO_ACCOUNTING")]
    public sealed class _PPM_VETO_ACCOUNTING : DynamicStructure
    {
        public int VetoPresent { get; }
        public _LIST_ENTRY VetoListHead { get; }
        public byte CsAccountingBlocks { get; }
        public byte BlocksDrips { get; }
        public uint PreallocatedVetoCount { get; }
        public IntPtr PreallocatedVetoList { get; }

        public _PPM_VETO_ACCOUNTING(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PPM_VETO_ACCOUNTING()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PPM_VETO_ACCOUNTING.VetoPresent),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_VETO_ACCOUNTING.VetoListHead),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PPM_VETO_ACCOUNTING.CsAccountingBlocks),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PPM_VETO_ACCOUNTING.BlocksDrips),
                    new ulong[]
                    {
                        25UL
                    }
                },
                {
                    nameof(_PPM_VETO_ACCOUNTING.PreallocatedVetoCount),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_PPM_VETO_ACCOUNTING.PreallocatedVetoList),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_PPM_VETO_ACCOUNTING>((mem, ptr) => new _PPM_VETO_ACCOUNTING(mem, ptr), offsets);
        }
    }
}