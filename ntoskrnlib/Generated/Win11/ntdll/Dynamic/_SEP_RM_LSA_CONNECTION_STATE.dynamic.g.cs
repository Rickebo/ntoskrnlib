using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_SEP_RM_LSA_CONNECTION_STATE")]
    public sealed class _SEP_RM_LSA_CONNECTION_STATE : DynamicStructure
    {
        public IntPtr LsaProcessHandle { get; }
        public IntPtr LsaCommandPortHandle { get; }
        public IntPtr SepRmThreadHandle { get; }
        public IntPtr RmCommandPortHandle { get; }
        public IntPtr RmCommandServerPortHandle { get; }
        public byte LsaCommandPortActive { get; }

        public _SEP_RM_LSA_CONNECTION_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SEP_RM_LSA_CONNECTION_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SEP_RM_LSA_CONNECTION_STATE.LsaProcessHandle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SEP_RM_LSA_CONNECTION_STATE.LsaCommandPortHandle),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SEP_RM_LSA_CONNECTION_STATE.SepRmThreadHandle),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_SEP_RM_LSA_CONNECTION_STATE.RmCommandPortHandle),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_SEP_RM_LSA_CONNECTION_STATE.RmCommandServerPortHandle),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_SEP_RM_LSA_CONNECTION_STATE.LsaCommandPortActive),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_SEP_RM_LSA_CONNECTION_STATE>((mem, ptr) => new _SEP_RM_LSA_CONNECTION_STATE(mem, ptr), offsets);
        }
    }
}