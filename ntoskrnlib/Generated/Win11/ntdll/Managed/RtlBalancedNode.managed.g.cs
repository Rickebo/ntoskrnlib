using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTL_BALANCED_NODE")]
    public sealed class RtlBalancedNode : DynamicStructure
    {
        [Offset(0UL)]
        [Length(2)]
        public DynamicArray Children { get => ReadStructure<DynamicArray>(nameof(Children)); set => WriteStructure(nameof(Children), value); }

        [Offset(0UL)]
        public IntPtr Left { get => ReadHere<IntPtr>(nameof(Left)); set => WriteHere(nameof(Left), value); }

        [Offset(8UL)]
        public IntPtr Right { get => ReadHere<IntPtr>(nameof(Right)); set => WriteHere(nameof(Right), value); }

        [Offset(16UL)]
        public byte Red { get => ReadHere<byte>(nameof(Red)); set => WriteHere(nameof(Red), value); }

        [Offset(16UL)]
        public byte Balance { get => ReadHere<byte>(nameof(Balance)); set => WriteHere(nameof(Balance), value); }

        [Offset(16UL)]
        public ulong ParentValue { get => ReadHere<ulong>(nameof(ParentValue)); set => WriteHere(nameof(ParentValue), value); }

        public RtlBalancedNode(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlBalancedNode>();
        }
    }
}