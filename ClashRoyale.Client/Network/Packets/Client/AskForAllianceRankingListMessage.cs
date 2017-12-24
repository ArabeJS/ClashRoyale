﻿namespace ClashRoyale.Client.Network.Packets.Client
{
    using ClashRoyale.Client.Logic;
    using ClashRoyale.Enums;
    using ClashRoyale.Maths;

    internal class AskForAllianceRankingListMessage : Message
    {
        /// <summary>
        /// The type of this message.
        /// </summary>
        internal override short Type
        {
            get
            {
                return 14171;
            }
        }

        /// <summary>
        /// The service node of this message.
        /// </summary>
        internal override Node ServiceNode
        {
            get
            {
                return Node.Scoring;
            }
        }

        private LogicLong AllianceId;
        private bool IsLocal;

        /// <summary>
        /// Initializes a new instance of the <see cref="AskForAllianceRankingListMessage"/> class.
        /// </summary>
        /// <param name="Bot">The bot.</param>
        public AskForAllianceRankingListMessage(Bot Bot, bool Local) : base(Bot)
        {
            this.IsLocal = Local;
        }

        /// <summary>
        /// Decodes this instance.
        /// </summary>
        internal override void Decode()
        {
            this.IsLocal = this.Stream.ReadBoolean();

            if (this.Stream.ReadBoolean())
            {
                this.AllianceId = this.Stream.ReadLong();
            }
        }

        /// <summary>
        /// Encodes this instance.
        /// </summary>
        internal override void Encode()
        {
            this.Stream.WriteBoolean(this.IsLocal);
            this.Stream.WriteBoolean(!this.AllianceId.IsZero);

            if (!this.AllianceId.IsZero)
            {
                this.Stream.WriteLong(this.AllianceId);
            }
        }
    }
}