using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_IRP_DATA")]
    public sealed class PopIrpData : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Link { get => ReadStructure<ListEntry>(nameof(Link)); set => WriteStructure(nameof(Link), value); }

        [Offset(16UL)]
        public IntPtr Irp { get => ReadHere<IntPtr>(nameof(Irp)); set => WriteHere(nameof(Irp), value); }

        [Offset(24UL)]
        public IntPtr Pdo { get => ReadHere<IntPtr>(nameof(Pdo)); set => WriteHere(nameof(Pdo), value); }

        [Offset(32UL)]
        public IntPtr TargetDevice { get => ReadHere<IntPtr>(nameof(TargetDevice)); set => WriteHere(nameof(TargetDevice), value); }

        [Offset(40UL)]
        public IntPtr CurrentDevice { get => ReadHere<IntPtr>(nameof(CurrentDevice)); set => WriteHere(nameof(CurrentDevice), value); }

        [Offset(48UL)]
        public ulong WatchdogStart { get => ReadHere<ulong>(nameof(WatchdogStart)); set => WriteHere(nameof(WatchdogStart), value); }

        [Offset(56UL)]
        public Ktimer WatchdogTimer { get => ReadStructure<Ktimer>(nameof(WatchdogTimer)); set => WriteStructure(nameof(WatchdogTimer), value); }

        [Offset(120UL)]
        public Kdpc WatchdogDpc { get => ReadStructure<Kdpc>(nameof(WatchdogDpc)); set => WriteStructure(nameof(WatchdogDpc), value); }

        [Offset(184UL)]
        public byte MinorFunction { get => ReadHere<byte>(nameof(MinorFunction)); set => WriteHere(nameof(MinorFunction), value); }

        [Offset(188UL)]
        public uint PowerStateType { get => ReadHere<uint>(nameof(PowerStateType)); set => WriteHere(nameof(PowerStateType), value); }

        [Offset(192UL)]
        public PowerState PowerState { get => ReadStructure<PowerState>(nameof(PowerState)); set => WriteStructure(nameof(PowerState), value); }

        [Offset(200UL)]
        public IntPtr FxDevice { get => ReadHere<IntPtr>(nameof(FxDevice)); set => WriteHere(nameof(FxDevice), value); }

        [Offset(208UL)]
        public byte SystemTransition { get => ReadHere<byte>(nameof(SystemTransition)); set => WriteHere(nameof(SystemTransition), value); }

        [Offset(209UL)]
        public byte NotifyPEP { get => ReadHere<byte>(nameof(NotifyPEP)); set => WriteHere(nameof(NotifyPEP), value); }

        [Offset(212UL)]
        public int IrpSequenceID { get => ReadHere<int>(nameof(IrpSequenceID)); set => WriteHere(nameof(IrpSequenceID), value); }

        [Offset(216UL)]
        public UnnamedTag Device { get => ReadStructure<UnnamedTag>(nameof(Device)); set => WriteStructure(nameof(Device), value); }

        [Offset(216UL)]
        public UnnamedTag System { get => ReadStructure<UnnamedTag>(nameof(System)); set => WriteStructure(nameof(System), value); }

        [Offset(280UL)]
        public uint DStateReason { get => ReadHere<uint>(nameof(DStateReason)); set => WriteHere(nameof(DStateReason), value); }

        [Offset(288UL)]
        public ulong WatchdogLock { get => ReadHere<ulong>(nameof(WatchdogLock)); set => WriteHere(nameof(WatchdogLock), value); }

        [Offset(296UL)]
        public uint WatchdogState { get => ReadHere<uint>(nameof(WatchdogState)); set => WriteHere(nameof(WatchdogState), value); }

        [Offset(304UL)]
        public ulong BlackboxWatchdogStartTime { get => ReadHere<ulong>(nameof(BlackboxWatchdogStartTime)); set => WriteHere(nameof(BlackboxWatchdogStartTime), value); }

        public PopIrpData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopIrpData>();
        }
    }
}