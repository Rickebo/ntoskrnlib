using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_INBV_DISPLAY_CONTEXT")]
    public sealed class InbvDisplayContext : DynamicStructure
    {
        [Offset(0UL)]
        public byte FrameBufferValid { get => ReadHere<byte>(nameof(FrameBufferValid)); set => WriteHere(nameof(FrameBufferValid), value); }

        [Offset(1UL)]
        public byte FrameBufferMapped { get => ReadHere<byte>(nameof(FrameBufferMapped)); set => WriteHere(nameof(FrameBufferMapped), value); }

        [Offset(2UL)]
        public byte DisplayRotation { get => ReadHere<byte>(nameof(DisplayRotation)); set => WriteHere(nameof(DisplayRotation), value); }

        [Offset(4UL)]
        public InbvModeInformation ModeInformation { get => ReadStructure<InbvModeInformation>(nameof(ModeInformation)); set => WriteStructure(nameof(ModeInformation), value); }

        [Offset(24UL)]
        public IntPtr ShadowBuffer { get => ReadHere<IntPtr>(nameof(ShadowBuffer)); set => WriteHere(nameof(ShadowBuffer), value); }

        [Offset(32UL)]
        public UnnamedTag VideoMemory { get => ReadStructure<UnnamedTag>(nameof(VideoMemory)); set => WriteStructure(nameof(VideoMemory), value); }

        public InbvDisplayContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<InbvDisplayContext>();
        }
    }
}