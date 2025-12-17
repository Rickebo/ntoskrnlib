using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DEVICE_DATA_SET_RANGE")]
    public sealed class _DEVICE_DATA_SET_RANGE : DynamicStructure
    {
        public long StartingOffset { get; }
        public ulong LengthInBytes { get; }

        public _DEVICE_DATA_SET_RANGE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DEVICE_DATA_SET_RANGE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DEVICE_DATA_SET_RANGE.StartingOffset),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DEVICE_DATA_SET_RANGE.LengthInBytes),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_DEVICE_DATA_SET_RANGE>((mem, ptr) => new _DEVICE_DATA_SET_RANGE(mem, ptr), offsets);
        }
    }
}