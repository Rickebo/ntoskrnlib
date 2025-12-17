using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_BLOCK_IO_LAYER_INFORMATION")]
    public sealed class _BLOCK_IO_LAYER_INFORMATION : DynamicStructure
    {
        public IntPtr ArcName { get; }

        public _BLOCK_IO_LAYER_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _BLOCK_IO_LAYER_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_BLOCK_IO_LAYER_INFORMATION.ArcName),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_BLOCK_IO_LAYER_INFORMATION>((mem, ptr) => new _BLOCK_IO_LAYER_INFORMATION(mem, ptr), offsets);
        }
    }
}