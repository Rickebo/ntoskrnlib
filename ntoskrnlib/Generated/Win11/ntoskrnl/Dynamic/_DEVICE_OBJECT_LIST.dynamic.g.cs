using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DEVICE_OBJECT_LIST")]
    public sealed class _DEVICE_OBJECT_LIST : DynamicStructure
    {
        public uint Count { get; }
        public uint MaxCount { get; }
        public uint TagCount { get; }
        public uint OperationCode { get; }
        public byte[] Devices { get; }

        public _DEVICE_OBJECT_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DEVICE_OBJECT_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DEVICE_OBJECT_LIST.Count),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT_LIST.MaxCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT_LIST.TagCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT_LIST.OperationCode),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT_LIST.Devices),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_DEVICE_OBJECT_LIST>((mem, ptr) => new _DEVICE_OBJECT_LIST(mem, ptr), offsets);
        }
    }
}