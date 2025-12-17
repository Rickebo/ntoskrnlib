using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ACTIVATION_CONTEXT_STACK")]
    public sealed class ActivationContextStack : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ActiveFrame { get => ReadHere<IntPtr>(nameof(ActiveFrame)); set => WriteHere(nameof(ActiveFrame), value); }

        [Offset(8UL)]
        public ListEntry FrameListCache { get => ReadStructure<ListEntry>(nameof(FrameListCache)); set => WriteStructure(nameof(FrameListCache), value); }

        [Offset(24UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(28UL)]
        public uint NextCookieSequenceNumber { get => ReadHere<uint>(nameof(NextCookieSequenceNumber)); set => WriteHere(nameof(NextCookieSequenceNumber), value); }

        [Offset(32UL)]
        public uint StackId { get => ReadHere<uint>(nameof(StackId)); set => WriteHere(nameof(StackId), value); }

        public ActivationContextStack(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ActivationContextStack>();
        }
    }
}