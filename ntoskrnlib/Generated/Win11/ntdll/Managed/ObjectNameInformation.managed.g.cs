using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_OBJECT_NAME_INFORMATION")]
    public sealed class ObjectNameInformation : DynamicStructure
    {
        [Offset(0UL)]
        public UnicodeString Name { get => ReadStructure<UnicodeString>(nameof(Name)); set => WriteStructure(nameof(Name), value); }

        public ObjectNameInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObjectNameInformation>();
        }
    }
}