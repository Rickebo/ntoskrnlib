using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_FUNCTION_TABLE")]
    public sealed class ExtIommuFunctionTable : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ConfigureSettings { get => ReadHere<IntPtr>(nameof(ConfigureSettings)); set => WriteHere(nameof(ConfigureSettings), value); }

        [Offset(8UL)]
        public IntPtr Initialize { get => ReadHere<IntPtr>(nameof(Initialize)); set => WriteHere(nameof(Initialize), value); }

        [Offset(16UL)]
        public IntPtr AllocateDomain { get => ReadHere<IntPtr>(nameof(AllocateDomain)); set => WriteHere(nameof(AllocateDomain), value); }

        [Offset(24UL)]
        public IntPtr FreeDomain { get => ReadHere<IntPtr>(nameof(FreeDomain)); set => WriteHere(nameof(FreeDomain), value); }

        [Offset(32UL)]
        public IntPtr CreateDevice { get => ReadHere<IntPtr>(nameof(CreateDevice)); set => WriteHere(nameof(CreateDevice), value); }

        [Offset(40UL)]
        public IntPtr DeleteDevice { get => ReadHere<IntPtr>(nameof(DeleteDevice)); set => WriteHere(nameof(DeleteDevice), value); }

        [Offset(48UL)]
        public IntPtr OwnDevice { get => ReadHere<IntPtr>(nameof(OwnDevice)); set => WriteHere(nameof(OwnDevice), value); }

        [Offset(56UL)]
        public IntPtr ConfigureDeviceFaultReporting { get => ReadHere<IntPtr>(nameof(ConfigureDeviceFaultReporting)); set => WriteHere(nameof(ConfigureDeviceFaultReporting), value); }

        [Offset(64UL)]
        public IntPtr AttachDeviceDomain { get => ReadHere<IntPtr>(nameof(AttachDeviceDomain)); set => WriteHere(nameof(AttachDeviceDomain), value); }

        [Offset(72UL)]
        public IntPtr DetachDeviceDomain { get => ReadHere<IntPtr>(nameof(DetachDeviceDomain)); set => WriteHere(nameof(DetachDeviceDomain), value); }

        [Offset(80UL)]
        public IntPtr FlushDomainTb { get => ReadHere<IntPtr>(nameof(FlushDomainTb)); set => WriteHere(nameof(FlushDomainTb), value); }

        [Offset(88UL)]
        public IntPtr SyncFlush { get => ReadHere<IntPtr>(nameof(SyncFlush)); set => WriteHere(nameof(SyncFlush), value); }

        [Offset(96UL)]
        public IntPtr CompleteFlush { get => ReadHere<IntPtr>(nameof(CompleteFlush)); set => WriteHere(nameof(CompleteFlush), value); }

        [Offset(104UL)]
        public IntPtr AllocateRemappingTableEntry { get => ReadHere<IntPtr>(nameof(AllocateRemappingTableEntry)); set => WriteHere(nameof(AllocateRemappingTableEntry), value); }

        [Offset(112UL)]
        public IntPtr FreeRemappingTableEntry { get => ReadHere<IntPtr>(nameof(FreeRemappingTableEntry)); set => WriteHere(nameof(FreeRemappingTableEntry), value); }

        [Offset(120UL)]
        public IntPtr UpdateRemappingTableEntry { get => ReadHere<IntPtr>(nameof(UpdateRemappingTableEntry)); set => WriteHere(nameof(UpdateRemappingTableEntry), value); }

        [Offset(128UL)]
        public IntPtr InvalidateRemappingTableEntry { get => ReadHere<IntPtr>(nameof(InvalidateRemappingTableEntry)); set => WriteHere(nameof(InvalidateRemappingTableEntry), value); }

        [Offset(136UL)]
        public IntPtr UpdateRemappingDestination { get => ReadHere<IntPtr>(nameof(UpdateRemappingDestination)); set => WriteHere(nameof(UpdateRemappingDestination), value); }

        [Offset(144UL)]
        public IntPtr CaptureGlobalCrashdumpState { get => ReadHere<IntPtr>(nameof(CaptureGlobalCrashdumpState)); set => WriteHere(nameof(CaptureGlobalCrashdumpState), value); }

        public ExtIommuFunctionTable(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExtIommuFunctionTable>();
        }
    }
}