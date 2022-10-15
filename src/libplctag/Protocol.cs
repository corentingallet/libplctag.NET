﻿// Copyright (c) libplctag.NET contributors
// https://github.com/libplctag/libplctag.NET
//
// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

namespace libplctag
{
    public enum Protocol
    {
        /// <summary>
        /// Allen-Bradley specific flavor of EIP
        /// </summary>
        ab_eip,

        /// <summary>
        /// A Modbus TCP implementation used by many PLCs
        /// </summary>
        modbus_tcp
    }
}