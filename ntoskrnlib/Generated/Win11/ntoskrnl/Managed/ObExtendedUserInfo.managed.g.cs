using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OB_EXTENDED_USER_INFO")]
    public sealed class ObExtendedUserInfo : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Context1 { get => ReadHere<IntPtr>(nameof(Context1)); set => WriteHere(nameof(Context1), value); }

        [Offset(8UL)]
        public IntPtr Context2 { get => ReadHere<IntPtr>(nameof(Context2)); set => WriteHere(nameof(Context2), value); }

        public ObExtendedUserInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObExtendedUserInfo>();
        }
    }
}