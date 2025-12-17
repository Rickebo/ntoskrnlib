using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TPP_CLEANUP_GROUP_MEMBER_VFUNCS")]
    public sealed class _TPP_CLEANUP_GROUP_MEMBER_VFUNCS : DynamicStructure
    {
        public IntPtr Free { get; }
        public IntPtr CallbackEpilog { get; }
        public IntPtr StopCallbackGeneration { get; }
        public IntPtr CancelPendingCallbacks { get; }

        public _TPP_CLEANUP_GROUP_MEMBER_VFUNCS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TPP_CLEANUP_GROUP_MEMBER_VFUNCS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER_VFUNCS.Free),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER_VFUNCS.CallbackEpilog),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER_VFUNCS.StopCallbackGeneration),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER_VFUNCS.CancelPendingCallbacks),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_TPP_CLEANUP_GROUP_MEMBER_VFUNCS>((mem, ptr) => new _TPP_CLEANUP_GROUP_MEMBER_VFUNCS(mem, ptr), offsets);
        }
    }
}