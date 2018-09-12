// Project: Pkcs11Gram.Core
// File: IEngine.cs
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
using System;
using Pkcs11Gram.Core.Pkcs11;

namespace Pkcs11Gram.Core.EntryPoint
{
    public interface IEngine
    {
        Rv C_CancelFunction(uint hSession);
        Rv C_CloseAllSessions(uint slotID);
        Rv C_CloseSession(uint hSession);
        Rv C_CopyObject(uint hSession, uint hObject, ref Core.Pkcs11.Attribute pTemplate, uint ulCount, ref uint phNewObject);
        Rv C_CreateObject(uint hSession, ref Core.Pkcs11.Attribute pTemplate, uint ulCount, ref uint phObject);
        Rv C_Decrypt(uint hSession, IntPtr pEncryptedData, uint ulEncryptedDataLen, IntPtr pData, ref uint pulDataLen);
        Rv C_DecryptDigestUpdate(uint hSession, IntPtr pEncryptedPart, uint ulEncryptedPartLen, IntPtr pPart, ref uint pulPartLen);
        Rv C_DecryptFinal(uint hSession, IntPtr pLastPart, ref uint pulLastPartLen);
        Rv C_DecryptInit(uint hSession, ref Mechanism pMechanism, uint hKey);
        Rv C_DecryptUpdate(uint hSession, IntPtr pEncryptedPart, uint ulEncryptedPartLen, IntPtr pPart, ref uint pulPartLen);
        Rv C_DecryptVerifyUpdate(uint hSession, IntPtr pEncryptedPart, uint ulEncryptedPartLen, IntPtr pPart, ref uint pulPartLen);
        Rv C_DeriveKey(uint hSession, ref Mechanism pMechanism, uint hBaseKey, ref Core.Pkcs11.Attribute pTemplate, uint ulAttributeCount, ref uint phKey);
        Rv C_DestroyObject(uint hSession, uint hObject);
        Rv C_Digest(uint hSession, IntPtr pData, uint ulDataLen, IntPtr pDigest, ref uint pulDigestLen);
        Rv C_DigestEncryptUpdate(uint hSession, IntPtr pPart, uint ulPartLen, IntPtr pEncryptedPart, ref uint pulEncryptedPartLen);
        Rv C_DigestFinal(uint hSession, IntPtr pDigest, ref uint pulDigestLen);
        Rv C_DigestInit(uint hSession, ref Mechanism pMechanism);
        Rv C_DigestKey(uint hSession, uint hKey);
        Rv C_DigestUpdate(uint hSession, IntPtr pPart, uint ulPartLen);
        Rv C_Encrypt(uint hSession, IntPtr pData, uint ulDataLen, IntPtr pEncryptedData, ref uint pulEncryptedDataLen);
        Rv C_EncryptFinal(uint hSession, IntPtr pLastEncryptedPart, ref uint pulLastEncryptedPartLen);
        Rv C_EncryptInit(uint hSession, ref Mechanism pMechanism, uint hKey);
        Rv C_EncryptUpdate(uint hSession, IntPtr pPart, uint ulPartLen, IntPtr pEncryptedPart, ref uint pulEncryptedPartLen);
        Rv C_Finalize(IntPtr pReserved);
        Rv C_FindObjects(uint hSession, ref uint phObject, uint ulMaxObjectCount, ref uint pulObjectCount);
        Rv C_FindObjectsFinal(uint hSession);
        Rv C_FindObjectsInit(uint hSession, ref Core.Pkcs11.Attribute pTemplate, uint ulCount);
        Rv C_GenerateKey(uint hSession, ref Mechanism pMechanism, ref Core.Pkcs11.Attribute pTemplate, uint ulCount, ref uint phKey);
        Rv C_GenerateKeyPair(uint hSession, ref Mechanism pMechanism, ref Core.Pkcs11.Attribute pPublicKeyTemplate, uint ulPublicKeyAttributeCount, ref Core.Pkcs11.Attribute pPrivateKeyTemplate, uint ulPrivateKeyAttributeCount, ref uint phPublicKey, ref uint phPrivateKey);
        Rv C_GenerateRandom(uint hSession, IntPtr RandomData, uint ulRandomLen);
        Rv C_GetAttributeValue(uint hSession, uint hObject, ref Core.Pkcs11.Attribute pTemplate, uint ulCount);
        Rv C_GetFunctionList(ref FunctionList functionList);
        Rv C_GetFunctionStatus(uint hSession);
        Rv C_GetInfo(ref Info pInfo);
        Rv C_GetMechanismInfo(uint slotID, MechanismType type, ref MechanismInfo pInfo);
        Rv C_GetMechanismList(uint slotID, ref MechanismType pMechanismList, ref uint pulCount);
        Rv C_GetObjectSize(uint hSession, uint hObject, ref uint pulSize);
        Rv C_GetOperationState(uint hSession, IntPtr pOperationState, ref uint pulOperationStateLen);
        Rv C_GetSessionInfo(uint hSession, ref SessionInfo pInfo);
        Rv C_GetSlotInfo(uint slotID, ref SlotInfo pInfo);
        Rv C_GetSlotList(byte tokenPresent, IntPtr pSlotList, IntPtr pulCount);
        Rv C_GetTokenInfo(uint slotID, ref TokenInfo pInfo);
        Rv C_Initialize(IntPtr pInitArgs);
        Rv C_InitPIN(uint hSession, IntPtr pPin, uint ulPinLen);
        Rv C_InitToken(uint slotID, IntPtr pPin, uint ulPinLen, IntPtr pLabel);
        Rv C_Login(uint hSession, UserType userType, IntPtr pPin, uint ulPinLen);
        Rv C_Logout(uint hSession);
        Rv C_OpenSession(uint slotID, SlotFlags flags, IntPtr pApplication, Notify Notify, IntPtr phSession);
        Rv C_SeedRandom(uint hSession, IntPtr pSeed, uint ulSeedLen);
        Rv C_SetAttributeValue(uint hSession, uint hObject, ref Core.Pkcs11.Attribute pTemplate, uint ulCount);
        Rv C_SetOperationState(uint hSession, IntPtr pOperationState, uint ulOperationStateLen, uint hEncryptionKey, uint hAuthenticationKey);
        Rv C_SetPIN(uint hSession, IntPtr pOldPin, uint ulOldLen, IntPtr pNewPin, uint ulNewLen);
        Rv C_Sign(uint hSession, IntPtr pData, uint ulDataLen, IntPtr pSignature, ref uint pulSignatureLen);
        Rv C_SignEncryptUpdate(uint hSession, IntPtr pPart, uint ulPartLen, IntPtr pEncryptedPart, ref uint pulEncryptedPartLen);
        Rv C_SignFinal(uint hSession, IntPtr pSignature, ref uint pulSignatureLen);
        Rv C_SignInit(uint hSession, ref Mechanism pMechanism, uint hKey);
        Rv C_SignRecover(uint hSession, IntPtr pData, uint ulDataLen, IntPtr pSignature, ref uint pulSignatureLen);
        Rv C_SignRecoverInit(uint hSession, ref Mechanism pMechanism, uint hKey);
        Rv C_SignUpdate(uint hSession, IntPtr pPart, uint ulPartLen);
        Rv C_UnwrapKey(uint hSession, ref Mechanism pMechanism, uint hUnwrappingKey, IntPtr pWrappedKey, uint ulWrappedKeyLen, ref Core.Pkcs11.Attribute pTemplate, uint ulAttributeCount, ref uint phKey);
        Rv C_Verify(uint hSession, IntPtr pData, uint ulDataLen, IntPtr pSignature, uint ulSignatureLen);
        Rv C_VerifyFinal(uint hSession, IntPtr pSignature, uint ulSignatureLen);
        Rv C_VerifyInit(uint hSession, ref Mechanism pMechanism, uint hKey);
        Rv C_VerifyRecover(uint hSession, IntPtr pSignature, uint ulSignatureLen, IntPtr pData, ref uint pulDataLen);
        Rv C_VerifyRecoverInit(uint hSession, ref Mechanism pMechanism, uint hKey);
        Rv C_VerifyUpdate(uint hSession, IntPtr pPart, uint ulPartLen);
        Rv C_WaitForSlotEvent(SlotFlags flags, ref uint pSlot, ref IntPtr pReserved);
        Rv C_WrapKey(uint hSession, ref Mechanism pMechanism, uint hWrappingKey, uint hKey, IntPtr pWrappedKey, ref uint pulWrappedKeyLen);
    }
}