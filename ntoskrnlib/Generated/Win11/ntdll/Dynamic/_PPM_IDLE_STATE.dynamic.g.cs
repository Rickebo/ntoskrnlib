using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PPM_IDLE_STATE")]
    public sealed class _PPM_IDLE_STATE : DynamicStructure
    {
        public _KAFFINITY_EX DomainMembers { get; }
        public _UNICODE_STRING Name { get; }
        public uint Latency { get; }
        public uint BreakEvenDuration { get; }
        public uint Power { get; }
        public uint StateFlags { get; }
        public _PPM_VETO_ACCOUNTING VetoAccounting { get; }
        public byte StateType { get; }
        public byte InterruptsEnabled { get; }
        public byte Interruptible { get; }
        public byte ContextRetained { get; }
        public byte CacheCoherent { get; }
        public byte WakesSpuriously { get; }
        public byte PlatformOnly { get; }
        public byte NoCState { get; }

        public _PPM_IDLE_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PPM_IDLE_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PPM_IDLE_STATE.DomainMembers),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATE.Name),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATE.Latency),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATE.BreakEvenDuration),
                    new ulong[]
                    {
                        284UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATE.Power),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATE.StateFlags),
                    new ulong[]
                    {
                        292UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATE.VetoAccounting),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATE.StateType),
                    new ulong[]
                    {
                        336UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATE.InterruptsEnabled),
                    new ulong[]
                    {
                        337UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATE.Interruptible),
                    new ulong[]
                    {
                        338UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATE.ContextRetained),
                    new ulong[]
                    {
                        339UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATE.CacheCoherent),
                    new ulong[]
                    {
                        340UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATE.WakesSpuriously),
                    new ulong[]
                    {
                        341UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATE.PlatformOnly),
                    new ulong[]
                    {
                        342UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATE.NoCState),
                    new ulong[]
                    {
                        343UL
                    }
                }
            };
            Register<_PPM_IDLE_STATE>((mem, ptr) => new _PPM_IDLE_STATE(mem, ptr), offsets);
        }
    }
}