﻿namespace ClashRoyale.Server.Network.Packets.Server
{
    using ClashRoyale.Enums;
    using ClashRoyale.Extensions.Helper;
    using ClashRoyale.Logic;
    using ClashRoyale.Messages;

    internal class SectorStateMessage : Message
    {
        /// <summary>
        /// Gets the type of this message.
        /// </summary>
        public override short Type
        {
            get
            {
                return 21873;
            }
        }

        /// <summary>
        /// Gets the service node of this message.
        /// </summary>
        public override Node ServiceNode
        {
            get
            {
                return Node.Sector;
            }
        }

        private readonly byte[] FullUpdate;

        /// <summary>
        /// Initializes a new instance of the <see cref="SectorStateMessage"/> class.
        /// </summary>
        /// <param name="Device">The device.</param>
        /// <param name="Update">The update.</param>
        public SectorStateMessage(Device Device, byte[] Update) : base(Device)
        {
            this.FullUpdate = Update;
        }

        /// <summary>
        /// Encodes this instance.
        /// </summary>
        public override void Encode()
        {
            this.Stream.AddRange(ZLibHelper.CompressCompressableByteArray(this.FullUpdate));
        }
    }
}