using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IO_CLIENT_EXTENSION")]
    public sealed class _IO_CLIENT_EXTENSION : DynamicStructure
    {
        public IntPtr NextExtension { get; }
        public IntPtr ClientIdentificationAddress { get; }

        public _IO_CLIENT_EXTENSION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IO_CLIENT_EXTENSION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IO_CLIENT_EXTENSION.NextExtension),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IO_CLIENT_EXTENSION.ClientIdentificationAddress),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_IO_CLIENT_EXTENSION>((mem, ptr) => new _IO_CLIENT_EXTENSION(mem, ptr), offsets);
        }
    }
}