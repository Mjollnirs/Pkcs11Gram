// Project: Pkcs11Gram.Engine
// File: engine.cpp
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
#include "engine.h"

CLRRuntime* runtime;

CK_FUNCTION_LIST function_list =
{
    { 2, 40 },
    &C_Initialize,
    &C_Finalize,
    &C_GetInfo,
    &C_GetFunctionList,
    &C_GetSlotList,
    &C_GetSlotInfo,
    &C_GetTokenInfo,
    &C_GetMechanismList,
    &C_GetMechanismInfo,
    &C_InitToken,
    &C_InitPIN,
    &C_SetPIN,
    &C_OpenSession,
    &C_CloseSession,
    &C_CloseAllSessions,
    &C_GetSessionInfo,
    &C_GetOperationState,
    &C_SetOperationState,
    &C_Login,
    &C_Logout,
    &C_CreateObject,
    &C_CopyObject,
    &C_DestroyObject,
    &C_GetObjectSize,
    &C_GetAttributeValue,
    &C_SetAttributeValue,
    &C_FindObjectsInit,
    &C_FindObjects,
    &C_FindObjectsFinal,
    &C_EncryptInit,
    &C_Encrypt,
    &C_EncryptUpdate,
    &C_EncryptFinal,
    &C_DecryptInit,
    &C_Decrypt,
    &C_DecryptUpdate,
    &C_DecryptFinal,
    &C_DigestInit,
    &C_Digest,
    &C_DigestUpdate,
    &C_DigestKey,
    &C_DigestFinal,
    &C_SignInit,
    &C_Sign,
    &C_SignUpdate,
    &C_SignFinal,
    &C_SignRecoverInit,
    &C_SignRecover,
    &C_VerifyInit,
    &C_Verify,
    &C_VerifyUpdate,
    &C_VerifyFinal,
    &C_VerifyRecoverInit,
    &C_VerifyRecover,
    &C_DigestEncryptUpdate,
    &C_DecryptDigestUpdate,
    &C_SignEncryptUpdate,
    &C_DecryptVerifyUpdate,
    &C_GenerateKey,
    &C_GenerateKeyPair,
    &C_WrapKey,
    &C_UnwrapKey,
    &C_DeriveKey,
    &C_SeedRandom,
    &C_GenerateRandom,
    &C_GetFunctionStatus,
    &C_CancelFunction,
    &C_WaitForSlotEvent,
};

void CheckRuntime()
{
    if (runtime == NULL)
    {
        runtime = new CLRRuntime();
    }
}

CK_DEFINE_FUNCTION(CK_RV, C_Initialize)(CK_VOID_PTR pInitArgs)
{
    CheckRuntime();
    EngineInitialize *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_Initialize",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(pInitArgs);
}

CK_DEFINE_FUNCTION(CK_RV, C_Finalize)(CK_VOID_PTR pReserved)
{
    CheckRuntime();
    EngineFinalize *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_Finalize",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(pReserved);
}

CK_DEFINE_FUNCTION(CK_RV, C_GetInfo)(CK_INFO_PTR pInfo)
{
    CheckRuntime();
    EngineGetInfo *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_GetInfo",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(pInfo);
}

CK_DEFINE_FUNCTION(CK_RV, C_GetFunctionList)(CK_FUNCTION_LIST_PTR_PTR ppFunctionList)
{
    CheckRuntime();
    if (NULL == ppFunctionList)
        return CKR_ARGUMENTS_BAD;

    *ppFunctionList = &function_list;

    EngineGetFunctionList *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_GetFunctionList",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(*ppFunctionList);
}

CK_DEFINE_FUNCTION(CK_RV, C_GetSlotList)(CK_BBOOL tokenPresent, CK_SLOT_ID_PTR pSlotList, CK_ULONG_PTR pulCount)
{
    CheckRuntime();
    EngineGetSlotList *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_GetSlotList",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(tokenPresent, pSlotList, pulCount);
}

CK_DEFINE_FUNCTION(CK_RV, C_GetSlotInfo)(CK_SLOT_ID slotID, CK_SLOT_INFO_PTR pInfo)
{
    CheckRuntime();
    EngineGetSlotInfo *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_GetSlotInfo",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(slotID, pInfo);
}

CK_DEFINE_FUNCTION(CK_RV, C_GetTokenInfo)(CK_SLOT_ID slotID, CK_TOKEN_INFO_PTR pInfo)
{
    CheckRuntime();
    EngineGetTokenInfo *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_GetTokenInfo",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(slotID, pInfo);
}

CK_DEFINE_FUNCTION(CK_RV, C_GetMechanismList)(CK_SLOT_ID slotID, CK_MECHANISM_TYPE_PTR pMechanismList, CK_ULONG_PTR pulCount)
{
    CheckRuntime();
    EngineGetMechanismList *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_GetMechanismList",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(slotID, pMechanismList, pulCount);
}

CK_DEFINE_FUNCTION(CK_RV, C_GetMechanismInfo)(CK_SLOT_ID slotID, CK_MECHANISM_TYPE type, CK_MECHANISM_INFO_PTR pInfo)
{
    CheckRuntime();
    EngineGetMechanismInfo *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_GetMechanismInfo",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(slotID, type, pInfo);
}

CK_DEFINE_FUNCTION(CK_RV, C_InitToken)(CK_SLOT_ID slotID, CK_UTF8CHAR_PTR pPin, CK_ULONG ulPinLen, CK_UTF8CHAR_PTR pLabel)
{
    CheckRuntime();
    EngineInitToken *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_InitToken",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(slotID, pPin, ulPinLen, pLabel);
}

CK_DEFINE_FUNCTION(CK_RV, C_InitPIN)(CK_SESSION_HANDLE hSession, CK_UTF8CHAR_PTR pPin, CK_ULONG ulPinLen)
{
    CheckRuntime();
    EngineInitPIN *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_InitPIN",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pPin, ulPinLen);
}

CK_DEFINE_FUNCTION(CK_RV, C_SetPIN)(CK_SESSION_HANDLE hSession, CK_UTF8CHAR_PTR pOldPin, CK_ULONG ulOldLen, CK_UTF8CHAR_PTR pNewPin, CK_ULONG ulNewLen)
{
    CheckRuntime();
    EngineSetPIN *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_SetPIN",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pOldPin, ulOldLen, pNewPin, ulNewLen);
}

CK_DEFINE_FUNCTION(CK_RV, C_OpenSession)(CK_SLOT_ID slotID, CK_FLAGS flags, CK_VOID_PTR pApplication, CK_NOTIFY Notify, CK_SESSION_HANDLE_PTR phSession)
{
    CheckRuntime();
    EngineOpenSession *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_OpenSession",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(slotID, flags, pApplication, Notify, phSession);
}

CK_DEFINE_FUNCTION(CK_RV, C_CloseSession)(CK_SESSION_HANDLE hSession)
{
    CheckRuntime();
    EngineCloseSession *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_CloseSession",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession);
}

CK_DEFINE_FUNCTION(CK_RV, C_CloseAllSessions)(CK_SLOT_ID slotID)
{
    CheckRuntime();
    EngineCloseAllSessions *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_CloseAllSessions",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(slotID);
}


CK_DEFINE_FUNCTION(CK_RV, C_GetSessionInfo)(CK_SESSION_HANDLE hSession, CK_SESSION_INFO_PTR pInfo)
{
    CheckRuntime();
    EngineGetSessionInfo *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_GetSessionInfo",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pInfo);
}


CK_DEFINE_FUNCTION(CK_RV, C_GetOperationState)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pOperationState, CK_ULONG_PTR pulOperationStateLen)
{
    CheckRuntime();
    CheckRuntime();
    EngineGetOperationState *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_GetOperationState",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pOperationState, pulOperationStateLen);
}


CK_DEFINE_FUNCTION(CK_RV, C_SetOperationState)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pOperationState, CK_ULONG ulOperationStateLen, CK_OBJECT_HANDLE hEncryptionKey, CK_OBJECT_HANDLE hAuthenticationKey)
{
    CheckRuntime();
    EngineSetOperationState *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_SetOperationState",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pOperationState, ulOperationStateLen, hEncryptionKey, hAuthenticationKey);
}


CK_DEFINE_FUNCTION(CK_RV, C_Login)(CK_SESSION_HANDLE hSession, CK_USER_TYPE userType, CK_UTF8CHAR_PTR pPin, CK_ULONG ulPinLen)
{
    CheckRuntime();
    EngineLogin *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_Login",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, userType, pPin, ulPinLen);
}


CK_DEFINE_FUNCTION(CK_RV, C_Logout)(CK_SESSION_HANDLE hSession)
{
    CheckRuntime();
    EngineLogout *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_Logout",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession);
}


CK_DEFINE_FUNCTION(CK_RV, C_CreateObject)(CK_SESSION_HANDLE hSession, CK_ATTRIBUTE_PTR pTemplate, CK_ULONG ulCount, CK_OBJECT_HANDLE_PTR phObject)
{
    CheckRuntime();
    EngineCreateObject *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_CreateObject",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pTemplate, ulCount, phObject);
}


CK_DEFINE_FUNCTION(CK_RV, C_CopyObject)(CK_SESSION_HANDLE hSession, CK_OBJECT_HANDLE hObject, CK_ATTRIBUTE_PTR pTemplate, CK_ULONG ulCount, CK_OBJECT_HANDLE_PTR phNewObject)
{
    CheckRuntime();
    EngineCopyObject *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_CopyObject",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, hObject, pTemplate, ulCount, phNewObject);
}


CK_DEFINE_FUNCTION(CK_RV, C_DestroyObject)(CK_SESSION_HANDLE hSession, CK_OBJECT_HANDLE hObject)
{
    CheckRuntime();
    EngineDestroyObject *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_DestroyObject",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, hObject);
}


CK_DEFINE_FUNCTION(CK_RV, C_GetObjectSize)(CK_SESSION_HANDLE hSession, CK_OBJECT_HANDLE hObject, CK_ULONG_PTR pulSize)
{
    CheckRuntime();
    EngineGetObjectSize *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_GetObjectSize",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, hObject, pulSize);
}


CK_DEFINE_FUNCTION(CK_RV, C_GetAttributeValue)(CK_SESSION_HANDLE hSession, CK_OBJECT_HANDLE hObject, CK_ATTRIBUTE_PTR pTemplate, CK_ULONG ulCount)
{
    CheckRuntime();
    EngineGetAttributeValue *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_GetAttributeValue",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, hObject, pTemplate, ulCount);
}


CK_DEFINE_FUNCTION(CK_RV, C_SetAttributeValue)(CK_SESSION_HANDLE hSession, CK_OBJECT_HANDLE hObject, CK_ATTRIBUTE_PTR pTemplate, CK_ULONG ulCount)
{
    CheckRuntime();
    EngineSetAttributeValue *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_SetAttributeValue",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, hObject, pTemplate, ulCount);
}


CK_DEFINE_FUNCTION(CK_RV, C_FindObjectsInit)(CK_SESSION_HANDLE hSession, CK_ATTRIBUTE_PTR pTemplate, CK_ULONG ulCount)
{
    CheckRuntime();
    EngineFindObjectsInit *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_FindObjectsInit",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pTemplate, ulCount);
}


CK_DEFINE_FUNCTION(CK_RV, C_FindObjects)(CK_SESSION_HANDLE hSession, CK_OBJECT_HANDLE_PTR phObject, CK_ULONG ulMaxObjectCount, CK_ULONG_PTR pulObjectCount)
{
    CheckRuntime();
    EngineFindObjects *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_FindObjects",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, phObject, ulMaxObjectCount, pulObjectCount);
}


CK_DEFINE_FUNCTION(CK_RV, C_FindObjectsFinal)(CK_SESSION_HANDLE hSession)
{
    CheckRuntime();
    EngineFindObjectsFinal *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_FindObjectsFinal",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession);
}


CK_DEFINE_FUNCTION(CK_RV, C_EncryptInit)(CK_SESSION_HANDLE hSession, CK_MECHANISM_PTR pMechanism, CK_OBJECT_HANDLE hKey)
{
    CheckRuntime();
    EngineEncryptInit *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_EncryptInit",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pMechanism, hKey);
}


CK_DEFINE_FUNCTION(CK_RV, C_Encrypt)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pData, CK_ULONG ulDataLen, CK_BYTE_PTR pEncryptedData, CK_ULONG_PTR pulEncryptedDataLen)
{
    CheckRuntime();
    EngineEncrypt *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_Encrypt",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pData, ulDataLen, pEncryptedData, pulEncryptedDataLen);
}


CK_DEFINE_FUNCTION(CK_RV, C_EncryptUpdate)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pPart, CK_ULONG ulPartLen, CK_BYTE_PTR pEncryptedPart, CK_ULONG_PTR pulEncryptedPartLen)
{
    CheckRuntime();
    EngineEncryptUpdate *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_EncryptUpdate",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pPart, ulPartLen, pEncryptedPart, pulEncryptedPartLen);
}


CK_DEFINE_FUNCTION(CK_RV, C_EncryptFinal)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pLastEncryptedPart, CK_ULONG_PTR pulLastEncryptedPartLen)
{
    CheckRuntime();
    EngineEncryptFinal *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_EncryptFinal",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pLastEncryptedPart, pulLastEncryptedPartLen);
}


CK_DEFINE_FUNCTION(CK_RV, C_DecryptInit)(CK_SESSION_HANDLE hSession, CK_MECHANISM_PTR pMechanism, CK_OBJECT_HANDLE hKey)
{
    CheckRuntime();
    EngineDecryptInit *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_DecryptInit",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pMechanism, hKey);
}


CK_DEFINE_FUNCTION(CK_RV, C_Decrypt)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pEncryptedData, CK_ULONG ulEncryptedDataLen, CK_BYTE_PTR pData, CK_ULONG_PTR pulDataLen)
{
    CheckRuntime();
    EngineDecrypt *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_Decrypt",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pEncryptedData, ulEncryptedDataLen, pData, pulDataLen);
}


CK_DEFINE_FUNCTION(CK_RV, C_DecryptUpdate)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pEncryptedPart, CK_ULONG ulEncryptedPartLen, CK_BYTE_PTR pPart, CK_ULONG_PTR pulPartLen)
{
    CheckRuntime();
    EngineDecryptUpdate *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_DecryptUpdate",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pEncryptedPart, ulEncryptedPartLen, pPart, pulPartLen);
}


CK_DEFINE_FUNCTION(CK_RV, C_DecryptFinal)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pLastPart, CK_ULONG_PTR pulLastPartLen)
{
    CheckRuntime();
    EngineDecryptFinal *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_DecryptFinal",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pLastPart, pulLastPartLen);
}


CK_DEFINE_FUNCTION(CK_RV, C_DigestInit)(CK_SESSION_HANDLE hSession, CK_MECHANISM_PTR pMechanism)
{
    CheckRuntime();
    EngineDigestInit *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_DigestInit",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pMechanism);
}


CK_DEFINE_FUNCTION(CK_RV, C_Digest)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pData, CK_ULONG ulDataLen, CK_BYTE_PTR pDigest, CK_ULONG_PTR pulDigestLen)
{
    CheckRuntime();
    EngineDigest *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_Digest",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pData, ulDataLen, pDigest, pulDigestLen);
}


CK_DEFINE_FUNCTION(CK_RV, C_DigestUpdate)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pPart, CK_ULONG ulPartLen)
{
    CheckRuntime();
    EngineDigestUpdate *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_DigestUpdate",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pPart, ulPartLen);
}


CK_DEFINE_FUNCTION(CK_RV, C_DigestKey)(CK_SESSION_HANDLE hSession, CK_OBJECT_HANDLE hKey)
{
    CheckRuntime();
    EngineDigestKey *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_DigestKey",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, hKey);
}


CK_DEFINE_FUNCTION(CK_RV, C_DigestFinal)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pDigest, CK_ULONG_PTR pulDigestLen)
{
    CheckRuntime();
    EngineDigestFinal *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_DigestFinal",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pDigest, pulDigestLen);
}


CK_DEFINE_FUNCTION(CK_RV, C_SignInit)(CK_SESSION_HANDLE hSession, CK_MECHANISM_PTR pMechanism, CK_OBJECT_HANDLE hKey)
{
    CheckRuntime();
    EngineSignInit *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_SignInit",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pMechanism, hKey);
}


CK_DEFINE_FUNCTION(CK_RV, C_Sign)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pData, CK_ULONG ulDataLen, CK_BYTE_PTR pSignature, CK_ULONG_PTR pulSignatureLen)
{
    CheckRuntime();
    EngineSign *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_Sign",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pData, ulDataLen, pSignature, pulSignatureLen);
}


CK_DEFINE_FUNCTION(CK_RV, C_SignUpdate)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pPart, CK_ULONG ulPartLen)
{
    CheckRuntime();
    EngineSignUpdate *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_SignUpdate",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pPart, ulPartLen);
}


CK_DEFINE_FUNCTION(CK_RV, C_SignFinal)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pSignature, CK_ULONG_PTR pulSignatureLen)
{
    CheckRuntime();
    EngineSignFinal *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_SignFinal",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pSignature, pulSignatureLen);
}


CK_DEFINE_FUNCTION(CK_RV, C_SignRecoverInit)(CK_SESSION_HANDLE hSession, CK_MECHANISM_PTR pMechanism, CK_OBJECT_HANDLE hKey)
{
    CheckRuntime();
    EngineSignRecoverInit *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_SignRecoverInit",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pMechanism, hKey);
}


CK_DEFINE_FUNCTION(CK_RV, C_SignRecover)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pData, CK_ULONG ulDataLen, CK_BYTE_PTR pSignature, CK_ULONG_PTR pulSignatureLen)
{
    CheckRuntime();
    EngineSignRecover *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_SignRecover",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pData, ulDataLen, pSignature, pulSignatureLen);
}


CK_DEFINE_FUNCTION(CK_RV, C_VerifyInit)(CK_SESSION_HANDLE hSession, CK_MECHANISM_PTR pMechanism, CK_OBJECT_HANDLE hKey)
{
    CheckRuntime();
    EngineVerifyInit *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_VerifyInit",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pMechanism, hKey);
}


CK_DEFINE_FUNCTION(CK_RV, C_Verify)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pData, CK_ULONG ulDataLen, CK_BYTE_PTR pSignature, CK_ULONG ulSignatureLen)
{
    CheckRuntime();
    EngineVerify *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_Verify",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pData, ulDataLen, pSignature, ulSignatureLen);
}


CK_DEFINE_FUNCTION(CK_RV, C_VerifyUpdate)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pPart, CK_ULONG ulPartLen)
{
    CheckRuntime();
    EngineVerifyUpdate *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_VerifyUpdate",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pPart, ulPartLen);
}


CK_DEFINE_FUNCTION(CK_RV, C_VerifyFinal)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pSignature, CK_ULONG ulSignatureLen)
{
    CheckRuntime();
    EngineVerifyFinal *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_VerifyFinal",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pSignature, ulSignatureLen);
}


CK_DEFINE_FUNCTION(CK_RV, C_VerifyRecoverInit)(CK_SESSION_HANDLE hSession, CK_MECHANISM_PTR pMechanism, CK_OBJECT_HANDLE hKey)
{
    CheckRuntime();
    EngineVerifyRecoverInit *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_VerifyRecoverInit",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pMechanism, hKey);
}


CK_DEFINE_FUNCTION(CK_RV, C_VerifyRecover)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pSignature, CK_ULONG ulSignatureLen, CK_BYTE_PTR pData, CK_ULONG_PTR pulDataLen)
{
    CheckRuntime();
    EngineVerifyRecover *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_VerifyRecover",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pSignature, ulSignatureLen, pData, pulDataLen);
}


CK_DEFINE_FUNCTION(CK_RV, C_DigestEncryptUpdate)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pPart, CK_ULONG ulPartLen, CK_BYTE_PTR pEncryptedPart, CK_ULONG_PTR pulEncryptedPartLen)
{
    CheckRuntime();
    EngineDigestEncryptUpdate *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_DigestEncryptUpdate",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pPart, ulPartLen, pEncryptedPart, pulEncryptedPartLen);
}


CK_DEFINE_FUNCTION(CK_RV, C_DecryptDigestUpdate)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pEncryptedPart, CK_ULONG ulEncryptedPartLen, CK_BYTE_PTR pPart, CK_ULONG_PTR pulPartLen)
{
    CheckRuntime();
    EngineDecryptDigestUpdate *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_DecryptDigestUpdate",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pEncryptedPart, ulEncryptedPartLen, pPart, pulPartLen);
}


CK_DEFINE_FUNCTION(CK_RV, C_SignEncryptUpdate)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pPart, CK_ULONG ulPartLen, CK_BYTE_PTR pEncryptedPart, CK_ULONG_PTR pulEncryptedPartLen)
{
    CheckRuntime();
    EngineSignEncryptUpdate *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_SignEncryptUpdate",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pPart, ulPartLen, pEncryptedPart, pulEncryptedPartLen);
}


CK_DEFINE_FUNCTION(CK_RV, C_DecryptVerifyUpdate)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pEncryptedPart, CK_ULONG ulEncryptedPartLen, CK_BYTE_PTR pPart, CK_ULONG_PTR pulPartLen)
{
    CheckRuntime();
    EngineDecryptVerifyUpdate *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_DecryptVerifyUpdate",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pEncryptedPart, ulEncryptedPartLen, pPart, pulPartLen);
}


CK_DEFINE_FUNCTION(CK_RV, C_GenerateKey)(CK_SESSION_HANDLE hSession, CK_MECHANISM_PTR pMechanism, CK_ATTRIBUTE_PTR pTemplate, CK_ULONG ulCount, CK_OBJECT_HANDLE_PTR phKey)
{
    CheckRuntime();
    EngineGenerateKey *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_GenerateKey",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pMechanism, pTemplate, ulCount, phKey);
}


CK_DEFINE_FUNCTION(CK_RV, C_GenerateKeyPair)(CK_SESSION_HANDLE hSession, CK_MECHANISM_PTR pMechanism, CK_ATTRIBUTE_PTR pPublicKeyTemplate, CK_ULONG ulPublicKeyAttributeCount, CK_ATTRIBUTE_PTR pPrivateKeyTemplate, CK_ULONG ulPrivateKeyAttributeCount, CK_OBJECT_HANDLE_PTR phPublicKey, CK_OBJECT_HANDLE_PTR phPrivateKey)
{
    CheckRuntime();
    EngineGenerateKeyPair *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_GenerateKeyPair",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pMechanism, pPublicKeyTemplate, ulPublicKeyAttributeCount, pPrivateKeyTemplate, ulPrivateKeyAttributeCount, phPublicKey, phPrivateKey);
}


CK_DEFINE_FUNCTION(CK_RV, C_WrapKey)(CK_SESSION_HANDLE hSession, CK_MECHANISM_PTR pMechanism, CK_OBJECT_HANDLE hWrappingKey, CK_OBJECT_HANDLE hKey, CK_BYTE_PTR pWrappedKey, CK_ULONG_PTR pulWrappedKeyLen)
{
    CheckRuntime();
    EngineWrapKey *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_WrapKey",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pMechanism, hWrappingKey, hKey, pWrappedKey, pulWrappedKeyLen);
}


CK_DEFINE_FUNCTION(CK_RV, C_UnwrapKey)(CK_SESSION_HANDLE hSession, CK_MECHANISM_PTR pMechanism, CK_OBJECT_HANDLE hUnwrappingKey, CK_BYTE_PTR pWrappedKey, CK_ULONG ulWrappedKeyLen, CK_ATTRIBUTE_PTR pTemplate, CK_ULONG ulAttributeCount, CK_OBJECT_HANDLE_PTR phKey)
{
    CheckRuntime();
    EngineUnwrapKey *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_UnwrapKey",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pMechanism, hUnwrappingKey, pWrappedKey, ulWrappedKeyLen, pTemplate, ulAttributeCount, phKey);
}


CK_DEFINE_FUNCTION(CK_RV, C_DeriveKey)(CK_SESSION_HANDLE hSession, CK_MECHANISM_PTR pMechanism, CK_OBJECT_HANDLE hBaseKey, CK_ATTRIBUTE_PTR pTemplate, CK_ULONG ulAttributeCount, CK_OBJECT_HANDLE_PTR phKey)
{
    CheckRuntime();
    EngineDeriveKey *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_DeriveKey",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pMechanism, hBaseKey, pTemplate, ulAttributeCount, phKey);
}


CK_DEFINE_FUNCTION(CK_RV, C_SeedRandom)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR pSeed, CK_ULONG ulSeedLen)
{
    CheckRuntime();
    EngineSeedRandom *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_SeedRandom",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, pSeed, ulSeedLen);
}


CK_DEFINE_FUNCTION(CK_RV, C_GenerateRandom)(CK_SESSION_HANDLE hSession, CK_BYTE_PTR RandomData, CK_ULONG ulRandomLen)
{
    CheckRuntime();
    EngineGenerateRandom *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_GenerateRandom",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession, RandomData, ulRandomLen);
}


CK_DEFINE_FUNCTION(CK_RV, C_GetFunctionStatus)(CK_SESSION_HANDLE hSession)
{
    CheckRuntime();
    EngineGetFunctionStatus *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_GetFunctionStatus",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession);
}


CK_DEFINE_FUNCTION(CK_RV, C_CancelFunction)(CK_SESSION_HANDLE hSession)
{
    CheckRuntime();
    EngineCancelFunction *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_CancelFunction",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(hSession);
}


CK_DEFINE_FUNCTION(CK_RV, C_WaitForSlotEvent)(CK_FLAGS flags, CK_SLOT_ID_PTR pSlot, CK_VOID_PTR pReserved)
{
    CheckRuntime();
    EngineWaitForSlotEvent *pfnDelegate = NULL;
    runtime->CreateDelegate(
        L"Engine",
        L"C_WaitForSlotEvent",
        (INT_PTR*)&pfnDelegate
    );

    if (pfnDelegate == NULL)
        return CKR_FUNCTION_NOT_SUPPORTED;

    return pfnDelegate(flags, pSlot, pReserved);
}
