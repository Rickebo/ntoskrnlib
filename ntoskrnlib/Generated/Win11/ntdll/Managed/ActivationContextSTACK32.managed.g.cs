using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_ACTIVATION_CONTEXT_STACK32")]
    public sealed class ActivationContextSTACK32 : DynamicStructure
    {
        [Offset(0UL)]
        public uint ActiveFrame { get => ReadHere<uint>(nameof(ActiveFrame)); set => WriteHere(nameof(ActiveFrame), value); }

        [Offset(4UL)]
        public ListENTRY32 FrameListCache { get => ReadStructure<ListENTRY32>(nameof(FrameListCache)); set => WriteStructure(nameof(FrameListCache), value); }

        [Offset(12UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(16UL)]
        public uint NextCookieSequenceNumber { get => ReadHere<uint>(nameof(NextCookieSequenceNumber)); set => WriteHere(nameof(NextCookieSequenceNumber), value); }

        [Offset(20UL)]
        public uint StackId { get => ReadHere<uint>(nameof(StackId)); set => WriteHere(nameof(StackId), value); }

        public ActivationContextSTACK32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ActivationContextSTACK32>();
        }
    }
}