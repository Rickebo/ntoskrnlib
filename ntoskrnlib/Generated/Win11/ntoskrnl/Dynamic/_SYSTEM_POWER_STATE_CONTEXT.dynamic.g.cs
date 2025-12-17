using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SYSTEM_POWER_STATE_CONTEXT")]
    public sealed class _SYSTEM_POWER_STATE_CONTEXT : DynamicStructure
    {
        public uint Reserved1 { get; }
        public uint TargetSystemState { get; }
        public uint EffectiveSystemState { get; }
        public uint CurrentSystemState { get; }
        public uint IgnoreHibernationPath { get; }
        public uint PseudoTransition { get; }
        public uint KernelSoftReboot { get; }
        public uint DirectedDripsTransition { get; }
        public uint Reserved2 { get; }
        public uint ContextAsUlong { get; }

        public _SYSTEM_POWER_STATE_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SYSTEM_POWER_STATE_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SYSTEM_POWER_STATE_CONTEXT.Reserved1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_STATE_CONTEXT.TargetSystemState),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_STATE_CONTEXT.EffectiveSystemState),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_STATE_CONTEXT.CurrentSystemState),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_STATE_CONTEXT.IgnoreHibernationPath),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_STATE_CONTEXT.PseudoTransition),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_STATE_CONTEXT.KernelSoftReboot),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_STATE_CONTEXT.DirectedDripsTransition),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_STATE_CONTEXT.Reserved2),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_STATE_CONTEXT.ContextAsUlong),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_SYSTEM_POWER_STATE_CONTEXT>((mem, ptr) => new _SYSTEM_POWER_STATE_CONTEXT(mem, ptr), offsets);
        }
    }
}