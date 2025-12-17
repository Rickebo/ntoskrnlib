using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OB_DUPLICATE_OBJECT_STATE")]
    public sealed class ObDuplicateObjectState : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr SourceProcess { get => ReadHere<IntPtr>(nameof(SourceProcess)); set => WriteHere(nameof(SourceProcess), value); }

        [Offset(8UL)]
        public IntPtr SourceHandle { get => ReadHere<IntPtr>(nameof(SourceHandle)); set => WriteHere(nameof(SourceHandle), value); }

        [Offset(16UL)]
        public IntPtr Object { get => ReadHere<IntPtr>(nameof(Object)); set => WriteHere(nameof(Object), value); }

        [Offset(24UL)]
        public uint TargetAccess { get => ReadHere<uint>(nameof(TargetAccess)); set => WriteHere(nameof(TargetAccess), value); }

        [Offset(28UL)]
        public HandleTableEntryInfo ObjectInfo { get => ReadStructure<HandleTableEntryInfo>(nameof(ObjectInfo)); set => WriteStructure(nameof(ObjectInfo), value); }

        [Offset(36UL)]
        public uint HandleAttributes { get => ReadHere<uint>(nameof(HandleAttributes)); set => WriteHere(nameof(HandleAttributes), value); }

        public ObDuplicateObjectState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObDuplicateObjectState>();
        }
    }
}