using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HHIVE")]
    public sealed class Hhive : DynamicStructure
    {
        [Offset(0UL)]
        public uint Signature { get => ReadHere<uint>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(8UL)]
        public IntPtr GetCellRoutine { get => ReadHere<IntPtr>(nameof(GetCellRoutine)); set => WriteHere(nameof(GetCellRoutine), value); }

        [Offset(16UL)]
        public IntPtr ReleaseCellRoutine { get => ReadHere<IntPtr>(nameof(ReleaseCellRoutine)); set => WriteHere(nameof(ReleaseCellRoutine), value); }

        [Offset(24UL)]
        public IntPtr Allocate { get => ReadHere<IntPtr>(nameof(Allocate)); set => WriteHere(nameof(Allocate), value); }

        [Offset(32UL)]
        public IntPtr Free { get => ReadHere<IntPtr>(nameof(Free)); set => WriteHere(nameof(Free), value); }

        [Offset(40UL)]
        public IntPtr FileWrite { get => ReadHere<IntPtr>(nameof(FileWrite)); set => WriteHere(nameof(FileWrite), value); }

        [Offset(48UL)]
        public IntPtr FileRead { get => ReadHere<IntPtr>(nameof(FileRead)); set => WriteHere(nameof(FileRead), value); }

        [Offset(56UL)]
        public IntPtr HiveLoadFailure { get => ReadHere<IntPtr>(nameof(HiveLoadFailure)); set => WriteHere(nameof(HiveLoadFailure), value); }

        [Offset(64UL)]
        public IntPtr BaseBlock { get => ReadHere<IntPtr>(nameof(BaseBlock)); set => WriteHere(nameof(BaseBlock), value); }

        [Offset(72UL)]
        public CmsiRwLock FlusherLock { get => ReadStructure<CmsiRwLock>(nameof(FlusherLock)); set => WriteStructure(nameof(FlusherLock), value); }

        [Offset(80UL)]
        public CmsiRwLock WriterLock { get => ReadStructure<CmsiRwLock>(nameof(WriterLock)); set => WriteStructure(nameof(WriterLock), value); }

        [Offset(88UL)]
        public RtlBitmap DirtyVector { get => ReadStructure<RtlBitmap>(nameof(DirtyVector)); set => WriteStructure(nameof(DirtyVector), value); }

        [Offset(104UL)]
        public uint DirtyCount { get => ReadHere<uint>(nameof(DirtyCount)); set => WriteHere(nameof(DirtyCount), value); }

        [Offset(108UL)]
        public uint DirtyAlloc { get => ReadHere<uint>(nameof(DirtyAlloc)); set => WriteHere(nameof(DirtyAlloc), value); }

        [Offset(112UL)]
        public RtlBitmap UnreconciledVector { get => ReadStructure<RtlBitmap>(nameof(UnreconciledVector)); set => WriteStructure(nameof(UnreconciledVector), value); }

        [Offset(128UL)]
        public uint UnreconciledCount { get => ReadHere<uint>(nameof(UnreconciledCount)); set => WriteHere(nameof(UnreconciledCount), value); }

        [Offset(132UL)]
        public uint BaseBlockAlloc { get => ReadHere<uint>(nameof(BaseBlockAlloc)); set => WriteHere(nameof(BaseBlockAlloc), value); }

        [Offset(136UL)]
        public uint Cluster { get => ReadHere<uint>(nameof(Cluster)); set => WriteHere(nameof(Cluster), value); }

        [Offset(140UL)]
        public byte Flat { get => ReadHere<byte>(nameof(Flat)); set => WriteHere(nameof(Flat), value); }

        [Offset(140UL)]
        public byte ReadOnly { get => ReadHere<byte>(nameof(ReadOnly)); set => WriteHere(nameof(ReadOnly), value); }

        [Offset(140UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(141UL)]
        public byte DirtyFlag { get => ReadHere<byte>(nameof(DirtyFlag)); set => WriteHere(nameof(DirtyFlag), value); }

        [Offset(144UL)]
        public uint HvBinHeadersUse { get => ReadHere<uint>(nameof(HvBinHeadersUse)); set => WriteHere(nameof(HvBinHeadersUse), value); }

        [Offset(148UL)]
        public uint HvFreeCellsUse { get => ReadHere<uint>(nameof(HvFreeCellsUse)); set => WriteHere(nameof(HvFreeCellsUse), value); }

        [Offset(152UL)]
        public uint HvUsedCellsUse { get => ReadHere<uint>(nameof(HvUsedCellsUse)); set => WriteHere(nameof(HvUsedCellsUse), value); }

        [Offset(156UL)]
        public uint CmUsedCellsUse { get => ReadHere<uint>(nameof(CmUsedCellsUse)); set => WriteHere(nameof(CmUsedCellsUse), value); }

        [Offset(160UL)]
        public uint HiveFlags { get => ReadHere<uint>(nameof(HiveFlags)); set => WriteHere(nameof(HiveFlags), value); }

        [Offset(164UL)]
        public uint FlusherFlags { get => ReadHere<uint>(nameof(FlusherFlags)); set => WriteHere(nameof(FlusherFlags), value); }

        [Offset(168UL)]
        public uint CurrentLog { get => ReadHere<uint>(nameof(CurrentLog)); set => WriteHere(nameof(CurrentLog), value); }

        [Offset(172UL)]
        public uint CurrentLogSequence { get => ReadHere<uint>(nameof(CurrentLogSequence)); set => WriteHere(nameof(CurrentLogSequence), value); }

        [Offset(176UL)]
        public uint CurrentLogMinimumSequence { get => ReadHere<uint>(nameof(CurrentLogMinimumSequence)); set => WriteHere(nameof(CurrentLogMinimumSequence), value); }

        [Offset(180UL)]
        public uint CurrentLogOffset { get => ReadHere<uint>(nameof(CurrentLogOffset)); set => WriteHere(nameof(CurrentLogOffset), value); }

        [Offset(184UL)]
        public uint MinimumLogSequence { get => ReadHere<uint>(nameof(MinimumLogSequence)); set => WriteHere(nameof(MinimumLogSequence), value); }

        [Offset(188UL)]
        public uint LogFileSizeCap { get => ReadHere<uint>(nameof(LogFileSizeCap)); set => WriteHere(nameof(LogFileSizeCap), value); }

        [Offset(192UL)]
        [Length(2)]
        public DynamicArray LogDataPresent { get => ReadStructure<DynamicArray>(nameof(LogDataPresent)); set => WriteStructure(nameof(LogDataPresent), value); }

        [Offset(194UL)]
        public byte PrimaryFileValid { get => ReadHere<byte>(nameof(PrimaryFileValid)); set => WriteHere(nameof(PrimaryFileValid), value); }

        [Offset(195UL)]
        public byte BaseBlockDirty { get => ReadHere<byte>(nameof(BaseBlockDirty)); set => WriteHere(nameof(BaseBlockDirty), value); }

        [Offset(200UL)]
        public LargeInteger LastLogSwapTime { get => ReadStructure<LargeInteger>(nameof(LastLogSwapTime)); set => WriteStructure(nameof(LastLogSwapTime), value); }

        [Offset(208UL)]
        public ushort FirstLogFile { get => ReadHere<ushort>(nameof(FirstLogFile)); set => WriteHere(nameof(FirstLogFile), value); }

        [Offset(208UL)]
        public ushort SecondLogFile { get => ReadHere<ushort>(nameof(SecondLogFile)); set => WriteHere(nameof(SecondLogFile), value); }

        [Offset(208UL)]
        public ushort HeaderRecovered { get => ReadHere<ushort>(nameof(HeaderRecovered)); set => WriteHere(nameof(HeaderRecovered), value); }

        [Offset(208UL)]
        public ushort LegacyRecoveryIndicated { get => ReadHere<ushort>(nameof(LegacyRecoveryIndicated)); set => WriteHere(nameof(LegacyRecoveryIndicated), value); }

        [Offset(208UL)]
        public ushort RecoveryInformationReserved { get => ReadHere<ushort>(nameof(RecoveryInformationReserved)); set => WriteHere(nameof(RecoveryInformationReserved), value); }

        [Offset(208UL)]
        public ushort RecoveryInformation { get => ReadHere<ushort>(nameof(RecoveryInformation)); set => WriteHere(nameof(RecoveryInformation), value); }

        [Offset(210UL)]
        [Length(2)]
        public DynamicArray LogEntriesRecovered { get => ReadStructure<DynamicArray>(nameof(LogEntriesRecovered)); set => WriteStructure(nameof(LogEntriesRecovered), value); }

        [Offset(212UL)]
        public uint RefreshCount { get => ReadHere<uint>(nameof(RefreshCount)); set => WriteHere(nameof(RefreshCount), value); }

        [Offset(216UL)]
        public uint StorageTypeCount { get => ReadHere<uint>(nameof(StorageTypeCount)); set => WriteHere(nameof(StorageTypeCount), value); }

        [Offset(220UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(224UL)]
        public HvpViewMap ViewMap { get => ReadStructure<HvpViewMap>(nameof(ViewMap)); set => WriteStructure(nameof(ViewMap), value); }

        [Offset(280UL)]
        [Length(2)]
        public DynamicArray Storage { get => ReadStructure<DynamicArray>(nameof(Storage)); set => WriteStructure(nameof(Storage), value); }

        public Hhive(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Hhive>();
        }
    }
}