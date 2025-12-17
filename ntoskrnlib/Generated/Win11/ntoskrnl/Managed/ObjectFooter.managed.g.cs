using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OBJECT_FOOTER")]
    public sealed class ObjectFooter : DynamicStructure
    {
        [Offset(0UL)]
        public HandleRevocationInfo HandleRevocationInfo { get => ReadStructure<HandleRevocationInfo>(nameof(HandleRevocationInfo)); set => WriteStructure(nameof(HandleRevocationInfo), value); }

        [Offset(32UL)]
        public ObExtendedUserInfo ExtendedUserInfo { get => ReadStructure<ObExtendedUserInfo>(nameof(ExtendedUserInfo)); set => WriteStructure(nameof(ExtendedUserInfo), value); }

        public ObjectFooter(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObjectFooter>();
        }
    }
}