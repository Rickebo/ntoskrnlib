using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FILE_GET_QUOTA_INFORMATION")]
    public sealed class _FILE_GET_QUOTA_INFORMATION : DynamicStructure
    {
        public uint NextEntryOffset { get; }
        public uint SidLength { get; }
        public _SID Sid { get; }

        public _FILE_GET_QUOTA_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FILE_GET_QUOTA_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FILE_GET_QUOTA_INFORMATION.NextEntryOffset),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FILE_GET_QUOTA_INFORMATION.SidLength),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_FILE_GET_QUOTA_INFORMATION.Sid),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_FILE_GET_QUOTA_INFORMATION>((mem, ptr) => new _FILE_GET_QUOTA_INFORMATION(mem, ptr), offsets);
        }
    }
}