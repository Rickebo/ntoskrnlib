using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KAPC_STATE")]
    public sealed class _KAPC_STATE : DynamicStructure
    {
        public byte[] ApcListHead { get; }
        public IntPtr Process { get; }
        public byte InProgressFlags { get; }
        public byte KernelApcInProgress { get; }
        public byte SpecialApcInProgress { get; }
        public byte KernelApcPending { get; }
        public byte UserApcPendingAll { get; }
        public byte SpecialUserApcPending { get; }
        public byte UserApcPending { get; }

        public _KAPC_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KAPC_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KAPC_STATE.ApcListHead),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KAPC_STATE.Process),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KAPC_STATE.InProgressFlags),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KAPC_STATE.KernelApcInProgress),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KAPC_STATE.SpecialApcInProgress),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KAPC_STATE.KernelApcPending),
                    new ulong[]
                    {
                        41UL
                    }
                },
                {
                    nameof(_KAPC_STATE.UserApcPendingAll),
                    new ulong[]
                    {
                        42UL
                    }
                },
                {
                    nameof(_KAPC_STATE.SpecialUserApcPending),
                    new ulong[]
                    {
                        42UL
                    }
                },
                {
                    nameof(_KAPC_STATE.UserApcPending),
                    new ulong[]
                    {
                        42UL
                    }
                }
            };
            Register<_KAPC_STATE>((mem, ptr) => new _KAPC_STATE(mem, ptr), offsets);
        }
    }
}