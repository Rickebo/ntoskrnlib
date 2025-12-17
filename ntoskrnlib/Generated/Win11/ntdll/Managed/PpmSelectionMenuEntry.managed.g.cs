using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PPM_SELECTION_MENU_ENTRY")]
    public sealed class PpmSelectionMenuEntry : DynamicStructure
    {
        [Offset(0UL)]
        public byte StrictDependency { get => ReadHere<byte>(nameof(StrictDependency)); set => WriteHere(nameof(StrictDependency), value); }

        [Offset(1UL)]
        public byte InitiatingState { get => ReadHere<byte>(nameof(InitiatingState)); set => WriteHere(nameof(InitiatingState), value); }

        [Offset(2UL)]
        public byte DependentState { get => ReadHere<byte>(nameof(DependentState)); set => WriteHere(nameof(DependentState), value); }

        [Offset(4UL)]
        public uint StateIndex { get => ReadHere<uint>(nameof(StateIndex)); set => WriteHere(nameof(StateIndex), value); }

        [Offset(8UL)]
        public uint Dependencies { get => ReadHere<uint>(nameof(Dependencies)); set => WriteHere(nameof(Dependencies), value); }

        [Offset(16UL)]
        public IntPtr DependencyList { get => ReadHere<IntPtr>(nameof(DependencyList)); set => WriteHere(nameof(DependencyList), value); }

        public PpmSelectionMenuEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PpmSelectionMenuEntry>();
        }
    }
}