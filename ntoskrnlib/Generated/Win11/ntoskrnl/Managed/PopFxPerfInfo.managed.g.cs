using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_FX_PERF_INFO")]
    public sealed class PopFxPerfInfo : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Component { get => ReadHere<IntPtr>(nameof(Component)); set => WriteHere(nameof(Component), value); }

        [Offset(8UL)]
        public Kevent CompletedEvent { get => ReadStructure<Kevent>(nameof(CompletedEvent)); set => WriteStructure(nameof(CompletedEvent), value); }

        [Offset(32UL)]
        public IntPtr ComponentPerfState { get => ReadHere<IntPtr>(nameof(ComponentPerfState)); set => WriteHere(nameof(ComponentPerfState), value); }

        [Offset(40UL)]
        public PopFxPerfFlags Flags { get => ReadStructure<PopFxPerfFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(48UL)]
        public IntPtr LastChange { get => ReadHere<IntPtr>(nameof(LastChange)); set => WriteHere(nameof(LastChange), value); }

        [Offset(56UL)]
        public uint LastChangeCount { get => ReadHere<uint>(nameof(LastChangeCount)); set => WriteHere(nameof(LastChangeCount), value); }

        [Offset(64UL)]
        public ulong LastChangeStamp { get => ReadHere<ulong>(nameof(LastChangeStamp)); set => WriteHere(nameof(LastChangeStamp), value); }

        [Offset(72UL)]
        public byte LastChangeNominal { get => ReadHere<byte>(nameof(LastChangeNominal)); set => WriteHere(nameof(LastChangeNominal), value); }

        [Offset(73UL)]
        public byte PepRegistered { get => ReadHere<byte>(nameof(PepRegistered)); set => WriteHere(nameof(PepRegistered), value); }

        [Offset(74UL)]
        public byte QueryOnIdleStates { get => ReadHere<byte>(nameof(QueryOnIdleStates)); set => WriteHere(nameof(QueryOnIdleStates), value); }

        [Offset(80UL)]
        public IntPtr RequestDriverContext { get => ReadHere<IntPtr>(nameof(RequestDriverContext)); set => WriteHere(nameof(RequestDriverContext), value); }

        [Offset(88UL)]
        public PopFxWorkOrder WorkOrder { get => ReadStructure<PopFxWorkOrder>(nameof(WorkOrder)); set => WriteStructure(nameof(WorkOrder), value); }

        [Offset(144UL)]
        public uint SetsCount { get => ReadHere<uint>(nameof(SetsCount)); set => WriteHere(nameof(SetsCount), value); }

        [Offset(152UL)]
        public IntPtr Sets { get => ReadHere<IntPtr>(nameof(Sets)); set => WriteHere(nameof(Sets), value); }

        public PopFxPerfInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopFxPerfInfo>();
        }
    }
}