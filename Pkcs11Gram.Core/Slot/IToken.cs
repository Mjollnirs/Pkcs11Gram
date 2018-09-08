// Project: Pkcs11Gram.Core
// File: IToken.cs
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
using Pkcs11Gram.Core.Pkcs11;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pkcs11Gram.Core.Slot
{
    public interface IToken
    {
        /// <summary>
        /// Token lable
        /// 32 bytes
        /// </summary>
        string Label { get; }

        /// <summary>
        /// Manufacturer Id
        /// 32 bytes
        /// </summary>
        string ManufacturerId { get; }

        /// <summary>
        /// Token Model
        /// 16 bytes
        /// </summary>
        string Model { get; }

        /// <summary>
        /// Token SerialNumber
        /// 16 bytes
        /// </summary>
        string SerialNumber { get; }

        /// <summary>
        /// Token Max Session Count
        /// </summary>
        UInt32 MaxSessionCount { get; }

        /// <summary>
        /// Token Session Count
        /// </summary>
        UInt32 SessionCount { get; }

        /// <summary>
        /// Token Max Read/Write Session Count
        /// </summary>
        UInt32 MaxRwSessionCount { get; }

        /// <summary>
        /// Token Read/Write Session Count
        /// </summary>
        UInt32 RwSessionCount { get; }

        /// <summary>
        /// Token Max PIN
        /// </summary>
        UInt32 MaxPinLen { get; }

        /// <summary>
        /// Token Min PIN
        /// </summary>
        UInt32 MinPinLen { get; }

        /// <summary>
        /// Token Total Public Memory
        /// </summary>
        UInt32 TotalPublicMemory { get; }

        /// <summary>
        /// Token Free Public Memory
        /// </summary>
        UInt32 FreePublicMemory { get; }

        /// <summary>
        /// Token Total Private Memory
        /// </summary>
        UInt32 TotalPrivateMemory { get; }

        /// <summary>
        /// Token Free Private Memory
        /// </summary>
        UInt32 FreePrivateMemory { get; }

        /// <summary>
        /// Hardware Version
        /// </summary>
        (byte, byte) HardwareVersion { get; }

        /// <summary>
        /// Firmware Version
        /// </summary>
        (byte, byte) FirmwareVersion { get; }

        /// <summary>
        /// True if the token has its own random number generator
        /// </summary>
        bool Rng { get; }

        /// <summary>
        /// True if the token is write-protected
        /// </summary>
        bool WriteProtected { get; }

        /// <summary>
        /// True if there are some cryptographic functions that a user must be logged in to perform
        /// </summary>
        bool LoginRequired { get; }

        /// <summary>
        /// True if the normal user's PIN has been initialized
        /// </summary>
        bool UserPinInitialized { get; }

        /// <summary>
        /// True if a successful save of a session's cryptographic operations state always contains all keys needed to restore the state of the session
        /// </summary>
        bool RestoreKeyNotNeeded { get; }

        /// <summary>
        /// True if token has its own hardware clock
        /// </summary>
        bool ClockOnToken { get; }

        /// <summary>
        /// True if token has a "protected authentication path", whereby a user can log into the token without passing a PIN through the Cryptoki library
        /// </summary>
        bool ProtectedAuthenticationPath { get; }

        /// <summary>
        /// True if a single session with the token can perform dual cryptographic operations
        /// </summary>
        bool DualCryptoOperations { get; }

        /// <summary>
        /// True if the token has been initialized using C_InitializeToken or an equivalent mechanism
        /// </summary>
        bool TokenInitialized { get; }

        /// <summary>
        /// True if the token supports secondary authentication for private key objects
        /// </summary>
        bool SecondaryAuthentication { get; }

        /// <summary>
        /// True if an incorrect user login PIN has been entered at least once since the last successful authentication
        /// </summary>
        bool UserPinCountLow { get; }

        /// <summary>
        /// True if supplying an incorrect user PIN will make it to become locked
        /// </summary>
        bool UserPinFinalTry { get; }

        /// <summary>
        /// True if the user PIN has been locked. User login to the token is not possible.
        /// </summary>
        bool UserPinLocked { get; }

        /// <summary>
        /// True if the user PIN value is the default value set by token initialization or manufacturing,
        /// or the PIN has been expired by the card
        /// </summary>
        bool UserPinToBeChanged { get; }

        /// <summary>
        /// True if an incorrect SO login PIN has been entered at least once since the last successful authentication
        /// </summary>
        bool SoPinCountLow { get; }

        /// <summary>
        /// True if supplying an incorrect SO PIN will make it to become locked.
        /// </summary>
        bool SoPinFinalTry { get; }

        /// <summary>
        /// True if the SO PIN has been locked. User login to the token is not possible.
        /// </summary>
        bool SoPinLocked { get; }

        /// <summary>
        /// True if the SO PIN value is the default value set by token initialization or manufacturing,
        /// or the PIN has been expired by the card.
        /// </summary>
        bool SoPinToBeChanged { get; }

        /// <summary>
        /// If token supported UtcTime, get UtcTime form Token. 
        /// </summary>
        /// <returns></returns>
        DateTime? GetUtcTime();

        /// <summary>
        /// Get pcks11 slot info
        /// </summary>
        /// <returns></returns>
        Task<TokenInfo> GetTokenInfo();

        /// <summary>
        /// Open a new Session
        /// </summary>
        /// <returns></returns>
        Task<ISession> OpenSession();
    }
}
