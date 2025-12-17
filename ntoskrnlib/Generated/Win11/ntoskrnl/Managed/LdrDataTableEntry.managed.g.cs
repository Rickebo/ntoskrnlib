using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_LDR_DATA_TABLE_ENTRY")]
    public sealed class LdrDataTableEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry InLoadOrderLinks { get => ReadStructure<ListEntry>(nameof(InLoadOrderLinks)); set => WriteStructure(nameof(InLoadOrderLinks), value); }

        [Offset(16UL)]
        public ListEntry InMemoryOrderLinks { get => ReadStructure<ListEntry>(nameof(InMemoryOrderLinks)); set => WriteStructure(nameof(InMemoryOrderLinks), value); }

        [Offset(32UL)]
        public ListEntry InInitializationOrderLinks { get => ReadStructure<ListEntry>(nameof(InInitializationOrderLinks)); set => WriteStructure(nameof(InInitializationOrderLinks), value); }

        [Offset(48UL)]
        public IntPtr DllBase { get => ReadHere<IntPtr>(nameof(DllBase)); set => WriteHere(nameof(DllBase), value); }

        [Offset(56UL)]
        public IntPtr EntryPoint { get => ReadHere<IntPtr>(nameof(EntryPoint)); set => WriteHere(nameof(EntryPoint), value); }

        [Offset(64UL)]
        public uint SizeOfImage { get => ReadHere<uint>(nameof(SizeOfImage)); set => WriteHere(nameof(SizeOfImage), value); }

        [Offset(72UL)]
        public UnicodeString FullDllName { get => ReadStructure<UnicodeString>(nameof(FullDllName)); set => WriteStructure(nameof(FullDllName), value); }

        [Offset(88UL)]
        public UnicodeString BaseDllName { get => ReadStructure<UnicodeString>(nameof(BaseDllName)); set => WriteStructure(nameof(BaseDllName), value); }

        [Offset(104UL)]
        [Length(4)]
        public DynamicArray FlagGroup { get => ReadStructure<DynamicArray>(nameof(FlagGroup)); set => WriteStructure(nameof(FlagGroup), value); }

        [Offset(104UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(104UL)]
        public uint PackagedBinary { get => ReadHere<uint>(nameof(PackagedBinary)); set => WriteHere(nameof(PackagedBinary), value); }

        [Offset(104UL)]
        public uint MarkedForRemoval { get => ReadHere<uint>(nameof(MarkedForRemoval)); set => WriteHere(nameof(MarkedForRemoval), value); }

        [Offset(104UL)]
        public uint ImageDll { get => ReadHere<uint>(nameof(ImageDll)); set => WriteHere(nameof(ImageDll), value); }

        [Offset(104UL)]
        public uint LoadNotificationsSent { get => ReadHere<uint>(nameof(LoadNotificationsSent)); set => WriteHere(nameof(LoadNotificationsSent), value); }

        [Offset(104UL)]
        public uint TelemetryEntryProcessed { get => ReadHere<uint>(nameof(TelemetryEntryProcessed)); set => WriteHere(nameof(TelemetryEntryProcessed), value); }

        [Offset(104UL)]
        public uint ProcessStaticImport { get => ReadHere<uint>(nameof(ProcessStaticImport)); set => WriteHere(nameof(ProcessStaticImport), value); }

        [Offset(104UL)]
        public uint InLegacyLists { get => ReadHere<uint>(nameof(InLegacyLists)); set => WriteHere(nameof(InLegacyLists), value); }

        [Offset(104UL)]
        public uint InIndexes { get => ReadHere<uint>(nameof(InIndexes)); set => WriteHere(nameof(InIndexes), value); }

        [Offset(104UL)]
        public uint ShimDll { get => ReadHere<uint>(nameof(ShimDll)); set => WriteHere(nameof(ShimDll), value); }

        [Offset(104UL)]
        public uint InExceptionTable { get => ReadHere<uint>(nameof(InExceptionTable)); set => WriteHere(nameof(InExceptionTable), value); }

        [Offset(104UL)]
        public uint VerifierProvider { get => ReadHere<uint>(nameof(VerifierProvider)); set => WriteHere(nameof(VerifierProvider), value); }

        [Offset(104UL)]
        public uint ShimEngineCalloutSent { get => ReadHere<uint>(nameof(ShimEngineCalloutSent)); set => WriteHere(nameof(ShimEngineCalloutSent), value); }

        [Offset(104UL)]
        public uint LoadInProgress { get => ReadHere<uint>(nameof(LoadInProgress)); set => WriteHere(nameof(LoadInProgress), value); }

        [Offset(104UL)]
        public uint LoadConfigProcessed { get => ReadHere<uint>(nameof(LoadConfigProcessed)); set => WriteHere(nameof(LoadConfigProcessed), value); }

        [Offset(104UL)]
        public uint EntryProcessed { get => ReadHere<uint>(nameof(EntryProcessed)); set => WriteHere(nameof(EntryProcessed), value); }

        [Offset(104UL)]
        public uint ProtectDelayLoad { get => ReadHere<uint>(nameof(ProtectDelayLoad)); set => WriteHere(nameof(ProtectDelayLoad), value); }

        [Offset(104UL)]
        public uint AuxIatCopyPrivate { get => ReadHere<uint>(nameof(AuxIatCopyPrivate)); set => WriteHere(nameof(AuxIatCopyPrivate), value); }

        [Offset(104UL)]
        public uint ReservedFlags3 { get => ReadHere<uint>(nameof(ReservedFlags3)); set => WriteHere(nameof(ReservedFlags3), value); }

        [Offset(104UL)]
        public uint DontCallForThreads { get => ReadHere<uint>(nameof(DontCallForThreads)); set => WriteHere(nameof(DontCallForThreads), value); }

        [Offset(104UL)]
        public uint ProcessAttachCalled { get => ReadHere<uint>(nameof(ProcessAttachCalled)); set => WriteHere(nameof(ProcessAttachCalled), value); }

        [Offset(104UL)]
        public uint ProcessAttachFailed { get => ReadHere<uint>(nameof(ProcessAttachFailed)); set => WriteHere(nameof(ProcessAttachFailed), value); }

        [Offset(104UL)]
        public uint ScpInExceptionTable { get => ReadHere<uint>(nameof(ScpInExceptionTable)); set => WriteHere(nameof(ScpInExceptionTable), value); }

        [Offset(104UL)]
        public uint CorImage { get => ReadHere<uint>(nameof(CorImage)); set => WriteHere(nameof(CorImage), value); }

        [Offset(104UL)]
        public uint DontRelocate { get => ReadHere<uint>(nameof(DontRelocate)); set => WriteHere(nameof(DontRelocate), value); }

        [Offset(104UL)]
        public uint CorILOnly { get => ReadHere<uint>(nameof(CorILOnly)); set => WriteHere(nameof(CorILOnly), value); }

        [Offset(104UL)]
        public uint ChpeImage { get => ReadHere<uint>(nameof(ChpeImage)); set => WriteHere(nameof(ChpeImage), value); }

        [Offset(104UL)]
        public uint ChpeEmulatorImage { get => ReadHere<uint>(nameof(ChpeEmulatorImage)); set => WriteHere(nameof(ChpeEmulatorImage), value); }

        [Offset(104UL)]
        public uint ReservedFlags5 { get => ReadHere<uint>(nameof(ReservedFlags5)); set => WriteHere(nameof(ReservedFlags5), value); }

        [Offset(104UL)]
        public uint Redirected { get => ReadHere<uint>(nameof(Redirected)); set => WriteHere(nameof(Redirected), value); }

        [Offset(104UL)]
        public uint ReservedFlags6 { get => ReadHere<uint>(nameof(ReservedFlags6)); set => WriteHere(nameof(ReservedFlags6), value); }

        [Offset(104UL)]
        public uint CompatDatabaseProcessed { get => ReadHere<uint>(nameof(CompatDatabaseProcessed)); set => WriteHere(nameof(CompatDatabaseProcessed), value); }

        [Offset(108UL)]
        public ushort ObsoleteLoadCount { get => ReadHere<ushort>(nameof(ObsoleteLoadCount)); set => WriteHere(nameof(ObsoleteLoadCount), value); }

        [Offset(110UL)]
        public ushort TlsIndex { get => ReadHere<ushort>(nameof(TlsIndex)); set => WriteHere(nameof(TlsIndex), value); }

        [Offset(112UL)]
        public ListEntry HashLinks { get => ReadStructure<ListEntry>(nameof(HashLinks)); set => WriteStructure(nameof(HashLinks), value); }

        [Offset(128UL)]
        public uint TimeDateStamp { get => ReadHere<uint>(nameof(TimeDateStamp)); set => WriteHere(nameof(TimeDateStamp), value); }

        [Offset(136UL)]
        public IntPtr EntryPointActivationContext { get => ReadHere<IntPtr>(nameof(EntryPointActivationContext)); set => WriteHere(nameof(EntryPointActivationContext), value); }

        [Offset(144UL)]
        public IntPtr Lock { get => ReadHere<IntPtr>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(152UL)]
        public IntPtr DdagNode { get => ReadHere<IntPtr>(nameof(DdagNode)); set => WriteHere(nameof(DdagNode), value); }

        [Offset(160UL)]
        public ListEntry NodeModuleLink { get => ReadStructure<ListEntry>(nameof(NodeModuleLink)); set => WriteStructure(nameof(NodeModuleLink), value); }

        [Offset(176UL)]
        public IntPtr LoadContext { get => ReadHere<IntPtr>(nameof(LoadContext)); set => WriteHere(nameof(LoadContext), value); }

        [Offset(184UL)]
        public IntPtr ParentDllBase { get => ReadHere<IntPtr>(nameof(ParentDllBase)); set => WriteHere(nameof(ParentDllBase), value); }

        [Offset(192UL)]
        public IntPtr SwitchBackContext { get => ReadHere<IntPtr>(nameof(SwitchBackContext)); set => WriteHere(nameof(SwitchBackContext), value); }

        [Offset(200UL)]
        public RtlBalancedNode BaseAddressIndexNode { get => ReadStructure<RtlBalancedNode>(nameof(BaseAddressIndexNode)); set => WriteStructure(nameof(BaseAddressIndexNode), value); }

        [Offset(224UL)]
        public RtlBalancedNode MappingInfoIndexNode { get => ReadStructure<RtlBalancedNode>(nameof(MappingInfoIndexNode)); set => WriteStructure(nameof(MappingInfoIndexNode), value); }

        [Offset(248UL)]
        public ulong OriginalBase { get => ReadHere<ulong>(nameof(OriginalBase)); set => WriteHere(nameof(OriginalBase), value); }

        [Offset(256UL)]
        public LargeInteger LoadTime { get => ReadStructure<LargeInteger>(nameof(LoadTime)); set => WriteStructure(nameof(LoadTime), value); }

        [Offset(264UL)]
        public uint BaseNameHashValue { get => ReadHere<uint>(nameof(BaseNameHashValue)); set => WriteHere(nameof(BaseNameHashValue), value); }

        [Offset(268UL)]
        public uint LoadReason { get => ReadHere<uint>(nameof(LoadReason)); set => WriteHere(nameof(LoadReason), value); }

        [Offset(272UL)]
        public uint ImplicitPathOptions { get => ReadHere<uint>(nameof(ImplicitPathOptions)); set => WriteHere(nameof(ImplicitPathOptions), value); }

        [Offset(276UL)]
        public uint ReferenceCount { get => ReadHere<uint>(nameof(ReferenceCount)); set => WriteHere(nameof(ReferenceCount), value); }

        [Offset(280UL)]
        public uint DependentLoadFlags { get => ReadHere<uint>(nameof(DependentLoadFlags)); set => WriteHere(nameof(DependentLoadFlags), value); }

        [Offset(284UL)]
        public byte SigningLevel { get => ReadHere<byte>(nameof(SigningLevel)); set => WriteHere(nameof(SigningLevel), value); }

        [Offset(288UL)]
        public uint CheckSum { get => ReadHere<uint>(nameof(CheckSum)); set => WriteHere(nameof(CheckSum), value); }

        [Offset(296UL)]
        public IntPtr ActivePatchImageBase { get => ReadHere<IntPtr>(nameof(ActivePatchImageBase)); set => WriteHere(nameof(ActivePatchImageBase), value); }

        [Offset(304UL)]
        public uint HotPatchState { get => ReadHere<uint>(nameof(HotPatchState)); set => WriteHere(nameof(HotPatchState), value); }

        public LdrDataTableEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LdrDataTableEntry>();
        }
    }
}