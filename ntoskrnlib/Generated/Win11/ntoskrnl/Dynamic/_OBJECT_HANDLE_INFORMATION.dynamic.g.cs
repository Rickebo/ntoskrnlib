using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OBJECT_HANDLE_INFORMATION")]
    public sealed class _OBJECT_HANDLE_INFORMATION : DynamicStructure
    {
        public uint HandleAttributes { get; }
        public uint GrantedAccess { get; }

        public _OBJECT_HANDLE_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBJECT_HANDLE_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBJECT_HANDLE_INFORMATION.HandleAttributes),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OBJECT_HANDLE_INFORMATION.GrantedAccess),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_OBJECT_HANDLE_INFORMATION>((mem, ptr) => new _OBJECT_HANDLE_INFORMATION(mem, ptr), offsets);
        }
    }
}