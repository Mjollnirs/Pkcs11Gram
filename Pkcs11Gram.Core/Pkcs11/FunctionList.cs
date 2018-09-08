// Project: Pkcs11Gram.Core
// File: FunctionList.cs
// 
// Copyright 2018 Mjollnir<mjollnir@59k.org>
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

/*
 *  Written for the Pkcs11Interop project by:
 *  Jaroslav IMRICH <jimrich@jimrich.sk>
 */
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Pkcs11Gram.Core.Pkcs11
{
    /// <summary>
    /// CK_FUNCTION_LIST
    /// Structure which contains a Cryptoki version and a function pointer to each function in the Cryptoki API
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
    public struct FunctionList
    {
        /// <summary>
        /// Cryptoki version
        /// </summary>
        public Pkcs11Version version;

        /// <summary>
        /// Pointer to C_Initialize
        /// </summary>
        public IntPtr C_Initialize;

        /// <summary>
        /// Pointer to C_Finalize
        /// </summary>
        public IntPtr C_Finalize;

        /// <summary>
        /// Pointer to C_GetInfo
        /// </summary>
        public IntPtr C_GetInfo;

        /// <summary>
        /// Pointer to C_GetFunctionList
        /// </summary>
        public IntPtr C_GetFunctionList;

        /// <summary>
        /// Pointer to C_GetSlotList
        /// </summary>
        public IntPtr C_GetSlotList;

        /// <summary>
        /// Pointer to C_GetSlotInfo
        /// </summary>
        public IntPtr C_GetSlotInfo;

        /// <summary>
        /// Pointer to C_GetTokenInfo
        /// </summary>
        public IntPtr C_GetTokenInfo;

        /// <summary>
        /// Pointer to C_GetMechanismList
        /// </summary>
        public IntPtr C_GetMechanismList;

        /// <summary>
        /// Pointer to C_GetMechanismInfo
        /// </summary>
        public IntPtr C_GetMechanismInfo;

        /// <summary>
        /// Pointer to C_InitToken
        /// </summary>
        public IntPtr C_InitToken;

        /// <summary>
        /// Pointer to C_InitPIN
        /// </summary>
        public IntPtr C_InitPIN;

        /// <summary>
        /// Pointer to C_SetPIN
        /// </summary>
        public IntPtr C_SetPIN;

        /// <summary>
        /// Pointer to C_OpenSession
        /// </summary>
        public IntPtr C_OpenSession;

        /// <summary>
        /// Pointer to C_CloseSession
        /// </summary>
        public IntPtr C_CloseSession;

        /// <summary>
        /// Pointer to C_CloseAllSessions
        /// </summary>
        public IntPtr C_CloseAllSessions;

        /// <summary>
        /// Pointer to C_GetSessionInfo
        /// </summary>
        public IntPtr C_GetSessionInfo;

        /// <summary>
        /// Pointer to C_GetOperationState
        /// </summary>
        public IntPtr C_GetOperationState;

        /// <summary>
        /// Pointer to C_SetOperationState
        /// </summary>
        public IntPtr C_SetOperationState;

        /// <summary>
        /// Pointer to C_Login
        /// </summary>
        public IntPtr C_Login;

        /// <summary>
        /// Pointer to C_Logout
        /// </summary>
        public IntPtr C_Logout;

        /// <summary>
        /// Pointer to C_CreateObject
        /// </summary>
        public IntPtr C_CreateObject;

        /// <summary>
        /// Pointer to C_CopyObject
        /// </summary>
        public IntPtr C_CopyObject;

        /// <summary>
        /// Pointer to C_DestroyObject
        /// </summary>
        public IntPtr C_DestroyObject;

        /// <summary>
        /// Pointer to C_GetObjectSize
        /// </summary>
        public IntPtr C_GetObjectSize;

        /// <summary>
        /// Pointer to C_GetAttributeValue
        /// </summary>
        public IntPtr C_GetAttributeValue;

        /// <summary>
        /// Pointer to C_SetAttributeValue
        /// </summary>
        public IntPtr C_SetAttributeValue;

        /// <summary>
        /// Pointer to C_FindObjectsInit
        /// </summary>
        public IntPtr C_FindObjectsInit;

        /// <summary>
        /// Pointer to C_FindObjects
        /// </summary>
        public IntPtr C_FindObjects;

        /// <summary>
        /// Pointer to C_FindObjectsFinal
        /// </summary>
        public IntPtr C_FindObjectsFinal;

        /// <summary>
        /// Pointer to C_EncryptInit
        /// </summary>
        public IntPtr C_EncryptInit;

        /// <summary>
        /// Pointer to C_Encrypt
        /// </summary>
        public IntPtr C_Encrypt;

        /// <summary>
        /// Pointer to C_EncryptUpdate
        /// </summary>
        public IntPtr C_EncryptUpdate;

        /// <summary>
        /// Pointer to C_EncryptFinal
        /// </summary>
        public IntPtr C_EncryptFinal;

        /// <summary>
        /// Pointer to C_DecryptInit
        /// </summary>
        public IntPtr C_DecryptInit;

        /// <summary>
        /// Pointer to C_Decrypt
        /// </summary>
        public IntPtr C_Decrypt;

        /// <summary>
        /// Pointer to C_DecryptUpdate
        /// </summary>
        public IntPtr C_DecryptUpdate;

        /// <summary>
        /// Pointer to C_DecryptFinal
        /// </summary>
        public IntPtr C_DecryptFinal;

        /// <summary>
        /// Pointer to C_DigestInit
        /// </summary>
        public IntPtr C_DigestInit;

        /// <summary>
        /// Pointer to C_Digest
        /// </summary>
        public IntPtr C_Digest;

        /// <summary>
        /// Pointer to C_DigestUpdate
        /// </summary>
        public IntPtr C_DigestUpdate;

        /// <summary>
        /// Pointer to C_DigestKey
        /// </summary>
        public IntPtr C_DigestKey;

        /// <summary>
        /// Pointer to C_DigestFinal
        /// </summary>
        public IntPtr C_DigestFinal;

        /// <summary>
        /// Pointer to C_SignInit
        /// </summary>
        public IntPtr C_SignInit;

        /// <summary>
        /// Pointer to C_Sign
        /// </summary>
        public IntPtr C_Sign;

        /// <summary>
        /// Pointer to C_SignUpdate
        /// </summary>
        public IntPtr C_SignUpdate;

        /// <summary>
        /// Pointer to C_SignFinal
        /// </summary>
        public IntPtr C_SignFinal;

        /// <summary>
        /// Pointer to C_SignRecoverInit
        /// </summary>
        public IntPtr C_SignRecoverInit;

        /// <summary>
        /// Pointer to C_SignRecover
        /// </summary>
        public IntPtr C_SignRecover;

        /// <summary>
        /// Pointer to C_VerifyInit
        /// </summary>
        public IntPtr C_VerifyInit;

        /// <summary>
        /// Pointer to C_Verify
        /// </summary>
        public IntPtr C_Verify;

        /// <summary>
        /// Pointer to C_VerifyUpdate
        /// </summary>
        public IntPtr C_VerifyUpdate;

        /// <summary>
        /// Pointer to C_VerifyFinal
        /// </summary>
        public IntPtr C_VerifyFinal;

        /// <summary>
        /// Pointer to C_VerifyRecoverInit
        /// </summary>
        public IntPtr C_VerifyRecoverInit;

        /// <summary>
        /// Pointer to C_VerifyRecover
        /// </summary>
        public IntPtr C_VerifyRecover;

        /// <summary>
        /// Pointer to C_DigestEncryptUpdate
        /// </summary>
        public IntPtr C_DigestEncryptUpdate;

        /// <summary>
        /// Pointer to C_DecryptDigestUpdate
        /// </summary>
        public IntPtr C_DecryptDigestUpdate;

        /// <summary>
        /// Pointer to C_SignEncryptUpdate
        /// </summary>
        public IntPtr C_SignEncryptUpdate;

        /// <summary>
        /// Pointer to C_DecryptVerifyUpdate
        /// </summary>
        public IntPtr C_DecryptVerifyUpdate;

        /// <summary>
        /// Pointer to C_GenerateKey
        /// </summary>
        public IntPtr C_GenerateKey;

        /// <summary>
        /// Pointer to C_GenerateKeyPair
        /// </summary>
        public IntPtr C_GenerateKeyPair;

        /// <summary>
        /// Pointer to C_WrapKey
        /// </summary>
        public IntPtr C_WrapKey;

        /// <summary>
        /// Pointer to C_UnwrapKey
        /// </summary>
        public IntPtr C_UnwrapKey;

        /// <summary>
        /// Pointer to C_DeriveKey
        /// </summary>
        public IntPtr C_DeriveKey;

        /// <summary>
        /// Pointer to C_SeedRandom
        /// </summary>
        public IntPtr C_SeedRandom;

        /// <summary>
        /// Pointer to C_GenerateRandom
        /// </summary>
        public IntPtr C_GenerateRandom;

        /// <summary>
        /// Pointer to C_GetFunctionStatus
        /// </summary>
        public IntPtr C_GetFunctionStatus;

        /// <summary>
        /// Pointer to C_CancelFunction
        /// </summary>
        public IntPtr C_CancelFunction;

        /// <summary>
        /// Pointer to C_WaitForSlotEvent
        /// </summary>
        public IntPtr C_WaitForSlotEvent;
    }
}
