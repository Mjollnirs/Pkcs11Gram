// Project: Pkcs11Gram.Engine
// File: loader.h
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
#pragma once

typedef CK_RV(STDMETHODCALLTYPE EngineInitialize)(CK_VOID_PTR pInitArgs);
typedef CK_RV(STDMETHODCALLTYPE EngineFinalize)(CK_VOID_PTR pReserved);
typedef CK_RV(STDMETHODCALLTYPE EngineGetInfo)(CK_INFO_PTR pInfo);
typedef CK_RV(STDMETHODCALLTYPE EngineGetFunctionList)(CK_FUNCTION_LIST_PTR ppFunctionList);
typedef CK_RV(STDMETHODCALLTYPE EngineGetSlotList)(CK_BBOOL tokenPresent, CK_SLOT_ID_PTR pSlotList, CK_ULONG_PTR pulCount);
typedef CK_RV(STDMETHODCALLTYPE EngineGetSlotInfo)(CK_SLOT_ID slotID, CK_SLOT_INFO_PTR pInfo);
typedef CK_RV(STDMETHODCALLTYPE EngineGetTokenInfo)(CK_SLOT_ID slotID, CK_TOKEN_INFO_PTR pInfo);
typedef CK_RV(STDMETHODCALLTYPE EngineGetMechanismList)(CK_SLOT_ID slotID, CK_MECHANISM_TYPE_PTR pMechanismList, CK_ULONG_PTR pulCount);
typedef CK_RV(STDMETHODCALLTYPE EngineGetMechanismInfo)(CK_SLOT_ID slotID, CK_MECHANISM_TYPE type, CK_MECHANISM_INFO_PTR pInfo);
typedef CK_RV(STDMETHODCALLTYPE EngineInitToken)(CK_SLOT_ID slotID, CK_UTF8CHAR_PTR pPin, CK_ULONG ulPinLen, CK_UTF8CHAR_PTR pLabel);
typedef CK_RV(STDMETHODCALLTYPE EngineInitPIN)(CK_SESSION_HANDLE hSession, CK_UTF8CHAR_PTR pPin, CK_ULONG ulPinLen);
typedef CK_RV(STDMETHODCALLTYPE EngineSetPIN)(CK_SESSION_HANDLE hSession, CK_UTF8CHAR_PTR pOldPin, CK_ULONG ulOldLen, CK_UTF8CHAR_PTR pNewPin, CK_ULONG ulNewLen);
typedef CK_RV(STDMETHODCALLTYPE EngineOpenSession)(CK_SLOT_ID slotID, CK_FLAGS flags, CK_VOID_PTR pApplication, CK_NOTIFY Notify, CK_SESSION_HANDLE_PTR phSession);
typedef CK_RV(STDMETHODCALLTYPE EngineCloseSession)(CK_SESSION_HANDLE hSession);
typedef CK_RV(STDMETHODCALLTYPE EngineCloseAllSessions)(CK_SLOT_ID slotID);
typedef CK_RV(STDMETHODCALLTYPE EngineGetSessionInfo)(CK_SESSION_HANDLE hSession, CK_SESSION_INFO_PTR pInfo);
typedef CK_RV(STDMETHODCALLTYPE EngineGetOperationState)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pOperationState, CK_ULONG_PTR pulOperationStateLen);
typedef CK_RV(STDMETHODCALLTYPE EngineSetOperationState)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pOperationState, CK_ULONG ulOperationStateLen, CK_OBJECT_HANDLE hEncryptionKey, CK_OBJECT_HANDLE hAuthenticationKey);
typedef CK_RV(STDMETHODCALLTYPE EngineLogin)(CK_SESSION_HANDLE hSession, CK_USER_TYPE userType, CK_UTF8CHAR_PTR pPin, CK_ULONG ulPinLen);
typedef CK_RV(STDMETHODCALLTYPE EngineLogout)(CK_SESSION_HANDLE hSession);
typedef CK_RV(STDMETHODCALLTYPE EngineCreateObject)(CK_SESSION_HANDLE hSession, CK_ATTRIBUTE_PTR pTemplate, CK_ULONG ulCount, CK_OBJECT_HANDLE_PTR phObject);
typedef CK_RV(STDMETHODCALLTYPE EngineCopyObject)(CK_SESSION_HANDLE hSession, CK_OBJECT_HANDLE hObject, CK_ATTRIBUTE_PTR pTemplate, CK_ULONG ulCount, CK_OBJECT_HANDLE_PTR phNewObject);
typedef CK_RV(STDMETHODCALLTYPE EngineDestroyObject)(CK_SESSION_HANDLE hSession, CK_OBJECT_HANDLE hObject);
typedef CK_RV(STDMETHODCALLTYPE EngineGetObjectSize)(CK_SESSION_HANDLE hSession, CK_OBJECT_HANDLE hObject, CK_ULONG_PTR pulSize);
typedef CK_RV(STDMETHODCALLTYPE EngineGetAttributeValue)(CK_SESSION_HANDLE hSession, CK_OBJECT_HANDLE hObject, CK_ATTRIBUTE_PTR pTemplate, CK_ULONG ulCount);
typedef CK_RV(STDMETHODCALLTYPE EngineSetAttributeValue)(CK_SESSION_HANDLE hSession, CK_OBJECT_HANDLE hObject, CK_ATTRIBUTE_PTR pTemplate, CK_ULONG ulCount);
typedef CK_RV(STDMETHODCALLTYPE EngineFindObjectsInit)(CK_SESSION_HANDLE hSession, CK_ATTRIBUTE_PTR pTemplate, CK_ULONG ulCount);
typedef CK_RV(STDMETHODCALLTYPE EngineFindObjects)(CK_SESSION_HANDLE hSession, CK_OBJECT_HANDLE_PTR phObject, CK_ULONG ulMaxObjectCount, CK_ULONG_PTR pulObjectCount);
typedef CK_RV(STDMETHODCALLTYPE EngineFindObjectsFinal)(CK_SESSION_HANDLE hSession);
typedef CK_RV(STDMETHODCALLTYPE EngineEncryptInit)(CK_SESSION_HANDLE hSession, CK_MECHANISM_PTR pMechanism, CK_OBJECT_HANDLE hKey);
typedef CK_RV(STDMETHODCALLTYPE EngineEncrypt)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pData, CK_ULONG ulDataLen, CK_BYTE_PTR pEncryptedData, CK_ULONG_PTR pulEncryptedDataLen);
typedef CK_RV(STDMETHODCALLTYPE EngineEncryptUpdate)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pPart, CK_ULONG ulPartLen, CK_BYTE_PTR pEncryptedPart, CK_ULONG_PTR pulEncryptedPartLen);
typedef CK_RV(STDMETHODCALLTYPE EngineEncryptFinal)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pLastEncryptedPart, CK_ULONG_PTR pulLastEncryptedPartLen);
typedef CK_RV(STDMETHODCALLTYPE EngineDecryptInit)(CK_SESSION_HANDLE hSession, CK_MECHANISM_PTR pMechanism, CK_OBJECT_HANDLE hKey);
typedef CK_RV(STDMETHODCALLTYPE EngineDecrypt)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pEncryptedData, CK_ULONG ulEncryptedDataLen, CK_BYTE_PTR pData, CK_ULONG_PTR pulDataLen);
typedef CK_RV(STDMETHODCALLTYPE EngineDecryptUpdate)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pEncryptedPart, CK_ULONG ulEncryptedPartLen, CK_BYTE_PTR pPart, CK_ULONG_PTR pulPartLen);
typedef CK_RV(STDMETHODCALLTYPE EngineDecryptFinal)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pLastPart, CK_ULONG_PTR pulLastPartLen);
typedef CK_RV(STDMETHODCALLTYPE EngineDigestInit)(CK_SESSION_HANDLE hSession, CK_MECHANISM_PTR pMechanism);
typedef CK_RV(STDMETHODCALLTYPE EngineDigest)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pData, CK_ULONG ulDataLen, CK_BYTE_PTR pDigest, CK_ULONG_PTR pulDigestLen);
typedef CK_RV(STDMETHODCALLTYPE EngineDigestUpdate)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pPart, CK_ULONG ulPartLen);
typedef CK_RV(STDMETHODCALLTYPE EngineDigestKey)(CK_SESSION_HANDLE hSession, CK_OBJECT_HANDLE hKey);
typedef CK_RV(STDMETHODCALLTYPE EngineDigestFinal)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pDigest, CK_ULONG_PTR pulDigestLen);
typedef CK_RV(STDMETHODCALLTYPE EngineSignInit)(CK_SESSION_HANDLE hSession, CK_MECHANISM_PTR pMechanism, CK_OBJECT_HANDLE hKey);
typedef CK_RV(STDMETHODCALLTYPE EngineSign)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pData, CK_ULONG ulDataLen, CK_BYTE_PTR pSignature, CK_ULONG_PTR pulSignatureLen);
typedef CK_RV(STDMETHODCALLTYPE EngineSignUpdate)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pPart, CK_ULONG ulPartLen);
typedef CK_RV(STDMETHODCALLTYPE EngineSignFinal)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pSignature, CK_ULONG_PTR pulSignatureLen);
typedef CK_RV(STDMETHODCALLTYPE EngineSignRecoverInit)(CK_SESSION_HANDLE hSession, CK_MECHANISM_PTR pMechanism, CK_OBJECT_HANDLE hKey);
typedef CK_RV(STDMETHODCALLTYPE EngineSignRecover)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pData, CK_ULONG ulDataLen, CK_BYTE_PTR pSignature, CK_ULONG_PTR pulSignatureLen);
typedef CK_RV(STDMETHODCALLTYPE EngineVerifyInit)(CK_SESSION_HANDLE hSession, CK_MECHANISM_PTR pMechanism, CK_OBJECT_HANDLE hKey);
typedef CK_RV(STDMETHODCALLTYPE EngineVerify)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pData, CK_ULONG ulDataLen, CK_BYTE_PTR pSignature, CK_ULONG ulSignatureLen);
typedef CK_RV(STDMETHODCALLTYPE EngineVerifyUpdate)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pPart, CK_ULONG ulPartLen);
typedef CK_RV(STDMETHODCALLTYPE EngineVerifyFinal)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pSignature, CK_ULONG ulSignatureLen);
typedef CK_RV(STDMETHODCALLTYPE EngineVerifyRecoverInit)(CK_SESSION_HANDLE hSession, CK_MECHANISM_PTR pMechanism, CK_OBJECT_HANDLE hKey);
typedef CK_RV(STDMETHODCALLTYPE EngineVerifyRecover)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pSignature, CK_ULONG ulSignatureLen, CK_BYTE_PTR pData, CK_ULONG_PTR pulDataLen);
typedef CK_RV(STDMETHODCALLTYPE EngineDigestEncryptUpdate)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pPart, CK_ULONG ulPartLen, CK_BYTE_PTR pEncryptedPart, CK_ULONG_PTR pulEncryptedPartLen);
typedef CK_RV(STDMETHODCALLTYPE EngineDecryptDigestUpdate)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pEncryptedPart, CK_ULONG ulEncryptedPartLen, CK_BYTE_PTR pPart, CK_ULONG_PTR pulPartLen);
typedef CK_RV(STDMETHODCALLTYPE EngineSignEncryptUpdate)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pPart, CK_ULONG ulPartLen, CK_BYTE_PTR pEncryptedPart, CK_ULONG_PTR pulEncryptedPartLen);
typedef CK_RV(STDMETHODCALLTYPE EngineDecryptVerifyUpdate)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pEncryptedPart, CK_ULONG ulEncryptedPartLen, CK_BYTE_PTR pPart, CK_ULONG_PTR pulPartLen);
typedef CK_RV(STDMETHODCALLTYPE EngineGenerateKey)(CK_SESSION_HANDLE hSession, CK_MECHANISM_PTR pMechanism, CK_ATTRIBUTE_PTR pTemplate, CK_ULONG ulCount, CK_OBJECT_HANDLE_PTR phKey);
typedef CK_RV(STDMETHODCALLTYPE EngineGenerateKeyPair)(CK_SESSION_HANDLE hSession, CK_MECHANISM_PTR pMechanism, CK_ATTRIBUTE_PTR pPublicKeyTemplate, CK_ULONG ulPublicKeyAttributeCount, CK_ATTRIBUTE_PTR pPrivateKeyTemplate, CK_ULONG ulPrivateKeyAttributeCount, CK_OBJECT_HANDLE_PTR phPublicKey, CK_OBJECT_HANDLE_PTR phPrivateKey);
typedef CK_RV(STDMETHODCALLTYPE EngineWrapKey)(CK_SESSION_HANDLE hSession, CK_MECHANISM_PTR pMechanism, CK_OBJECT_HANDLE hWrappingKey, CK_OBJECT_HANDLE hKey, CK_BYTE_PTR pWrappedKey, CK_ULONG_PTR pulWrappedKeyLen);
typedef CK_RV(STDMETHODCALLTYPE EngineUnwrapKey)(CK_SESSION_HANDLE hSession, CK_MECHANISM_PTR pMechanism, CK_OBJECT_HANDLE hUnwrappingKey, CK_BYTE_PTR pWrappedKey, CK_ULONG ulWrappedKeyLen, CK_ATTRIBUTE_PTR pTemplate, CK_ULONG ulAttributeCount, CK_OBJECT_HANDLE_PTR phKey);
typedef CK_RV(STDMETHODCALLTYPE EngineDeriveKey)(CK_SESSION_HANDLE hSession, CK_MECHANISM_PTR pMechanism, CK_OBJECT_HANDLE hBaseKey, CK_ATTRIBUTE_PTR pTemplate, CK_ULONG ulAttributeCount, CK_OBJECT_HANDLE_PTR phKey);
typedef CK_RV(STDMETHODCALLTYPE EngineSeedRandom)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pSeed, CK_ULONG ulSeedLen);
typedef CK_RV(STDMETHODCALLTYPE EngineGenerateRandom)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR RandomData, CK_ULONG ulRandomLen);
typedef CK_RV(STDMETHODCALLTYPE EngineGetFunctionStatus)(CK_SESSION_HANDLE hSession);
typedef CK_RV(STDMETHODCALLTYPE EngineCancelFunction)(CK_SESSION_HANDLE hSession);
typedef CK_RV(STDMETHODCALLTYPE EngineWaitForSlotEvent)(CK_FLAGS flags, CK_SLOT_ID_PTR pSlot, CK_VOID_PTR pReserved);