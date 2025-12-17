using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_NONOPAQUE_OPLOCK")]
    public sealed class NonopaqueOplock : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr IrpExclusiveOplock { get => ReadHere<IntPtr>(nameof(IrpExclusiveOplock)); set => WriteHere(nameof(IrpExclusiveOplock), value); }

        [Offset(8UL)]
        public IntPtr FileObject { get => ReadHere<IntPtr>(nameof(FileObject)); set => WriteHere(nameof(FileObject), value); }

        [Offset(16UL)]
        public IntPtr ExclusiveOplockOwner { get => ReadHere<IntPtr>(nameof(ExclusiveOplockOwner)); set => WriteHere(nameof(ExclusiveOplockOwner), value); }

        [Offset(24UL)]
        public IntPtr ExclusiveOplockOwnerThread { get => ReadHere<IntPtr>(nameof(ExclusiveOplockOwnerThread)); set => WriteHere(nameof(ExclusiveOplockOwnerThread), value); }

        [Offset(32UL)]
        public byte WaiterPriority { get => ReadHere<byte>(nameof(WaiterPriority)); set => WriteHere(nameof(WaiterPriority), value); }

        [Offset(40UL)]
        public ListEntry IrpOplocksR { get => ReadStructure<ListEntry>(nameof(IrpOplocksR)); set => WriteStructure(nameof(IrpOplocksR), value); }

        [Offset(56UL)]
        public ListEntry IrpOplocksRH { get => ReadStructure<ListEntry>(nameof(IrpOplocksRH)); set => WriteStructure(nameof(IrpOplocksRH), value); }

        [Offset(72UL)]
        public ListEntry RHBreakQueue { get => ReadStructure<ListEntry>(nameof(RHBreakQueue)); set => WriteStructure(nameof(RHBreakQueue), value); }

        [Offset(88UL)]
        public ListEntry WaitingIrps { get => ReadStructure<ListEntry>(nameof(WaitingIrps)); set => WriteStructure(nameof(WaitingIrps), value); }

        [Offset(104UL)]
        public ListEntry DelayAckFileObjectQueue { get => ReadStructure<ListEntry>(nameof(DelayAckFileObjectQueue)); set => WriteStructure(nameof(DelayAckFileObjectQueue), value); }

        [Offset(120UL)]
        public ListEntry AtomicQueue { get => ReadStructure<ListEntry>(nameof(AtomicQueue)); set => WriteStructure(nameof(AtomicQueue), value); }

        [Offset(136UL)]
        public IntPtr DeleterParentKey { get => ReadHere<IntPtr>(nameof(DeleterParentKey)); set => WriteHere(nameof(DeleterParentKey), value); }

        [Offset(144UL)]
        public uint OplockState { get => ReadHere<uint>(nameof(OplockState)); set => WriteHere(nameof(OplockState), value); }

        [Offset(152UL)]
        public IntPtr FastMutex { get => ReadHere<IntPtr>(nameof(FastMutex)); set => WriteHere(nameof(FastMutex), value); }

        [Offset(160UL)]
        public OplockTelemetry TelemetryData { get => ReadStructure<OplockTelemetry>(nameof(TelemetryData)); set => WriteStructure(nameof(TelemetryData), value); }

        [Offset(176UL)]
        public IntPtr AckTimeout { get => ReadHere<IntPtr>(nameof(AckTimeout)); set => WriteHere(nameof(AckTimeout), value); }

        public NonopaqueOplock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<NonopaqueOplock>();
        }
    }
}