using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IO_STATUS_BLOCK")]
    public sealed class _IO_STATUS_BLOCK : DynamicStructure
    {
        public int Status { get; }
        public IntPtr Pointer { get; }
        public ulong Information { get; }

        public _IO_STATUS_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IO_STATUS_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IO_STATUS_BLOCK.Status),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IO_STATUS_BLOCK.Pointer),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IO_STATUS_BLOCK.Information),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_IO_STATUS_BLOCK>((mem, ptr) => new _IO_STATUS_BLOCK(mem, ptr), offsets);
        }
    }
}