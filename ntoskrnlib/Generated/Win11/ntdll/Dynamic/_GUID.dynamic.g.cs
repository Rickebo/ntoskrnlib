using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_GUID")]
    public sealed class _GUID : DynamicStructure
    {
        public uint Data1 { get; }
        public ushort Data2 { get; }
        public ushort Data3 { get; }
        public byte[] Data4 { get; }

        public _GUID(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _GUID()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_GUID.Data1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_GUID.Data2),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_GUID.Data3),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_GUID.Data4),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_GUID>((mem, ptr) => new _GUID(mem, ptr), offsets);
        }
    }
}