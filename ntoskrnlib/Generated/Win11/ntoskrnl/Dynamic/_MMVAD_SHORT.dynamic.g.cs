using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMVAD_SHORT")]
    public sealed class _MMVAD_SHORT : DynamicStructure
    {
        public IntPtr NextVad { get; }
        public IntPtr ExtraCreateInfo { get; }
        public _RTL_BALANCED_NODE VadNode { get; }
        public uint StartingVpn { get; }
        public uint EndingVpn { get; }
        public byte StartingVpnHigh { get; }
        public byte EndingVpnHigh { get; }
        public byte CommitChargeHigh { get; }
        public byte SpareNT64VadUChar { get; }
        public int ReferenceCount { get; }
        public _EX_PUSH_LOCK PushLock { get; }
        public _unnamed_tag_ u { get; }
        public uint CommitCharge { get; }
        public _unnamed_tag_ u5 { get; }

        public _MMVAD_SHORT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMVAD_SHORT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMVAD_SHORT.NextVad),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMVAD_SHORT.ExtraCreateInfo),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MMVAD_SHORT.VadNode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMVAD_SHORT.StartingVpn),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MMVAD_SHORT.EndingVpn),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_MMVAD_SHORT.StartingVpnHigh),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MMVAD_SHORT.EndingVpnHigh),
                    new ulong[]
                    {
                        33UL
                    }
                },
                {
                    nameof(_MMVAD_SHORT.CommitChargeHigh),
                    new ulong[]
                    {
                        34UL
                    }
                },
                {
                    nameof(_MMVAD_SHORT.SpareNT64VadUChar),
                    new ulong[]
                    {
                        35UL
                    }
                },
                {
                    nameof(_MMVAD_SHORT.ReferenceCount),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_MMVAD_SHORT.PushLock),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MMVAD_SHORT.u),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MMVAD_SHORT.CommitCharge),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_MMVAD_SHORT.u5),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_MMVAD_SHORT>((mem, ptr) => new _MMVAD_SHORT(mem, ptr), offsets);
        }
    }
}