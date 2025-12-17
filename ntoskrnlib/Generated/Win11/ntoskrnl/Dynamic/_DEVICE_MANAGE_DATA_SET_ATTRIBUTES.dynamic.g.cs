using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DEVICE_MANAGE_DATA_SET_ATTRIBUTES")]
    public sealed class _DEVICE_MANAGE_DATA_SET_ATTRIBUTES : DynamicStructure
    {
        public uint Size { get; }
        public uint Action { get; }
        public uint Flags { get; }
        public uint ParameterBlockOffset { get; }
        public uint ParameterBlockLength { get; }
        public uint DataSetRangesOffset { get; }
        public uint DataSetRangesLength { get; }

        public _DEVICE_MANAGE_DATA_SET_ATTRIBUTES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DEVICE_MANAGE_DATA_SET_ATTRIBUTES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DEVICE_MANAGE_DATA_SET_ATTRIBUTES.Size),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DEVICE_MANAGE_DATA_SET_ATTRIBUTES.Action),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_MANAGE_DATA_SET_ATTRIBUTES.Flags),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DEVICE_MANAGE_DATA_SET_ATTRIBUTES.ParameterBlockOffset),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_DEVICE_MANAGE_DATA_SET_ATTRIBUTES.ParameterBlockLength),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DEVICE_MANAGE_DATA_SET_ATTRIBUTES.DataSetRangesOffset),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_DEVICE_MANAGE_DATA_SET_ATTRIBUTES.DataSetRangesLength),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_DEVICE_MANAGE_DATA_SET_ATTRIBUTES>((mem, ptr) => new _DEVICE_MANAGE_DATA_SET_ATTRIBUTES(mem, ptr), offsets);
        }
    }
}