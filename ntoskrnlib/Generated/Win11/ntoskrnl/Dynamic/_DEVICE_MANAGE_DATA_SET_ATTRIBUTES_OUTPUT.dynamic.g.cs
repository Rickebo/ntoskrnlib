using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT")]
    public sealed class _DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT : DynamicStructure
    {
        public uint Size { get; }
        public uint Action { get; }
        public uint Flags { get; }
        public uint OperationStatus { get; }
        public uint ExtendedError { get; }
        public uint TargetDetailedError { get; }
        public uint ReservedStatus { get; }
        public uint OutputBlockOffset { get; }
        public uint OutputBlockLength { get; }

        public _DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.Size),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.Action),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.Flags),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.OperationStatus),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.ExtendedError),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.TargetDetailedError),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.ReservedStatus),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.OutputBlockOffset),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.OutputBlockLength),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT>((mem, ptr) => new _DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT(mem, ptr), offsets);
        }
    }
}