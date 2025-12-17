using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FAST_ERESOURCE")]
    public sealed class _FAST_ERESOURCE : DynamicStructure
    {
        public byte[] Reserved1 { get; }
        public uint Reserved2 { get; }
        public byte[] Reserved3 { get; }
        public uint[] Reserved4 { get; }
        public IntPtr Reserved5 { get; }
        public byte[] Reserved6 { get; }

        public _FAST_ERESOURCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FAST_ERESOURCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FAST_ERESOURCE.Reserved1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FAST_ERESOURCE.Reserved2),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_FAST_ERESOURCE.Reserved3),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_FAST_ERESOURCE.Reserved4),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_FAST_ERESOURCE.Reserved5),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_FAST_ERESOURCE.Reserved6),
                    new ulong[]
                    {
                        88UL
                    }
                }
            };
            Register<_FAST_ERESOURCE>((mem, ptr) => new _FAST_ERESOURCE(mem, ptr), offsets);
        }
    }
}