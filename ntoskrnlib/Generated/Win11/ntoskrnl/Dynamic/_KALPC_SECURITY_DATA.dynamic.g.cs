using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KALPC_SECURITY_DATA")]
    public sealed class _KALPC_SECURITY_DATA : DynamicStructure
    {
        public IntPtr HandleTable { get; }
        public IntPtr ContextHandle { get; }
        public IntPtr OwningProcess { get; }
        public IntPtr OwnerPort { get; }
        public _SECURITY_CLIENT_CONTEXT DynamicSecurity { get; }
        public _unnamed_tag_ u1 { get; }

        public _KALPC_SECURITY_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KALPC_SECURITY_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KALPC_SECURITY_DATA.HandleTable),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KALPC_SECURITY_DATA.ContextHandle),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KALPC_SECURITY_DATA.OwningProcess),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KALPC_SECURITY_DATA.OwnerPort),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KALPC_SECURITY_DATA.DynamicSecurity),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KALPC_SECURITY_DATA.u1),
                    new ulong[]
                    {
                        104UL
                    }
                }
            };
            Register<_KALPC_SECURITY_DATA>((mem, ptr) => new _KALPC_SECURITY_DATA(mem, ptr), offsets);
        }
    }
}