using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ARC_DISK_INFORMATION")]
    public sealed class _ARC_DISK_INFORMATION : DynamicStructure
    {
        public _LIST_ENTRY DiskSignatures { get; }

        public _ARC_DISK_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ARC_DISK_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ARC_DISK_INFORMATION.DiskSignatures),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_ARC_DISK_INFORMATION>((mem, ptr) => new _ARC_DISK_INFORMATION(mem, ptr), offsets);
        }
    }
}