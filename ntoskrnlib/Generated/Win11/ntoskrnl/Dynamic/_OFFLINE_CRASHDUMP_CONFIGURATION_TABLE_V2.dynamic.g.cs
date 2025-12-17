using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OFFLINE_CRASHDUMP_CONFIGURATION_TABLE_V2")]
    public sealed class _OFFLINE_CRASHDUMP_CONFIGURATION_TABLE_V2 : DynamicStructure
    {
        public uint Version { get; }
        public uint AbnormalResetOccurred { get; }
        public uint OfflineMemoryDumpCapable { get; }
        public _LARGE_INTEGER ResetDataAddress { get; }
        public uint ResetDataSize { get; }

        public _OFFLINE_CRASHDUMP_CONFIGURATION_TABLE_V2(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OFFLINE_CRASHDUMP_CONFIGURATION_TABLE_V2()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OFFLINE_CRASHDUMP_CONFIGURATION_TABLE_V2.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OFFLINE_CRASHDUMP_CONFIGURATION_TABLE_V2.AbnormalResetOccurred),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_OFFLINE_CRASHDUMP_CONFIGURATION_TABLE_V2.OfflineMemoryDumpCapable),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_OFFLINE_CRASHDUMP_CONFIGURATION_TABLE_V2.ResetDataAddress),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_OFFLINE_CRASHDUMP_CONFIGURATION_TABLE_V2.ResetDataSize),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_OFFLINE_CRASHDUMP_CONFIGURATION_TABLE_V2>((mem, ptr) => new _OFFLINE_CRASHDUMP_CONFIGURATION_TABLE_V2(mem, ptr), offsets);
        }
    }
}