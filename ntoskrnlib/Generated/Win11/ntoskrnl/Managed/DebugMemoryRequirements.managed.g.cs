using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!DEBUG_MEMORY_REQUIREMENTS")]
    public sealed class DebugMemoryRequirements : DynamicStructure
    {
        [Offset(0UL)]
        public LargeInteger Start { get => ReadStructure<LargeInteger>(nameof(Start)); set => WriteStructure(nameof(Start), value); }

        [Offset(8UL)]
        public LargeInteger MaxEnd { get => ReadStructure<LargeInteger>(nameof(MaxEnd)); set => WriteStructure(nameof(MaxEnd), value); }

        [Offset(16UL)]
        public IntPtr VirtualAddress { get => ReadHere<IntPtr>(nameof(VirtualAddress)); set => WriteHere(nameof(VirtualAddress), value); }

        [Offset(24UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(28UL)]
        public byte Cached { get => ReadHere<byte>(nameof(Cached)); set => WriteHere(nameof(Cached), value); }

        [Offset(29UL)]
        public byte Aligned { get => ReadHere<byte>(nameof(Aligned)); set => WriteHere(nameof(Aligned), value); }

        public DebugMemoryRequirements(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DebugMemoryRequirements>();
        }
    }
}