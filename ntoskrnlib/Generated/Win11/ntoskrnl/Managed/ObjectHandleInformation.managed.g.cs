using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OBJECT_HANDLE_INFORMATION")]
    public sealed class ObjectHandleInformation : DynamicStructure
    {
        [Offset(0UL)]
        public uint HandleAttributes { get => ReadHere<uint>(nameof(HandleAttributes)); set => WriteHere(nameof(HandleAttributes), value); }

        [Offset(4UL)]
        public uint GrantedAccess { get => ReadHere<uint>(nameof(GrantedAccess)); set => WriteHere(nameof(GrantedAccess), value); }

        public ObjectHandleInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObjectHandleInformation>();
        }
    }
}