﻿namespace ClashRoyale.Client.Network.Packets.Server
{
    using ClashRoyale.Client.Logic;
    using ClashRoyale.Enums;
    using ClashRoyale.Extensions;

    internal class KeepAliveOkMessage : Message
    {
        /// <summary>
        /// The type of this message.
        /// </summary>
        internal override short Type
        {
            get
            {
                return 24135;
            }
        }

        /// <summary>
        /// The service node of this message.
        /// </summary>
        internal override Node ServiceNode
        {
            get
            {
                return Node.Account;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeepAliveOkMessage"/> class.
        /// </summary>
        /// <param name="Bot">The bot.</param>
        /// <param name="Stream">The stream.</param>
        public KeepAliveOkMessage(Bot Bot, ByteStream Stream) : base(Bot, Stream)
        {
            // KeepAliveOkMessage.
        }
    }
}