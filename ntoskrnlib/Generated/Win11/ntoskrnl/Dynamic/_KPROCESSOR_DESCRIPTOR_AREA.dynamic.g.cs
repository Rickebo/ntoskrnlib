using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KPROCESSOR_DESCRIPTOR_AREA")]
    public sealed class _KPROCESSOR_DESCRIPTOR_AREA : DynamicStructure
    {
        public byte[] Idt { get; }
        public _KTSS64 Tss { get; }
        public ulong TssSpare { get; }
        public IntPtr KernelGsBase { get; }
        public IntPtr IdleStack { get; }
        public byte[] TssPad { get; }
        public byte[] GdtPadTemp { get; }
        public byte[] Gdt { get; }
        public _KLDTENTRY GdtCmTebDescriptor { get; }
        public byte[] GdtEndPadding { get; }
        public byte[] TransitionStack { get; }

        public _KPROCESSOR_DESCRIPTOR_AREA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KPROCESSOR_DESCRIPTOR_AREA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KPROCESSOR_DESCRIPTOR_AREA.Idt),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPROCESSOR_DESCRIPTOR_AREA.Tss),
                    new ulong[]
                    {
                        4096UL
                    }
                },
                {
                    nameof(_KPROCESSOR_DESCRIPTOR_AREA.TssSpare),
                    new ulong[]
                    {
                        4200UL
                    }
                },
                {
                    nameof(_KPROCESSOR_DESCRIPTOR_AREA.KernelGsBase),
                    new ulong[]
                    {
                        4208UL
                    }
                },
                {
                    nameof(_KPROCESSOR_DESCRIPTOR_AREA.IdleStack),
                    new ulong[]
                    {
                        4216UL
                    }
                },
                {
                    nameof(_KPROCESSOR_DESCRIPTOR_AREA.TssPad),
                    new ulong[]
                    {
                        4224UL
                    }
                },
                {
                    nameof(_KPROCESSOR_DESCRIPTOR_AREA.GdtPadTemp),
                    new ulong[]
                    {
                        8112UL
                    }
                },
                {
                    nameof(_KPROCESSOR_DESCRIPTOR_AREA.Gdt),
                    new ulong[]
                    {
                        12208UL
                    }
                },
                {
                    nameof(_KPROCESSOR_DESCRIPTOR_AREA.GdtCmTebDescriptor),
                    new ulong[]
                    {
                        12288UL
                    }
                },
                {
                    nameof(_KPROCESSOR_DESCRIPTOR_AREA.GdtEndPadding),
                    new ulong[]
                    {
                        12296UL
                    }
                },
                {
                    nameof(_KPROCESSOR_DESCRIPTOR_AREA.TransitionStack),
                    new ulong[]
                    {
                        16384UL
                    }
                }
            };
            Register<_KPROCESSOR_DESCRIPTOR_AREA>((mem, ptr) => new _KPROCESSOR_DESCRIPTOR_AREA(mem, ptr), offsets);
        }
    }
}