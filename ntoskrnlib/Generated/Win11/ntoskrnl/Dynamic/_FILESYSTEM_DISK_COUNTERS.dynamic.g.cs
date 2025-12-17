using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FILESYSTEM_DISK_COUNTERS")]
    public sealed class _FILESYSTEM_DISK_COUNTERS : DynamicStructure
    {
        public ulong FsBytesRead { get; }
        public ulong FsBytesWritten { get; }

        public _FILESYSTEM_DISK_COUNTERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FILESYSTEM_DISK_COUNTERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FILESYSTEM_DISK_COUNTERS.FsBytesRead),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FILESYSTEM_DISK_COUNTERS.FsBytesWritten),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_FILESYSTEM_DISK_COUNTERS>((mem, ptr) => new _FILESYSTEM_DISK_COUNTERS(mem, ptr), offsets);
        }
    }
}