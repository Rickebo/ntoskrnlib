using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_ENCLAVE_STATE")]
    public sealed class _MI_ENCLAVE_STATE : DynamicStructure
    {
        public _RTL_AVL_TREE EnclaveRegions { get; }
        public IntPtr EnclaveMetadataPage { get; }
        public IntPtr EnclaveMetadataBitMap { get; }
        public _EX_PUSH_LOCK EnclaveMetadataEntryLock { get; }
        public int EnclaveMetadataPageLock { get; }
        public _LIST_ENTRY EnclaveList { get; }
        public _EX_PUSH_LOCK EnclaveListLock { get; }
        public _EX_RUNDOWN_REF ShutdownRundown { get; }

        public _MI_ENCLAVE_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_ENCLAVE_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_ENCLAVE_STATE.EnclaveRegions),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_ENCLAVE_STATE.EnclaveMetadataPage),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_ENCLAVE_STATE.EnclaveMetadataBitMap),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_ENCLAVE_STATE.EnclaveMetadataEntryLock),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_ENCLAVE_STATE.EnclaveMetadataPageLock),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_ENCLAVE_STATE.EnclaveList),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MI_ENCLAVE_STATE.EnclaveListLock),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MI_ENCLAVE_STATE.ShutdownRundown),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_MI_ENCLAVE_STATE>((mem, ptr) => new _MI_ENCLAVE_STATE(mem, ptr), offsets);
        }
    }
}