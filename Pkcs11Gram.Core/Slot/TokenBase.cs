// Project: Pkcs11Gram.Core
// File: TokenBase.cs
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
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel;
using Pkcs11Gram.Core.Pkcs11;

namespace Pkcs11Gram.Core.Slot
{
    public abstract class TokenBase<TSeesion> : IToken
        where TSeesion: SessionBase, ISession
    {
        private readonly IKernel Kernel;

        public TokenBase(
            IKernel kernel,
            string manufacturerId,
            string model,
            string serialNumber)
        {
            Kernel = kernel;
            if (manufacturerId.Length > 32)
                manufacturerId = manufacturerId.Substring(0, 32);

            if (model.Length > 16)
                model = model.Substring(0, 16);

            if (serialNumber.Length > 16)
                serialNumber = serialNumber.Substring(0, 16);

            ManufacturerId = manufacturerId;
            Model = model;
            SerialNumber = serialNumber;
        }

        /// <summary>
        /// Token lable
        /// 32 bytes
        /// </summary>
        public string Label { get; protected set; } = string.Empty;

        /// <summary>
        /// Manufacturer Id
        /// 32 bytes
        /// </summary>
        public string ManufacturerId { get; private set; } = string.Empty;

        /// <summary>
        /// Token Model
        /// 16 bytes
        /// </summary>
        public string Model { get; private set; } = string.Empty;

        /// <summary>
        /// Token SerialNumber
        /// 16 bytes
        /// </summary>
        public string SerialNumber { get; private set; } = string.Empty;

        /// <summary>
        /// Token Max Session Count
        /// </summary>
        public uint MaxSessionCount { get; protected set; } = 1;

        /// <summary>
        /// Token Session Count
        /// </summary>
        public uint SessionCount { get; protected set; }

        /// <summary>
        /// Token Max Read/Write Session Count
        /// </summary>
        public uint MaxRwSessionCount { get; protected set; } = 1;

        /// <summary>
        /// Token Read/Write Session Count
        /// </summary>
        public uint RwSessionCount { get; protected set; }

        /// <summary>
        /// Token Max PIN
        /// </summary>
        public uint MaxPinLen { get; protected set; } = 16;

        /// <summary>
        /// Token Min PIN
        /// </summary>
        public uint MinPinLen { get; protected set; } = 6;

        /// <summary>
        /// Token Total Public Memory
        /// </summary>
        public uint TotalPublicMemory { get; protected set; } = 2048;

        /// <summary>
        /// Token Free Public Memory
        /// </summary>
        public uint FreePublicMemory { get; protected set; } = 2048;

        /// <summary>
        /// Token Total Private Memory
        /// </summary>
        public uint TotalPrivateMemory { get; protected set; } = 2048;

        /// <summary>
        /// Token Free Private Memory
        /// </summary>
        public uint FreePrivateMemory { get; protected set; } = 2048;

        /// <summary>
        /// Hardware Version
        /// </summary>
        public (byte, byte) HardwareVersion { get; protected set; } = (0, 0);

        /// <summary>
        /// Firmware Version
        /// </summary>
        public (byte, byte) FirmwareVersion { get; protected set; } = (0, 0);

        /// <summary>
        /// True if the token has its own random number generator
        /// </summary>
        public bool Rng { get; protected set; }

        /// <summary>
        /// True if the token is write-protected
        /// </summary>
        public bool WriteProtected { get; protected set; }

        /// <summary>
        /// True if there are some cryptographic functions that a user must be logged in to perform
        /// </summary>
        public bool LoginRequired { get; protected set; }

        /// <summary>
        /// True if the normal user's PIN has been initialized
        /// </summary>
        public bool UserPinInitialized { get; protected set; }

        /// <summary>
        /// True if a successful save of a session's cryptographic operations state always contains all keys needed to restore the state of the session
        /// </summary>
        public bool RestoreKeyNotNeeded { get; protected set; }

        /// <summary>
        /// True if token has its own hardware clock
        /// </summary>
        public bool ClockOnToken { get; protected set; }

        /// <summary>
        /// True if token has a "protected authentication path", whereby a user can log into the token without passing a PIN through the Cryptoki library
        /// </summary>
        public bool ProtectedAuthenticationPath { get; protected set; }

        /// <summary>
        /// True if a single session with the token can perform dual cryptographic operations
        /// </summary>
        public bool DualCryptoOperations { get; protected set; }

        /// <summary>
        /// True if the token has been initialized using C_InitializeToken or an equivalent mechanism
        /// </summary>
        public bool TokenInitialized { get; protected set; }

        /// <summary>
        /// True if the token supports secondary authentication for private key objects
        /// </summary>
        public bool SecondaryAuthentication { get; protected set; }

        /// <summary>
        /// True if an incorrect user login PIN has been entered at least once since the last successful authentication
        /// </summary>
        public bool UserPinCountLow { get; protected set; }

        /// <summary>
        /// True if supplying an incorrect user PIN will make it to become locked
        /// </summary>
        public bool UserPinFinalTry { get; protected set; }

        /// <summary>
        /// True if the user PIN has been locked. User login to the token is not possible.
        /// </summary>
        public bool UserPinLocked { get; protected set; }

        /// <summary>
        /// True if the user PIN value is the default value set by token initialization or manufacturing,
        /// or the PIN has been expired by the card
        /// </summary>
        public bool UserPinToBeChanged { get; protected set; }

        /// <summary>
        /// True if an incorrect SO login PIN has been entered at least once since the last successful authentication
        /// </summary>
        public bool SoPinCountLow { get; protected set; }

        /// <summary>
        /// True if supplying an incorrect SO PIN will make it to become locked.
        /// </summary>
        public bool SoPinFinalTry { get; protected set; }

        /// <summary>
        /// True if the SO PIN has been locked. User login to the token is not possible.
        /// </summary>
        public bool SoPinLocked { get; protected set; }

        /// <summary>
        /// True if the SO PIN value is the default value set by token initialization or manufacturing,
        /// or the PIN has been expired by the card.
        /// </summary>
        public bool SoPinToBeChanged { get; protected set; }

        /// <summary>
        /// If token supported UtcTime, get UtcTime form Token.
        /// </summary>
        /// <returns></returns>
        public virtual DateTime? GetUtcTime()
        {
            if (ClockOnToken)
            {
                return DateTime.UtcNow;
            }
            return null;
        }

        /// <summary>
        /// Get Pkcs11 Token info.
        /// </summary>
        /// <returns></returns>
        public Task<TokenInfo> GetTokenInfo()
        {
            TokenFlags tokenFlags = GetTokenFlags();

            return Task.FromResult(new TokenInfo()
            {
                Label = Encoding.ASCII.GetBytes(Label.PadRight(32)),
                ManufacturerId = Encoding.ASCII.GetBytes(ManufacturerId.PadRight(32)),
                Model = Encoding.ASCII.GetBytes(Model.PadRight(16)),
                SerialNumber = Encoding.ASCII.GetBytes(SerialNumber.PadRight(16)),
                Flags = tokenFlags,
                MaxSessionCount = MaxSessionCount,
                SessionCount = SessionCount,
                MaxRwSessionCount = MaxRwSessionCount,
                RwSessionCount = RwSessionCount,
                MaxPinLen = MaxPinLen,
                MinPinLen = MinPinLen,
                TotalPublicMemory = TotalPublicMemory,
                FreePublicMemory = FreePublicMemory,
                TotalPrivateMemory = TotalPrivateMemory,
                FreePrivateMemory = FreePrivateMemory,
                HardwareVersion = new Pkcs11Version() { Major = HardwareVersion.Item1, Minor = HardwareVersion.Item2 },
                FirmwareVersion = new Pkcs11Version() { Major = FirmwareVersion.Item1, Minor = FirmwareVersion.Item2 },
                UtcTime = ConvertDateTimeToByte(GetUtcTime()),
            });
        }

        /// <summary>
        /// Open a new Session
        /// </summary>
        /// <returns></returns>
        public async Task<ISession> OpenSession()
        {
            return await ProcessOpenSession(Kernel.Resolve<TSeesion>());
        }

        /// <summary>
        /// Process open a new session.
        /// </summary>
        /// <returns></returns>
        protected abstract Task<ISession> ProcessOpenSession(TSeesion seesion);

        private byte[] ConvertDateTimeToByte(DateTime? dateTime)
        {
            string str = string.Empty;
            if (dateTime.HasValue)
            {
                str = dateTime.Value.ToString("YYYYMMDDhhmmss");
            }

            return Encoding.ASCII.GetBytes(str.PadRight(16, '0'));
        }

        private TokenFlags GetTokenFlags()
        {
            TokenFlags tokenFlags = TokenFlags.NONE;

            if (Rng)
                tokenFlags = tokenFlags | TokenFlags.RNG;
            if (WriteProtected)
                tokenFlags = tokenFlags | TokenFlags.WRITE_PROTECTED;
            if (LoginRequired)
                tokenFlags = tokenFlags | TokenFlags.LOGIN_REQUIRED;
            if (UserPinInitialized)
                tokenFlags = tokenFlags | TokenFlags.USER_PIN_INITIALIZED;
            if (RestoreKeyNotNeeded)
                tokenFlags = tokenFlags | TokenFlags.RESTORE_KEY_NOT_NEEDED;
            if (ClockOnToken)
                tokenFlags = tokenFlags | TokenFlags.CLOCK_ON_TOKEN;
            if (ProtectedAuthenticationPath)
                tokenFlags = tokenFlags | TokenFlags.PROTECTED_AUTHENTICATION_PATH;
            if (DualCryptoOperations)
                tokenFlags = tokenFlags | TokenFlags.DUAL_CRYPTO_OPERATIONS;
            if (TokenInitialized)
                tokenFlags = tokenFlags | TokenFlags.TOKEN_INITIALIZED;
            if (SecondaryAuthentication)
                tokenFlags = tokenFlags | TokenFlags.SECONDARY_AUTHENTICATION;
            if (UserPinCountLow)
                tokenFlags = tokenFlags | TokenFlags.USER_PIN_COUNT_LOW;
            if (UserPinFinalTry)
                tokenFlags = tokenFlags | TokenFlags.USER_PIN_FINAL_TRY;
            if (UserPinLocked)
                tokenFlags = tokenFlags | TokenFlags.USER_PIN_LOCKED;
            if (UserPinToBeChanged)
                tokenFlags = tokenFlags | TokenFlags.USER_PIN_TO_BE_CHANGED;
            if (SoPinCountLow)
                tokenFlags = tokenFlags | TokenFlags.SO_PIN_COUNT_LOW;
            if (SoPinFinalTry)
                tokenFlags = tokenFlags | TokenFlags.SO_PIN_FINAL_TRY;
            if (SoPinLocked)
                tokenFlags = tokenFlags | TokenFlags.SO_PIN_LOCKED;
            if (SoPinToBeChanged)
                tokenFlags = tokenFlags | TokenFlags.SO_PIN_TO_BE_CHANGED;

            return tokenFlags;
        }
    }
}
