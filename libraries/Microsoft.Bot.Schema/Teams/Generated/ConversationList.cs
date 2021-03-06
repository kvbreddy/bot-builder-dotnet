// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bot.Schema.Teams
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// List of channels under a team
    /// </summary>
    public partial class ConversationList
    {
        /// <summary>
        /// Initializes a new instance of the ConversationList class.
        /// </summary>
        public ConversationList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConversationList class.
        /// </summary>
        public ConversationList(IList<ChannelInfo> conversations = default(IList<ChannelInfo>))
        {
            Conversations = conversations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "conversations")]
        public IList<ChannelInfo> Conversations { get; set; }

    }
}
