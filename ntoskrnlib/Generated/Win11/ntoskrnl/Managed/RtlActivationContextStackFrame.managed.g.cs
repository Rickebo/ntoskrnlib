using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_ACTIVATION_CONTEXT_STACK_FRAME")]
    public sealed class RtlActivationContextStackFrame : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Previous { get => ReadHere<IntPtr>(nameof(Previous)); set => WriteHere(nameof(Previous), value); }

        [Offset(8UL)]
        public IntPtr ActivationContext { get => ReadHere<IntPtr>(nameof(ActivationContext)); set => WriteHere(nameof(ActivationContext), value); }

        [Offset(16UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        public RtlActivationContextStackFrame(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlActivationContextStackFrame>();
        }
    }
}