using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OBJECT_REF_INFO")]
    public sealed class ObjectRefInfo : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ObjectHeader { get => ReadHere<IntPtr>(nameof(ObjectHeader)); set => WriteHere(nameof(ObjectHeader), value); }

        [Offset(8UL)]
        public IntPtr NextRef { get => ReadHere<IntPtr>(nameof(NextRef)); set => WriteHere(nameof(NextRef), value); }

        [Offset(16UL)]
        [Length(16)]
        public DynamicArray ImageFileName { get => ReadStructure<DynamicArray>(nameof(ImageFileName)); set => WriteStructure(nameof(ImageFileName), value); }

        [Offset(32UL)]
        public ushort NextPos { get => ReadHere<ushort>(nameof(NextPos)); set => WriteHere(nameof(NextPos), value); }

        [Offset(34UL)]
        public ushort MaxStacks { get => ReadHere<ushort>(nameof(MaxStacks)); set => WriteHere(nameof(MaxStacks), value); }

        [Offset(36UL)]
        [Length(0)]
        public DynamicArray StackInfo { get => ReadStructure<DynamicArray>(nameof(StackInfo)); set => WriteStructure(nameof(StackInfo), value); }

        public ObjectRefInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObjectRefInfo>();
        }
    }
}