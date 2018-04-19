﻿#region License
// 
//     MIT License
//
//     CoiniumServ - Crypto Currency Mining Pool Server Software
//     Copyright (C) 2013 - 2017, CoiniumServ Project
//     Hüseyin Uslu, shalafiraistlin at gmail dot com
//     https://github.com/bonesoul/CoiniumServ
// 
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the "Software"), to deal
//     in the Software without restriction, including without limitation the rights
//     to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//     copies of the Software, and to permit persons to whom the Software is
//     furnished to do so, subject to the following conditions:
//     
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
//     
//     THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//     IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//     AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//     LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//     OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//     SOFTWARE.
// 
#endregion

using System;
using System.Collections.Generic;
using CoiniumServ.Pools;
using CoiniumServ.Server.Web.Service;
using CoiniumServ.Utils.Repository;
using Newtonsoft.Json;

namespace CoiniumServ.Algorithms
{
    [JsonObject(MemberSerialization.OptIn)]
    public interface IHashAlgorithmStatistics : IRepository<IPool>, IJsonService
    {
        /// <summary>
        /// Algorithm name.
        /// </summary>
        string Name { get; }

        [JsonProperty("miners")]
        Int32 MinerCount { get; }

        [JsonProperty("hashrate")]
        double Hashrate { get; }

        /// <summary>
        /// Assigns pools that runs on the algorithm.
        /// </summary>
        /// <param name="pools"></param>
        void AssignPools(IEnumerable<IPool> pools);
    }
}