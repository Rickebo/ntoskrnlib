using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NT_IORING_BUFFERREF")]
    public sealed class _NT_IORING_BUFFERREF : DynamicStructure
    {
        public IntPtr Address { get; }
        public IORING_REGISTERED_BUFFER FixedBuffer { get; }

        public _NT_IORING_BUFFERREF(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NT_IORING_BUFFERREF()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NT_IORING_BUFFERREF.Address),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NT_IORING_BUFFERREF.FixedBuffer),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_NT_IORING_BUFFERREF>((mem, ptr) => new _NT_IORING_BUFFERREF(mem, ptr), offsets);
        }
    }
}