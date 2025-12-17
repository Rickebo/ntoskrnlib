using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_LDR_DDAG_NODE")]
    public sealed class LdrDdagNode : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Modules { get => ReadStructure<ListEntry>(nameof(Modules)); set => WriteStructure(nameof(Modules), value); }

        [Offset(16UL)]
        public IntPtr ServiceTagList { get => ReadHere<IntPtr>(nameof(ServiceTagList)); set => WriteHere(nameof(ServiceTagList), value); }

        [Offset(24UL)]
        public uint LoadCount { get => ReadHere<uint>(nameof(LoadCount)); set => WriteHere(nameof(LoadCount), value); }

        [Offset(28UL)]
        public uint LoadWhileUnloadingCount { get => ReadHere<uint>(nameof(LoadWhileUnloadingCount)); set => WriteHere(nameof(LoadWhileUnloadingCount), value); }

        [Offset(32UL)]
        public uint LowestLink { get => ReadHere<uint>(nameof(LowestLink)); set => WriteHere(nameof(LowestLink), value); }

        [Offset(40UL)]
        public LdrpCslist Dependencies { get => ReadStructure<LdrpCslist>(nameof(Dependencies)); set => WriteStructure(nameof(Dependencies), value); }

        [Offset(48UL)]
        public LdrpCslist IncomingDependencies { get => ReadStructure<LdrpCslist>(nameof(IncomingDependencies)); set => WriteStructure(nameof(IncomingDependencies), value); }

        [Offset(56UL)]
        public uint State { get => ReadHere<uint>(nameof(State)); set => WriteHere(nameof(State), value); }

        [Offset(64UL)]
        public SingleListEntry CondenseLink { get => ReadStructure<SingleListEntry>(nameof(CondenseLink)); set => WriteStructure(nameof(CondenseLink), value); }

        [Offset(72UL)]
        public uint PreorderNumber { get => ReadHere<uint>(nameof(PreorderNumber)); set => WriteHere(nameof(PreorderNumber), value); }

        public LdrDdagNode(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LdrDdagNode>();
        }
    }
}