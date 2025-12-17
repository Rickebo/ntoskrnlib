using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OBJECT_REF_TRACE")]
    public sealed class ObjectRefTrace : DynamicStructure
    {
        [Offset(0UL)]
        [Length(16)]
        public DynamicArray StackTrace { get => ReadStructure<DynamicArray>(nameof(StackTrace)); set => WriteStructure(nameof(StackTrace), value); }

        public ObjectRefTrace(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObjectRefTrace>();
        }
    }
}