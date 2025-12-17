using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_TRIAGE_POP_FX_DEVICE")]
    public sealed class TriagePopFxDevice : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Link { get => ReadStructure<ListEntry>(nameof(Link)); set => WriteStructure(nameof(Link), value); }

        [Offset(16UL)]
        public IntPtr Irp { get => ReadHere<IntPtr>(nameof(Irp)); set => WriteHere(nameof(Irp), value); }

        [Offset(24UL)]
        public IntPtr IrpData { get => ReadHere<IntPtr>(nameof(IrpData)); set => WriteHere(nameof(IrpData), value); }

        [Offset(32UL)]
        public int Status { get => ReadHere<int>(nameof(Status)); set => WriteHere(nameof(Status), value); }

        [Offset(36UL)]
        public int PowerReqCall { get => ReadHere<int>(nameof(PowerReqCall)); set => WriteHere(nameof(PowerReqCall), value); }

        [Offset(40UL)]
        public int PowerNotReqCall { get => ReadHere<int>(nameof(PowerNotReqCall)); set => WriteHere(nameof(PowerNotReqCall), value); }

        [Offset(48UL)]
        public IntPtr DeviceNode { get => ReadHere<IntPtr>(nameof(DeviceNode)); set => WriteHere(nameof(DeviceNode), value); }

        public TriagePopFxDevice(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TriagePopFxDevice>();
        }
    }
}