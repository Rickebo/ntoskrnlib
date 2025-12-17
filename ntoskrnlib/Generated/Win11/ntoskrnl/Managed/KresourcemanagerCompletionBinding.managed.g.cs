using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KRESOURCEMANAGER_COMPLETION_BINDING")]
    public sealed class KresourcemanagerCompletionBinding : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry NotificationListHead { get => ReadStructure<ListEntry>(nameof(NotificationListHead)); set => WriteStructure(nameof(NotificationListHead), value); }

        [Offset(16UL)]
        public IntPtr Port { get => ReadHere<IntPtr>(nameof(Port)); set => WriteHere(nameof(Port), value); }

        [Offset(24UL)]
        public ulong Key { get => ReadHere<ulong>(nameof(Key)); set => WriteHere(nameof(Key), value); }

        [Offset(32UL)]
        public IntPtr BindingProcess { get => ReadHere<IntPtr>(nameof(BindingProcess)); set => WriteHere(nameof(BindingProcess), value); }

        public KresourcemanagerCompletionBinding(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KresourcemanagerCompletionBinding>();
        }
    }
}