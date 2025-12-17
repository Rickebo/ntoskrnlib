using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_INTERRUPT_LINES")]
    public sealed class _INTERRUPT_LINES : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public uint ControllerId { get; }
        public int MinLine { get; }
        public int MaxLine { get; }
        public uint GsiBase { get; }
        public uint Type { get; }
        public uint SubType { get; }
        public IntPtr State { get; }
        public IntPtr InternalState { get; }
        public ulong MsiAddress { get; }
        public uint MsiData { get; }
        public _RTL_BITMAP MsiInUse { get; }

        public _INTERRUPT_LINES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _INTERRUPT_LINES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_INTERRUPT_LINES.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INTERRUPT_LINES.ControllerId),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_INTERRUPT_LINES.MinLine),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_INTERRUPT_LINES.MaxLine),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_INTERRUPT_LINES.GsiBase),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_INTERRUPT_LINES.Type),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_INTERRUPT_LINES.SubType),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_INTERRUPT_LINES.State),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_INTERRUPT_LINES.InternalState),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_INTERRUPT_LINES.MsiAddress),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_INTERRUPT_LINES.MsiData),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_INTERRUPT_LINES.MsiInUse),
                    new ulong[]
                    {
                        72UL
                    }
                }
            };
            Register<_INTERRUPT_LINES>((mem, ptr) => new _INTERRUPT_LINES(mem, ptr), offsets);
        }
    }
}