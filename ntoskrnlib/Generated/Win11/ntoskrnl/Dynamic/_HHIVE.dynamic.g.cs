using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HHIVE")]
    public sealed class _HHIVE : DynamicStructure
    {
        public uint Signature { get; }
        public IntPtr GetCellRoutine { get; }
        public IntPtr ReleaseCellRoutine { get; }
        public IntPtr Allocate { get; }
        public IntPtr Free { get; }
        public IntPtr FileWrite { get; }
        public IntPtr FileRead { get; }
        public IntPtr HiveLoadFailure { get; }
        public IntPtr BaseBlock { get; }
        public _CMSI_RW_LOCK FlusherLock { get; }
        public _CMSI_RW_LOCK WriterLock { get; }
        public _RTL_BITMAP DirtyVector { get; }
        public uint DirtyCount { get; }
        public uint DirtyAlloc { get; }
        public _RTL_BITMAP UnreconciledVector { get; }
        public uint UnreconciledCount { get; }
        public uint BaseBlockAlloc { get; }
        public uint Cluster { get; }
        public byte Flat { get; }
        public byte ReadOnly { get; }
        public byte Reserved { get; }
        public byte DirtyFlag { get; }
        public uint HvBinHeadersUse { get; }
        public uint HvFreeCellsUse { get; }
        public uint HvUsedCellsUse { get; }
        public uint CmUsedCellsUse { get; }
        public uint HiveFlags { get; }
        public uint FlusherFlags { get; }
        public uint CurrentLog { get; }
        public uint CurrentLogSequence { get; }
        public uint CurrentLogMinimumSequence { get; }
        public uint CurrentLogOffset { get; }
        public uint MinimumLogSequence { get; }
        public uint LogFileSizeCap { get; }
        public byte[] LogDataPresent { get; }
        public byte PrimaryFileValid { get; }
        public byte BaseBlockDirty { get; }
        public _LARGE_INTEGER LastLogSwapTime { get; }
        public ushort FirstLogFile { get; }
        public ushort SecondLogFile { get; }
        public ushort HeaderRecovered { get; }
        public ushort LegacyRecoveryIndicated { get; }
        public ushort RecoveryInformationReserved { get; }
        public ushort RecoveryInformation { get; }
        public byte[] LogEntriesRecovered { get; }
        public uint RefreshCount { get; }
        public uint StorageTypeCount { get; }
        public uint Version { get; }
        public _HVP_VIEW_MAP ViewMap { get; }
        public byte[] Storage { get; }

        public _HHIVE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HHIVE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HHIVE.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HHIVE.GetCellRoutine),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HHIVE.ReleaseCellRoutine),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HHIVE.Allocate),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HHIVE.Free),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HHIVE.FileWrite),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_HHIVE.FileRead),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_HHIVE.HiveLoadFailure),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_HHIVE.BaseBlock),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_HHIVE.FlusherLock),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_HHIVE.WriterLock),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_HHIVE.DirtyVector),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_HHIVE.DirtyCount),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_HHIVE.DirtyAlloc),
                    new ulong[]
                    {
                        108UL
                    }
                },
                {
                    nameof(_HHIVE.UnreconciledVector),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_HHIVE.UnreconciledCount),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_HHIVE.BaseBlockAlloc),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_HHIVE.Cluster),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_HHIVE.Flat),
                    new ulong[]
                    {
                        140UL
                    }
                },
                {
                    nameof(_HHIVE.ReadOnly),
                    new ulong[]
                    {
                        140UL
                    }
                },
                {
                    nameof(_HHIVE.Reserved),
                    new ulong[]
                    {
                        140UL
                    }
                },
                {
                    nameof(_HHIVE.DirtyFlag),
                    new ulong[]
                    {
                        141UL
                    }
                },
                {
                    nameof(_HHIVE.HvBinHeadersUse),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_HHIVE.HvFreeCellsUse),
                    new ulong[]
                    {
                        148UL
                    }
                },
                {
                    nameof(_HHIVE.HvUsedCellsUse),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_HHIVE.CmUsedCellsUse),
                    new ulong[]
                    {
                        156UL
                    }
                },
                {
                    nameof(_HHIVE.HiveFlags),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_HHIVE.FlusherFlags),
                    new ulong[]
                    {
                        164UL
                    }
                },
                {
                    nameof(_HHIVE.CurrentLog),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_HHIVE.CurrentLogSequence),
                    new ulong[]
                    {
                        172UL
                    }
                },
                {
                    nameof(_HHIVE.CurrentLogMinimumSequence),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_HHIVE.CurrentLogOffset),
                    new ulong[]
                    {
                        180UL
                    }
                },
                {
                    nameof(_HHIVE.MinimumLogSequence),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_HHIVE.LogFileSizeCap),
                    new ulong[]
                    {
                        188UL
                    }
                },
                {
                    nameof(_HHIVE.LogDataPresent),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_HHIVE.PrimaryFileValid),
                    new ulong[]
                    {
                        194UL
                    }
                },
                {
                    nameof(_HHIVE.BaseBlockDirty),
                    new ulong[]
                    {
                        195UL
                    }
                },
                {
                    nameof(_HHIVE.LastLogSwapTime),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_HHIVE.FirstLogFile),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_HHIVE.SecondLogFile),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_HHIVE.HeaderRecovered),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_HHIVE.LegacyRecoveryIndicated),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_HHIVE.RecoveryInformationReserved),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_HHIVE.RecoveryInformation),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_HHIVE.LogEntriesRecovered),
                    new ulong[]
                    {
                        210UL
                    }
                },
                {
                    nameof(_HHIVE.RefreshCount),
                    new ulong[]
                    {
                        212UL
                    }
                },
                {
                    nameof(_HHIVE.StorageTypeCount),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_HHIVE.Version),
                    new ulong[]
                    {
                        220UL
                    }
                },
                {
                    nameof(_HHIVE.ViewMap),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_HHIVE.Storage),
                    new ulong[]
                    {
                        280UL
                    }
                }
            };
            Register<_HHIVE>((mem, ptr) => new _HHIVE(mem, ptr), offsets);
        }
    }
}