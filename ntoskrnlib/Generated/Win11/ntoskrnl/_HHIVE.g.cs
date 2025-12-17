#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1544)]
    public partial struct _HHIVE
    {
        [FieldOffset(0)]
        public uint Signature;
        [FieldOffset(8)]
        public IntPtr GetCellRoutine;
        [FieldOffset(16)]
        public IntPtr ReleaseCellRoutine;
        [FieldOffset(24)]
        public IntPtr Allocate;
        [FieldOffset(32)]
        public IntPtr Free;
        [FieldOffset(40)]
        public IntPtr FileWrite;
        [FieldOffset(48)]
        public IntPtr FileRead;
        [FieldOffset(56)]
        public IntPtr HiveLoadFailure;
        [FieldOffset(64)]
        public IntPtr BaseBlock;
        [FieldOffset(72)]
        public _CMSI_RW_LOCK FlusherLock;
        [FieldOffset(80)]
        public _CMSI_RW_LOCK WriterLock;
        [FieldOffset(88)]
        public _RTL_BITMAP DirtyVector;
        [FieldOffset(104)]
        public uint DirtyCount;
        [FieldOffset(108)]
        public uint DirtyAlloc;
        [FieldOffset(112)]
        public _RTL_BITMAP UnreconciledVector;
        [FieldOffset(128)]
        public uint UnreconciledCount;
        [FieldOffset(132)]
        public uint BaseBlockAlloc;
        [FieldOffset(136)]
        public uint Cluster;
        [FieldOffset(140)]
        public byte Flat;
        [FieldOffset(140)]
        public byte ReadOnly;
        [FieldOffset(140)]
        public byte Reserved;
        [FieldOffset(141)]
        public byte DirtyFlag;
        [FieldOffset(144)]
        public uint HvBinHeadersUse;
        [FieldOffset(148)]
        public uint HvFreeCellsUse;
        [FieldOffset(152)]
        public uint HvUsedCellsUse;
        [FieldOffset(156)]
        public uint CmUsedCellsUse;
        [FieldOffset(160)]
        public uint HiveFlags;
        [FieldOffset(164)]
        public uint FlusherFlags;
        [FieldOffset(168)]
        public uint CurrentLog;
        [FieldOffset(172)]
        public uint CurrentLogSequence;
        [FieldOffset(176)]
        public uint CurrentLogMinimumSequence;
        [FieldOffset(180)]
        public uint CurrentLogOffset;
        [FieldOffset(184)]
        public uint MinimumLogSequence;
        [FieldOffset(188)]
        public uint LogFileSizeCap;
        [FieldOffset(192)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] LogDataPresent;
        [FieldOffset(194)]
        public byte PrimaryFileValid;
        [FieldOffset(195)]
        public byte BaseBlockDirty;
        [FieldOffset(200)]
        public _LARGE_INTEGER LastLogSwapTime;
        [FieldOffset(208)]
        public ushort FirstLogFile;
        [FieldOffset(208)]
        public ushort SecondLogFile;
        [FieldOffset(208)]
        public ushort HeaderRecovered;
        [FieldOffset(208)]
        public ushort LegacyRecoveryIndicated;
        [FieldOffset(208)]
        public ushort RecoveryInformationReserved;
        [FieldOffset(208)]
        public ushort RecoveryInformation;
        [FieldOffset(210)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] LogEntriesRecovered;
        [FieldOffset(212)]
        public uint RefreshCount;
        [FieldOffset(216)]
        public uint StorageTypeCount;
        [FieldOffset(220)]
        public uint Version;
        [FieldOffset(224)]
        public _HVP_VIEW_MAP ViewMap;
        [FieldOffset(280)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _DUAL[] Storage;
    }
}