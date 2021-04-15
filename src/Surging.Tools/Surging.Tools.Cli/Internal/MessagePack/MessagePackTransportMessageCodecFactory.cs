﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Surging.Tools.Cli.Internal.MessagePack
{
   public sealed class MessagePackTransportMessageCodecFactory : ITransportMessageCodecFactory
    {
        #region Field
        private readonly ITransportMessageEncoder _transportMessageEncoder = new MessagePackTransportMessageEncoder();
        private readonly ITransportMessageDecoder _transportMessageDecoder = new MessagePackTransportMessageDecoder();
        #endregion Field

        #region Implementation of ITransportMessageCodecFactory

        /// <inheritdoc />
        /// <summary>
        /// 获取编码器 
        /// </summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ITransportMessageEncoder GetEncoder()
        {
            return _transportMessageEncoder;
        }

        /// <inheritdoc />
        /// <summary>
        /// 获取解码器 
        /// </summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ITransportMessageDecoder GetDecoder()
        {
            return _transportMessageDecoder;
        }
        #endregion Implementation of ITransportMessageCodecFactory
    }
}
