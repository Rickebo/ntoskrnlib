using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_NOTIFY_BLOCK")]
    public sealed class CmNotifyBlock : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry HiveList { get => ReadStructure<ListEntry>(nameof(HiveList)); set => WriteStructure(nameof(HiveList), value); }

        [Offset(16UL)]
        public ListEntry PostList { get => ReadStructure<ListEntry>(nameof(PostList)); set => WriteStructure(nameof(PostList), value); }

        [Offset(32UL)]
        public IntPtr KeyControlBlock { get => ReadHere<IntPtr>(nameof(KeyControlBlock)); set => WriteHere(nameof(KeyControlBlock), value); }

        [Offset(40UL)]
        public IntPtr KeyBody { get => ReadHere<IntPtr>(nameof(KeyBody)); set => WriteHere(nameof(KeyBody), value); }

        [Offset(48UL)]
        public uint Filter { get => ReadHere<uint>(nameof(Filter)); set => WriteHere(nameof(Filter), value); }

        [Offset(48UL)]
        public uint WatchTree { get => ReadHere<uint>(nameof(WatchTree)); set => WriteHere(nameof(WatchTree), value); }

        [Offset(48UL)]
        public uint NotifyPending { get => ReadHere<uint>(nameof(NotifyPending)); set => WriteHere(nameof(NotifyPending), value); }

        [Offset(56UL)]
        public SecuritySubjectContext SubjectContext { get => ReadStructure<SecuritySubjectContext>(nameof(SubjectContext)); set => WriteStructure(nameof(SubjectContext), value); }

        public CmNotifyBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmNotifyBlock>();
        }
    }
}