using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_REMOVAL_REQUESTED_PAGE")]
    public sealed class MiRemovalRequestedPage : DynamicStructure
    {
        [Offset(0UL)]
        public RtlBalancedNode TreeNode { get => ReadStructure<RtlBalancedNode>(nameof(TreeNode)); set => WriteStructure(nameof(TreeNode), value); }

        [Offset(0UL)]
        public ListEntry Link { get => ReadStructure<ListEntry>(nameof(Link)); set => WriteStructure(nameof(Link), value); }

        [Offset(24UL)]
        public IntPtr Pfn { get => ReadHere<IntPtr>(nameof(Pfn)); set => WriteHere(nameof(Pfn), value); }

        public MiRemovalRequestedPage(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiRemovalRequestedPage>();
        }
    }
}