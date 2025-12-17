using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IO_SECURITY_CONTEXT")]
    public sealed class _IO_SECURITY_CONTEXT : DynamicStructure
    {
        public IntPtr SecurityQos { get; }
        public IntPtr AccessState { get; }
        public uint DesiredAccess { get; }
        public uint FullCreateOptions { get; }

        public _IO_SECURITY_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IO_SECURITY_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IO_SECURITY_CONTEXT.SecurityQos),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IO_SECURITY_CONTEXT.AccessState),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IO_SECURITY_CONTEXT.DesiredAccess),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IO_SECURITY_CONTEXT.FullCreateOptions),
                    new ulong[]
                    {
                        20UL
                    }
                }
            };
            Register<_IO_SECURITY_CONTEXT>((mem, ptr) => new _IO_SECURITY_CONTEXT(mem, ptr), offsets);
        }
    }
}