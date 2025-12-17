using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_XSTATE_SAVE")]
    public sealed class XstateSave : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Prev { get => ReadHere<IntPtr>(nameof(Prev)); set => WriteHere(nameof(Prev), value); }

        [Offset(8UL)]
        public IntPtr Thread { get => ReadHere<IntPtr>(nameof(Thread)); set => WriteHere(nameof(Thread), value); }

        [Offset(16UL)]
        public byte Level { get => ReadHere<byte>(nameof(Level)); set => WriteHere(nameof(Level), value); }

        [Offset(24UL)]
        public XstateContext XStateContext { get => ReadStructure<XstateContext>(nameof(XStateContext)); set => WriteStructure(nameof(XStateContext), value); }

        public XstateSave(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<XstateSave>();
        }
    }
}