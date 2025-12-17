using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_ACTIVATION_CONTEXT_STACK64")]
    public sealed class ActivationContextSTACK64 : DynamicStructure
    {
        [Offset(0UL)]
        public ulong ActiveFrame { get => ReadHere<ulong>(nameof(ActiveFrame)); set => WriteHere(nameof(ActiveFrame), value); }

        [Offset(8UL)]
        public ListENTRY64 FrameListCache { get => ReadStructure<ListENTRY64>(nameof(FrameListCache)); set => WriteStructure(nameof(FrameListCache), value); }

        [Offset(24UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(28UL)]
        public uint NextCookieSequenceNumber { get => ReadHere<uint>(nameof(NextCookieSequenceNumber)); set => WriteHere(nameof(NextCookieSequenceNumber), value); }

        [Offset(32UL)]
        public uint StackId { get => ReadHere<uint>(nameof(StackId)); set => WriteHere(nameof(StackId), value); }

        public ActivationContextSTACK64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ActivationContextSTACK64>();
        }
    }
}