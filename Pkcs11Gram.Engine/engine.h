// Project: Pkcs11Gram.Engine
// File: engine.h
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

#include <string>
#include <iostream>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <Windows.h>
#include "CLRRuntime.h"

using namespace std;

// PKCS#11 related stuff
#pragma pack(push, cryptoki, 1)

#define CK_IMPORT_SPEC __declspec(dllimport) 

#ifdef CRYPTOKI_EXPORTS 
#define CK_EXPORT_SPEC __declspec(dllexport) 
#else 
#define CK_EXPORT_SPEC CK_IMPORT_SPEC 
#endif 

#define CK_CALL_SPEC __cdecl 

#define CK_PTR *
#define CK_DEFINE_FUNCTION(returnType, name) returnType CK_EXPORT_SPEC CK_CALL_SPEC name
#define CK_DECLARE_FUNCTION(returnType, name) returnType CK_EXPORT_SPEC CK_CALL_SPEC name
#define CK_DECLARE_FUNCTION_POINTER(returnType, name) returnType CK_IMPORT_SPEC (CK_CALL_SPEC CK_PTR name)
#define CK_CALLBACK_FUNCTION(returnType, name) returnType (CK_CALL_SPEC CK_PTR name)

#ifndef NULL_PTR
#define NULL_PTR 0
#endif

#include <cryptoki\pkcs11.h>

#include "loader.h"

#pragma pack(pop, cryptoki)


#define IGNORE(P) (void)(P)

typedef enum
{
    PKCS11_CK_OPERATION_NONE,
    PKCS11_CK_OPERATION_FIND,
    PKCS11_CK_OPERATION_ENCRYPT,
    PKCS11_CK_OPERATION_DECRYPT,
    PKCS11_CK_OPERATION_DIGEST,
    PKCS11_CK_OPERATION_SIGN,
    PKCS11_CK_OPERATION_SIGN_RECOVER,
    PKCS11_CK_OPERATION_VERIFY,
    PKCS11_CK_OPERATION_VERIFY_RECOVER,
    PKCS11_CK_OPERATION_DIGEST_ENCRYPT,
    PKCS11_CK_OPERATION_DECRYPT_DIGEST,
    PKCS11_CK_OPERATION_SIGN_ENCRYPT,
    PKCS11_CK_OPERATION_DECRYPT_VERIFY
}
PKCS11_CK_OPERATION;

static const wchar_t *LoaderPath = L"Loader";
static const wchar_t *CoreCRLDll = L"CoreCLR.dll";
static const wchar_t *AppDll = L"Pkcs11Gram.Loader.dll";

void CheckRuntime();
