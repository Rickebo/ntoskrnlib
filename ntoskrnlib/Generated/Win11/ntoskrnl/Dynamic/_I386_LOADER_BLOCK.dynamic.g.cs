using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_I386_LOADER_BLOCK")]
    public sealed class _I386_LOADER_BLOCK : DynamicStructure
    {
        public IntPtr CommonDataArea { get; }
        public uint MachineType { get; }
        public uint VirtualBias { get; }

        public _I386_LOADER_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _I386_LOADER_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_I386_LOADER_BLOCK.CommonDataArea),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_I386_LOADER_BLOCK.MachineType),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_I386_LOADER_BLOCK.VirtualBias),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_I386_LOADER_BLOCK>((mem, ptr) => new _I386_LOADER_BLOCK(mem, ptr), offsets);
        }
    }
}