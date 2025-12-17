using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_FX_DRIVER_CALLBACKS")]
    public sealed class _POP_FX_DRIVER_CALLBACKS : DynamicStructure
    {
        public IntPtr ComponentActive { get; }
        public IntPtr ComponentIdle { get; }
        public IntPtr ComponentIdleState { get; }
        public IntPtr DevicePowerRequired { get; }
        public IntPtr DevicePowerNotRequired { get; }
        public IntPtr PowerControl { get; }
        public IntPtr ComponentCriticalTransition { get; }
        public IntPtr DripsWatchdogCallback { get; }
        public IntPtr DirectedPowerUpCallback { get; }
        public IntPtr DirectedPowerDownCallback { get; }

        public _POP_FX_DRIVER_CALLBACKS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_FX_DRIVER_CALLBACKS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_FX_DRIVER_CALLBACKS.ComponentActive),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_DRIVER_CALLBACKS.ComponentIdle),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POP_FX_DRIVER_CALLBACKS.ComponentIdleState),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_FX_DRIVER_CALLBACKS.DevicePowerRequired),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_POP_FX_DRIVER_CALLBACKS.DevicePowerNotRequired),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_POP_FX_DRIVER_CALLBACKS.PowerControl),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_POP_FX_DRIVER_CALLBACKS.ComponentCriticalTransition),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_POP_FX_DRIVER_CALLBACKS.DripsWatchdogCallback),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_POP_FX_DRIVER_CALLBACKS.DirectedPowerUpCallback),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_POP_FX_DRIVER_CALLBACKS.DirectedPowerDownCallback),
                    new ulong[]
                    {
                        72UL
                    }
                }
            };
            Register<_POP_FX_DRIVER_CALLBACKS>((mem, ptr) => new _POP_FX_DRIVER_CALLBACKS(mem, ptr), offsets);
        }
    }
}