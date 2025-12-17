using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_SYSTEM_INFORMATION")]
    public sealed class MiSystemInformation : DynamicStructure
    {
        [Offset(0UL)]
        public MiPoolState Pools { get => ReadStructure<MiPoolState>(nameof(Pools)); set => WriteStructure(nameof(Pools), value); }

        [Offset(448UL)]
        public MiSectionState Sections { get => ReadStructure<MiSectionState>(nameof(Sections)); set => WriteStructure(nameof(Sections), value); }

        [Offset(3520UL)]
        public MiSystemImageState SystemImages { get => ReadStructure<MiSystemImageState>(nameof(SystemImages)); set => WriteStructure(nameof(SystemImages), value); }

        [Offset(4096UL)]
        public MiProcessState Processes { get => ReadStructure<MiProcessState>(nameof(Processes)); set => WriteStructure(nameof(Processes), value); }

        [Offset(4224UL)]
        public MiHardwareState Hardware { get => ReadStructure<MiHardwareState>(nameof(Hardware)); set => WriteStructure(nameof(Hardware), value); }

        [Offset(9088UL)]
        public MiSystemVaState SystemVa { get => ReadStructure<MiSystemVaState>(nameof(SystemVa)); set => WriteStructure(nameof(SystemVa), value); }

        [Offset(13248UL)]
        public MiCombineState PageCombines { get => ReadStructure<MiCombineState>(nameof(PageCombines)); set => WriteStructure(nameof(PageCombines), value); }

        [Offset(13280UL)]
        public MiPagelistState PageLists { get => ReadStructure<MiPagelistState>(nameof(PageLists)); set => WriteStructure(nameof(PageLists), value); }

        [Offset(13568UL)]
        public MiPartitionState Partitions { get => ReadStructure<MiPartitionState>(nameof(Partitions)); set => WriteStructure(nameof(Partitions), value); }

        [Offset(13824UL)]
        public MiShutdownState Shutdowns { get => ReadStructure<MiShutdownState>(nameof(Shutdowns)); set => WriteStructure(nameof(Shutdowns), value); }

        [Offset(13952UL)]
        public MiErrorState Errors { get => ReadStructure<MiErrorState>(nameof(Errors)); set => WriteStructure(nameof(Errors), value); }

        [Offset(14208UL)]
        public MiDebuggerState Debugger { get => ReadStructure<MiDebuggerState>(nameof(Debugger)); set => WriteStructure(nameof(Debugger), value); }

        [Offset(37056UL)]
        public MiStandbyState Standby { get => ReadStructure<MiStandbyState>(nameof(Standby)); set => WriteStructure(nameof(Standby), value); }

        [Offset(37440UL)]
        public MiSystemPteState SystemPtes { get => ReadStructure<MiSystemPteState>(nameof(SystemPtes)); set => WriteStructure(nameof(SystemPtes), value); }

        [Offset(42816UL)]
        public MiIoPageState IoPages { get => ReadStructure<MiIoPageState>(nameof(IoPages)); set => WriteStructure(nameof(IoPages), value); }

        [Offset(43072UL)]
        public MiPagingIoState PagingIo { get => ReadStructure<MiPagingIoState>(nameof(PagingIo)); set => WriteStructure(nameof(PagingIo), value); }

        [Offset(43248UL)]
        public MiCommonPageState CommonPages { get => ReadStructure<MiCommonPageState>(nameof(CommonPages)); set => WriteStructure(nameof(CommonPages), value); }

        [Offset(43392UL)]
        public MiSystemTrimState Trims { get => ReadStructure<MiSystemTrimState>(nameof(Trims)); set => WriteStructure(nameof(Trims), value); }

        [Offset(43520UL)]
        public MiSystemAccelerators Accelerators { get => ReadStructure<MiSystemAccelerators>(nameof(Accelerators)); set => WriteStructure(nameof(Accelerators), value); }

        [Offset(43568UL)]
        public MiHotPatchState HotPatch { get => ReadStructure<MiHotPatchState>(nameof(HotPatch)); set => WriteStructure(nameof(HotPatch), value); }

        [Offset(43640UL)]
        public MiEnclaveState Enclaves { get => ReadStructure<MiEnclaveState>(nameof(Enclaves)); set => WriteStructure(nameof(Enclaves), value); }

        [Offset(43712UL)]
        public ulong Cookie { get => ReadHere<ulong>(nameof(Cookie)); set => WriteHere(nameof(Cookie), value); }

        [Offset(43720UL)]
        public IntPtr BootRegistryRuns { get => ReadHere<IntPtr>(nameof(BootRegistryRuns)); set => WriteHere(nameof(BootRegistryRuns), value); }

        [Offset(43728UL)]
        public int ZeroingDisabled { get => ReadHere<int>(nameof(ZeroingDisabled)); set => WriteHere(nameof(ZeroingDisabled), value); }

        [Offset(43732UL)]
        public byte FullyInitialized { get => ReadHere<byte>(nameof(FullyInitialized)); set => WriteHere(nameof(FullyInitialized), value); }

        [Offset(43733UL)]
        public byte SafeBooted { get => ReadHere<byte>(nameof(SafeBooted)); set => WriteHere(nameof(SafeBooted), value); }

        [Offset(43736UL)]
        public IntPtr TraceLogging { get => ReadHere<IntPtr>(nameof(TraceLogging)); set => WriteHere(nameof(TraceLogging), value); }

        [Offset(43776UL)]
        public MiVisibleState Vs { get => ReadStructure<MiVisibleState>(nameof(Vs)); set => WriteStructure(nameof(Vs), value); }

        public MiSystemInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiSystemInformation>();
        }
    }
}