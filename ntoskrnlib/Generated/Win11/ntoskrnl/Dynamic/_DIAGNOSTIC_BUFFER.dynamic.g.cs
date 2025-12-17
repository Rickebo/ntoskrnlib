using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DIAGNOSTIC_BUFFER")]
    public sealed class _DIAGNOSTIC_BUFFER : DynamicStructure
    {
        public ulong Size { get; }
        public uint CallerType { get; }
        public ulong ProcessImageNameOffset { get; }
        public uint ProcessId { get; }
        public uint ServiceTag { get; }
        public ulong DeviceDescriptionOffset { get; }
        public ulong DevicePathOffset { get; }
        public ulong ReasonOffset { get; }

        public _DIAGNOSTIC_BUFFER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DIAGNOSTIC_BUFFER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DIAGNOSTIC_BUFFER.Size),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DIAGNOSTIC_BUFFER.CallerType),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DIAGNOSTIC_BUFFER.ProcessImageNameOffset),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DIAGNOSTIC_BUFFER.ProcessId),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DIAGNOSTIC_BUFFER.ServiceTag),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_DIAGNOSTIC_BUFFER.DeviceDescriptionOffset),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DIAGNOSTIC_BUFFER.DevicePathOffset),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DIAGNOSTIC_BUFFER.ReasonOffset),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_DIAGNOSTIC_BUFFER>((mem, ptr) => new _DIAGNOSTIC_BUFFER(mem, ptr), offsets);
        }
    }
}