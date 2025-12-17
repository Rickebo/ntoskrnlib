using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_GUID_ENTRY")]
    public sealed class EtwGuidEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry GuidList { get => ReadStructure<ListEntry>(nameof(GuidList)); set => WriteStructure(nameof(GuidList), value); }

        [Offset(16UL)]
        public ListEntry SiloGuidList { get => ReadStructure<ListEntry>(nameof(SiloGuidList)); set => WriteStructure(nameof(SiloGuidList), value); }

        [Offset(32UL)]
        public long RefCount { get => ReadHere<long>(nameof(RefCount)); set => WriteHere(nameof(RefCount), value); }

        [Offset(40UL)]
        public Guid Guid { get => ReadStructure<Guid>(nameof(Guid)); set => WriteStructure(nameof(Guid), value); }

        [Offset(56UL)]
        public ListEntry RegListHead { get => ReadStructure<ListEntry>(nameof(RegListHead)); set => WriteStructure(nameof(RegListHead), value); }

        [Offset(72UL)]
        public IntPtr SecurityDescriptor { get => ReadHere<IntPtr>(nameof(SecurityDescriptor)); set => WriteHere(nameof(SecurityDescriptor), value); }

        [Offset(80UL)]
        public EtwLastEnableInfo LastEnable { get => ReadStructure<EtwLastEnableInfo>(nameof(LastEnable)); set => WriteStructure(nameof(LastEnable), value); }

        [Offset(80UL)]
        public ulong MatchId { get => ReadHere<ulong>(nameof(MatchId)); set => WriteHere(nameof(MatchId), value); }

        [Offset(96UL)]
        public TraceEnableInfo ProviderEnableInfo { get => ReadStructure<TraceEnableInfo>(nameof(ProviderEnableInfo)); set => WriteStructure(nameof(ProviderEnableInfo), value); }

        [Offset(128UL)]
        [Length(8)]
        public DynamicArray EnableInfo { get => ReadStructure<DynamicArray>(nameof(EnableInfo)); set => WriteStructure(nameof(EnableInfo), value); }

        [Offset(384UL)]
        public IntPtr FilterData { get => ReadHere<IntPtr>(nameof(FilterData)); set => WriteHere(nameof(FilterData), value); }

        [Offset(392UL)]
        public IntPtr SiloState { get => ReadHere<IntPtr>(nameof(SiloState)); set => WriteHere(nameof(SiloState), value); }

        [Offset(400UL)]
        public IntPtr HostEntry { get => ReadHere<IntPtr>(nameof(HostEntry)); set => WriteHere(nameof(HostEntry), value); }

        [Offset(408UL)]
        public ExPushLock Lock { get => ReadStructure<ExPushLock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        [Offset(416UL)]
        public IntPtr LockOwner { get => ReadHere<IntPtr>(nameof(LockOwner)); set => WriteHere(nameof(LockOwner), value); }

        public EtwGuidEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwGuidEntry>();
        }
    }
}