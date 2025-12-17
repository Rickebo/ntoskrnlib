using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KAPC_STATE")]
    public sealed class KapcState : DynamicStructure
    {
        [Offset(0UL)]
        [Length(2)]
        public DynamicArray ApcListHead { get => ReadStructure<DynamicArray>(nameof(ApcListHead)); set => WriteStructure(nameof(ApcListHead), value); }

        [Offset(32UL)]
        public IntPtr Process { get => ReadHere<IntPtr>(nameof(Process)); set => WriteHere(nameof(Process), value); }

        [Offset(40UL)]
        public byte InProgressFlags { get => ReadHere<byte>(nameof(InProgressFlags)); set => WriteHere(nameof(InProgressFlags), value); }

        [Offset(40UL)]
        public byte KernelApcInProgress { get => ReadHere<byte>(nameof(KernelApcInProgress)); set => WriteHere(nameof(KernelApcInProgress), value); }

        [Offset(40UL)]
        public byte SpecialApcInProgress { get => ReadHere<byte>(nameof(SpecialApcInProgress)); set => WriteHere(nameof(SpecialApcInProgress), value); }

        [Offset(41UL)]
        public byte KernelApcPending { get => ReadHere<byte>(nameof(KernelApcPending)); set => WriteHere(nameof(KernelApcPending), value); }

        [Offset(42UL)]
        public byte UserApcPendingAll { get => ReadHere<byte>(nameof(UserApcPendingAll)); set => WriteHere(nameof(UserApcPendingAll), value); }

        [Offset(42UL)]
        public byte SpecialUserApcPending { get => ReadHere<byte>(nameof(SpecialUserApcPending)); set => WriteHere(nameof(SpecialUserApcPending), value); }

        [Offset(42UL)]
        public byte UserApcPending { get => ReadHere<byte>(nameof(UserApcPending)); set => WriteHere(nameof(UserApcPending), value); }

        public KapcState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KapcState>();
        }
    }
}