using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_ACTION_TRIGGER")]
    public sealed class PopActionTrigger : DynamicStructure
    {
        [Offset(0UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(4UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(8UL)]
        public IntPtr Wait { get => ReadHere<IntPtr>(nameof(Wait)); set => WriteHere(nameof(Wait), value); }

        [Offset(16UL)]
        public IntPtr DiagnosticContext { get => ReadHere<IntPtr>(nameof(DiagnosticContext)); set => WriteHere(nameof(DiagnosticContext), value); }

        [Offset(24UL)]
        public UnnamedTag Battery { get => ReadStructure<UnnamedTag>(nameof(Battery)); set => WriteStructure(nameof(Battery), value); }

        [Offset(24UL)]
        public UnnamedTag Button { get => ReadStructure<UnnamedTag>(nameof(Button)); set => WriteStructure(nameof(Button), value); }

        public PopActionTrigger(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopActionTrigger>();
        }
    }
}