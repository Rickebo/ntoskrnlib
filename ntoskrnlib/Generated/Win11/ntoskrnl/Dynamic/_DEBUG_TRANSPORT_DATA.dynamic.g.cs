using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DEBUG_TRANSPORT_DATA")]
    public sealed class _DEBUG_TRANSPORT_DATA : DynamicStructure
    {
        public uint HwContextSize { get; }
        public uint SharedVisibleDataSize { get; }
        public byte UseSerialFraming { get; }
        public byte ValidUSBCoreId { get; }
        public byte USBCoreId { get; }

        public _DEBUG_TRANSPORT_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DEBUG_TRANSPORT_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DEBUG_TRANSPORT_DATA.HwContextSize),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DEBUG_TRANSPORT_DATA.SharedVisibleDataSize),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEBUG_TRANSPORT_DATA.UseSerialFraming),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DEBUG_TRANSPORT_DATA.ValidUSBCoreId),
                    new ulong[]
                    {
                        9UL
                    }
                },
                {
                    nameof(_DEBUG_TRANSPORT_DATA.USBCoreId),
                    new ulong[]
                    {
                        10UL
                    }
                }
            };
            Register<_DEBUG_TRANSPORT_DATA>((mem, ptr) => new _DEBUG_TRANSPORT_DATA(mem, ptr), offsets);
        }
    }
}