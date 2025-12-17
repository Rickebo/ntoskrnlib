using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTL_AVL_TABLE")]
    public sealed class RtlAvlTable : DynamicStructure
    {
        [Offset(0UL)]
        public RtlBalancedLinks BalancedRoot { get => ReadStructure<RtlBalancedLinks>(nameof(BalancedRoot)); set => WriteStructure(nameof(BalancedRoot), value); }

        [Offset(32UL)]
        public IntPtr OrderedPointer { get => ReadHere<IntPtr>(nameof(OrderedPointer)); set => WriteHere(nameof(OrderedPointer), value); }

        [Offset(40UL)]
        public uint WhichOrderedElement { get => ReadHere<uint>(nameof(WhichOrderedElement)); set => WriteHere(nameof(WhichOrderedElement), value); }

        [Offset(44UL)]
        public uint NumberGenericTableElements { get => ReadHere<uint>(nameof(NumberGenericTableElements)); set => WriteHere(nameof(NumberGenericTableElements), value); }

        [Offset(48UL)]
        public uint DepthOfTree { get => ReadHere<uint>(nameof(DepthOfTree)); set => WriteHere(nameof(DepthOfTree), value); }

        [Offset(56UL)]
        public IntPtr RestartKey { get => ReadHere<IntPtr>(nameof(RestartKey)); set => WriteHere(nameof(RestartKey), value); }

        [Offset(64UL)]
        public uint DeleteCount { get => ReadHere<uint>(nameof(DeleteCount)); set => WriteHere(nameof(DeleteCount), value); }

        [Offset(72UL)]
        public IntPtr CompareRoutine { get => ReadHere<IntPtr>(nameof(CompareRoutine)); set => WriteHere(nameof(CompareRoutine), value); }

        [Offset(80UL)]
        public IntPtr AllocateRoutine { get => ReadHere<IntPtr>(nameof(AllocateRoutine)); set => WriteHere(nameof(AllocateRoutine), value); }

        [Offset(88UL)]
        public IntPtr FreeRoutine { get => ReadHere<IntPtr>(nameof(FreeRoutine)); set => WriteHere(nameof(FreeRoutine), value); }

        [Offset(96UL)]
        public IntPtr TableContext { get => ReadHere<IntPtr>(nameof(TableContext)); set => WriteHere(nameof(TableContext), value); }

        public RtlAvlTable(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlAvlTable>();
        }
    }
}