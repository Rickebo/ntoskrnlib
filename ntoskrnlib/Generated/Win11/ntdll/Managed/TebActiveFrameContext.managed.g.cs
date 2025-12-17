using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TEB_ACTIVE_FRAME_CONTEXT")]
    public sealed class TebActiveFrameContext : DynamicStructure
    {
        [Offset(0UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(8UL)]
        public IntPtr FrameName { get => ReadHere<IntPtr>(nameof(FrameName)); set => WriteHere(nameof(FrameName), value); }

        public TebActiveFrameContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TebActiveFrameContext>();
        }
    }
}