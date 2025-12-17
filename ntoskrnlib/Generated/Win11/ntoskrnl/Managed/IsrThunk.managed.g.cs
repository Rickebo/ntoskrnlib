using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ISR_THUNK")]
    public sealed class IsrThunk : DynamicStructure
    {
        [Offset(0UL)]
        public byte PushImm { get => ReadHere<byte>(nameof(PushImm)); set => WriteHere(nameof(PushImm), value); }

        [Offset(1UL)]
        public byte Vector { get => ReadHere<byte>(nameof(Vector)); set => WriteHere(nameof(Vector), value); }

        [Offset(2UL)]
        public byte PushRbp { get => ReadHere<byte>(nameof(PushRbp)); set => WriteHere(nameof(PushRbp), value); }

        [Offset(3UL)]
        public byte JmpOp { get => ReadHere<byte>(nameof(JmpOp)); set => WriteHere(nameof(JmpOp), value); }

        [Offset(4UL)]
        public int JmpOffset { get => ReadHere<int>(nameof(JmpOffset)); set => WriteHere(nameof(JmpOffset), value); }

        public IsrThunk(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IsrThunk>();
        }
    }
}