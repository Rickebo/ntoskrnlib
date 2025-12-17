using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!DEBUG_DEVICE_ADDRESS")]
    public sealed class DEBUG_DEVICE_ADDRESS : DynamicStructure
    {
        public byte Type { get; }
        public byte Valid { get; }
        public byte[] Reserved { get; }
        public byte BitWidth { get; }
        public byte AccessSize { get; }
        public IntPtr TranslatedAddress { get; }
        public uint Length { get; }

        public DEBUG_DEVICE_ADDRESS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static DEBUG_DEVICE_ADDRESS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(DEBUG_DEVICE_ADDRESS.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(DEBUG_DEVICE_ADDRESS.Valid),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(DEBUG_DEVICE_ADDRESS.Reserved),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(DEBUG_DEVICE_ADDRESS.BitWidth),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(DEBUG_DEVICE_ADDRESS.AccessSize),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(DEBUG_DEVICE_ADDRESS.TranslatedAddress),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(DEBUG_DEVICE_ADDRESS.Length),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<DEBUG_DEVICE_ADDRESS>((mem, ptr) => new DEBUG_DEVICE_ADDRESS(mem, ptr), offsets);
        }
    }
}