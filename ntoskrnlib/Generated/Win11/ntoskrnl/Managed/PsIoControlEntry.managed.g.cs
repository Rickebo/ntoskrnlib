using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PS_IO_CONTROL_ENTRY")]
    public sealed class PsIoControlEntry : DynamicStructure
    {
        [Offset(0UL)]
        public RtlBalancedNode VolumeTreeNode { get => ReadStructure<RtlBalancedNode>(nameof(VolumeTreeNode)); set => WriteStructure(nameof(VolumeTreeNode), value); }

        [Offset(0UL)]
        public ListEntry FreeListEntry { get => ReadStructure<ListEntry>(nameof(FreeListEntry)); set => WriteStructure(nameof(FreeListEntry), value); }

        [Offset(16UL)]
        public ulong ReservedForParentValue { get => ReadHere<ulong>(nameof(ReservedForParentValue)); set => WriteHere(nameof(ReservedForParentValue), value); }

        [Offset(24UL)]
        public ulong VolumeKey { get => ReadHere<ulong>(nameof(VolumeKey)); set => WriteHere(nameof(VolumeKey), value); }

        [Offset(32UL)]
        public ExRundownRef Rundown { get => ReadStructure<ExRundownRef>(nameof(Rundown)); set => WriteStructure(nameof(Rundown), value); }

        [Offset(40UL)]
        public IntPtr IoControl { get => ReadHere<IntPtr>(nameof(IoControl)); set => WriteHere(nameof(IoControl), value); }

        [Offset(48UL)]
        public IntPtr VolumeIoAttribution { get => ReadHere<IntPtr>(nameof(VolumeIoAttribution)); set => WriteHere(nameof(VolumeIoAttribution), value); }

        public PsIoControlEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PsIoControlEntry>();
        }
    }
}