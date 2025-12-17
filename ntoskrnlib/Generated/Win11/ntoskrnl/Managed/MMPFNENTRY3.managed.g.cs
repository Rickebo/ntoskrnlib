using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMPFNENTRY3")]
    public sealed class MMPFNENTRY3 : DynamicStructure
    {
        [Offset(0UL)]
        public byte Priority { get => ReadHere<byte>(nameof(Priority)); set => WriteHere(nameof(Priority), value); }

        [Offset(0UL)]
        public byte OnProtectedStandby { get => ReadHere<byte>(nameof(OnProtectedStandby)); set => WriteHere(nameof(OnProtectedStandby), value); }

        [Offset(0UL)]
        public byte InPageError { get => ReadHere<byte>(nameof(InPageError)); set => WriteHere(nameof(InPageError), value); }

        [Offset(0UL)]
        public byte SystemChargedPage { get => ReadHere<byte>(nameof(SystemChargedPage)); set => WriteHere(nameof(SystemChargedPage), value); }

        [Offset(0UL)]
        public byte RemovalRequested { get => ReadHere<byte>(nameof(RemovalRequested)); set => WriteHere(nameof(RemovalRequested), value); }

        [Offset(0UL)]
        public byte ParityError { get => ReadHere<byte>(nameof(ParityError)); set => WriteHere(nameof(ParityError), value); }

        public MMPFNENTRY3(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MMPFNENTRY3>();
        }
    }
}