using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTL_NLS_STATE")]
    public sealed class _RTL_NLS_STATE : DynamicStructure
    {
        public _CPTABLEINFO DefaultAcpTableInfo { get; }
        public _CPTABLEINFO DefaultOemTableInfo { get; }
        public IntPtr ActiveCodePageData { get; }
        public IntPtr OemCodePageData { get; }
        public IntPtr LeadByteInfo { get; }
        public IntPtr OemLeadByteInfo { get; }
        public IntPtr CaseMappingData { get; }
        public IntPtr UnicodeUpcaseTable844 { get; }
        public IntPtr UnicodeLowercaseTable844 { get; }

        public _RTL_NLS_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_NLS_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_NLS_STATE.DefaultAcpTableInfo),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_NLS_STATE.DefaultOemTableInfo),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_RTL_NLS_STATE.ActiveCodePageData),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_RTL_NLS_STATE.OemCodePageData),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_RTL_NLS_STATE.LeadByteInfo),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_RTL_NLS_STATE.OemLeadByteInfo),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_RTL_NLS_STATE.CaseMappingData),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_RTL_NLS_STATE.UnicodeUpcaseTable844),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_RTL_NLS_STATE.UnicodeLowercaseTable844),
                    new ulong[]
                    {
                        176UL
                    }
                }
            };
            Register<_RTL_NLS_STATE>((mem, ptr) => new _RTL_NLS_STATE(mem, ptr), offsets);
        }
    }
}