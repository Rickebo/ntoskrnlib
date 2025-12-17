using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HAL_UNMASKED_INTERRUPT_INFORMATION")]
    public sealed class _HAL_UNMASKED_INTERRUPT_INFORMATION : DynamicStructure
    {
        public ushort Version { get; }
        public ushort Size { get; }
        public _HAL_UNMASKED_INTERRUPT_FLAGS Flags { get; }
        public uint Mode { get; }
        public uint Polarity { get; }
        public uint Gsiv { get; }
        public ushort PinNumber { get; }
        public IntPtr DeviceHandle { get; }

        public _HAL_UNMASKED_INTERRUPT_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HAL_UNMASKED_INTERRUPT_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HAL_UNMASKED_INTERRUPT_INFORMATION.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HAL_UNMASKED_INTERRUPT_INFORMATION.Size),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_HAL_UNMASKED_INTERRUPT_INFORMATION.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_HAL_UNMASKED_INTERRUPT_INFORMATION.Mode),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HAL_UNMASKED_INTERRUPT_INFORMATION.Polarity),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HAL_UNMASKED_INTERRUPT_INFORMATION.Gsiv),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HAL_UNMASKED_INTERRUPT_INFORMATION.PinNumber),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_HAL_UNMASKED_INTERRUPT_INFORMATION.DeviceHandle),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_HAL_UNMASKED_INTERRUPT_INFORMATION>((mem, ptr) => new _HAL_UNMASKED_INTERRUPT_INFORMATION(mem, ptr), offsets);
        }
    }
}