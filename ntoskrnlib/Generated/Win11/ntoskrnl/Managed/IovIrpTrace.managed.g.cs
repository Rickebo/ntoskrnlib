using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOV_IRP_TRACE")]
    public sealed class IovIrpTrace : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Irp { get => ReadHere<IntPtr>(nameof(Irp)); set => WriteHere(nameof(Irp), value); }

        [Offset(8UL)]
        public IntPtr Thread { get => ReadHere<IntPtr>(nameof(Thread)); set => WriteHere(nameof(Thread), value); }

        [Offset(16UL)]
        public short KernelApcDisable { get => ReadHere<short>(nameof(KernelApcDisable)); set => WriteHere(nameof(KernelApcDisable), value); }

        [Offset(18UL)]
        public short SpecialApcDisable { get => ReadHere<short>(nameof(SpecialApcDisable)); set => WriteHere(nameof(SpecialApcDisable), value); }

        [Offset(16UL)]
        public uint CombinedApcDisable { get => ReadHere<uint>(nameof(CombinedApcDisable)); set => WriteHere(nameof(CombinedApcDisable), value); }

        [Offset(20UL)]
        public byte Irql { get => ReadHere<byte>(nameof(Irql)); set => WriteHere(nameof(Irql), value); }

        [Offset(24UL)]
        [Length(13)]
        public DynamicArray StackTrace { get => ReadStructure<DynamicArray>(nameof(StackTrace)); set => WriteStructure(nameof(StackTrace), value); }

        public IovIrpTrace(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IovIrpTrace>();
        }
    }
}