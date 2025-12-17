using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTL_CALLER_ALLOCATED_ACTIVATION_CONTEXT_STACK_FRAME_EXTENDED")]
    public sealed class RtlCallerAllocatedActivationContextStackFrameExtended : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Size { get => ReadHere<ulong>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(8UL)]
        public uint Format { get => ReadHere<uint>(nameof(Format)); set => WriteHere(nameof(Format), value); }

        [Offset(16UL)]
        public RtlActivationContextStackFrame Frame { get => ReadStructure<RtlActivationContextStackFrame>(nameof(Frame)); set => WriteStructure(nameof(Frame), value); }

        [Offset(40UL)]
        public IntPtr Extra1 { get => ReadHere<IntPtr>(nameof(Extra1)); set => WriteHere(nameof(Extra1), value); }

        [Offset(48UL)]
        public IntPtr Extra2 { get => ReadHere<IntPtr>(nameof(Extra2)); set => WriteHere(nameof(Extra2), value); }

        [Offset(56UL)]
        public IntPtr Extra3 { get => ReadHere<IntPtr>(nameof(Extra3)); set => WriteHere(nameof(Extra3), value); }

        [Offset(64UL)]
        public IntPtr Extra4 { get => ReadHere<IntPtr>(nameof(Extra4)); set => WriteHere(nameof(Extra4), value); }

        public RtlCallerAllocatedActivationContextStackFrameExtended(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlCallerAllocatedActivationContextStackFrameExtended>();
        }
    }
}