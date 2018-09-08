// Project: Pkcs11Gram.Engine
// File: CLRRuntime.h
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
#include <coreclr\mscoree.h>

class CLRRuntime
{
public:
    CLRRuntime();
    ~CLRRuntime();
    void CreateDelegate(LPCWSTR className, LPCWSTR methodName, INT_PTR *fnPtr);
private:
    DWORD domainId = NULL;
    DWORD exitCode = 999;
    HMODULE coreCLRModule = NULL;
protected:
    ICLRRuntimeHost4 * RuntimeHost = NULL;
    wchar_t* GetCoreLibraryPath();
    wchar_t* GetCoreLibrary();
    wchar_t* GetAppLibrary();
    wchar_t* GetBasePath();
    DWORD ExecuteAssembly();
};

