using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PPM_VETO_ENTRY")]
    public sealed class _PPM_VETO_ENTRY : DynamicStructure
    {
        public _LIST_ENTRY Link { get; }
        public uint VetoReason { get; }
        public uint ReferenceCount { get; }
        public ulong HitCount { get; }
        public ulong LastActivationTime { get; }
        public ulong TotalActiveTime { get; }
        public ulong CsActivationTime { get; }
        public ulong CsActiveTime { get; }

        public _PPM_VETO_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PPM_VETO_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PPM_VETO_ENTRY.Link),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_VETO_ENTRY.VetoReason),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PPM_VETO_ENTRY.ReferenceCount),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_PPM_VETO_ENTRY.HitCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PPM_VETO_ENTRY.LastActivationTime),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PPM_VETO_ENTRY.TotalActiveTime),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PPM_VETO_ENTRY.CsActivationTime),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PPM_VETO_ENTRY.CsActiveTime),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_PPM_VETO_ENTRY>((mem, ptr) => new _PPM_VETO_ENTRY(mem, ptr), offsets);
        }
    }
}