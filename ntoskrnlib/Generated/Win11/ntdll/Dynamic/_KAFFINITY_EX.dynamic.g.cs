using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KAFFINITY_EX")]
    public sealed class _KAFFINITY_EX : DynamicStructure
    {
        public ushort Count { get; }
        public ushort Size { get; }
        public uint Reserved { get; }
        public ulong[] Bitmap { get; }
        public ulong[] StaticBitmap { get; }

        public _KAFFINITY_EX(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KAFFINITY_EX()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KAFFINITY_EX.Count),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KAFFINITY_EX.Size),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_KAFFINITY_EX.Reserved),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KAFFINITY_EX.Bitmap),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KAFFINITY_EX.StaticBitmap),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_KAFFINITY_EX>((mem, ptr) => new _KAFFINITY_EX(mem, ptr), offsets);
        }
    }
}