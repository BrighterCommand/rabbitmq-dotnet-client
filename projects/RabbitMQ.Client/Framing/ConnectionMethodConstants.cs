// This source code is dual-licensed under the Apache License, version
// 2.0, and the Mozilla Public License, version 2.0.
//
// The APL v2.0:
//
//---------------------------------------------------------------------------
//   Copyright (c) 2007-2025 Broadcom. All Rights Reserved.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       https://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
//---------------------------------------------------------------------------
//
// The MPL v2.0:
//
//---------------------------------------------------------------------------
// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.
//
//  Copyright (c) 2007-2025 Broadcom. All Rights Reserved.
//---------------------------------------------------------------------------

namespace RabbitMQ.Client.Framing
{
    internal static class ConnectionMethodConstants
    {
        internal const ushort Start = 10;
        internal const ushort StartOk = 11;
        internal const ushort Secure = 20;
        internal const ushort SecureOk = 21;
        internal const ushort Tune = 30;
        internal const ushort TuneOk = 31;
        internal const ushort Open = 40;
        internal const ushort OpenOk = 41;
        internal const ushort Close = 50;
        internal const ushort CloseOk = 51;
        internal const ushort Blocked = 60;
        internal const ushort Unblocked = 61;
        internal const ushort UpdateSecret = 70;
        internal const ushort UpdateSecretOk = 71;
    }
}
