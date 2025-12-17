using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PNP_ASSIGN_RESOURCES_CONTEXT")]
    public sealed class _PNP_ASSIGN_RESOURCES_CONTEXT : DynamicStructure
    {
        public uint IncludeFailedDevices { get; }
        public uint DeviceCount { get; }
        public byte[] DeviceList { get; }

        public _PNP_ASSIGN_RESOURCES_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PNP_ASSIGN_RESOURCES_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PNP_ASSIGN_RESOURCES_CONTEXT.IncludeFailedDevices),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PNP_ASSIGN_RESOURCES_CONTEXT.DeviceCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PNP_ASSIGN_RESOURCES_CONTEXT.DeviceList),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PNP_ASSIGN_RESOURCES_CONTEXT>((mem, ptr) => new _PNP_ASSIGN_RESOURCES_CONTEXT(mem, ptr), offsets);
        }
    }
}