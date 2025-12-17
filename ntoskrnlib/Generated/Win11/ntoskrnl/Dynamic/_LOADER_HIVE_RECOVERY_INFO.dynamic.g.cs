using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LOADER_HIVE_RECOVERY_INFO")]
    public sealed class _LOADER_HIVE_RECOVERY_INFO : DynamicStructure
    {
        public uint Recovered { get; }
        public uint LegacyRecovery { get; }
        public uint SoftRebootConflict { get; }
        public uint MostRecentLog { get; }
        public uint LoadedFromSnapshot { get; }
        public uint Spare { get; }
        public uint LogNextSequence { get; }
        public uint LogMinimumSequence { get; }
        public uint LogCurrentOffset { get; }

        public _LOADER_HIVE_RECOVERY_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LOADER_HIVE_RECOVERY_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LOADER_HIVE_RECOVERY_INFO.Recovered),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LOADER_HIVE_RECOVERY_INFO.LegacyRecovery),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LOADER_HIVE_RECOVERY_INFO.SoftRebootConflict),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LOADER_HIVE_RECOVERY_INFO.MostRecentLog),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LOADER_HIVE_RECOVERY_INFO.LoadedFromSnapshot),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LOADER_HIVE_RECOVERY_INFO.Spare),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_LOADER_HIVE_RECOVERY_INFO.LogNextSequence),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_LOADER_HIVE_RECOVERY_INFO.LogMinimumSequence),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_LOADER_HIVE_RECOVERY_INFO.LogCurrentOffset),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_LOADER_HIVE_RECOVERY_INFO>((mem, ptr) => new _LOADER_HIVE_RECOVERY_INFO(mem, ptr), offsets);
        }
    }
}