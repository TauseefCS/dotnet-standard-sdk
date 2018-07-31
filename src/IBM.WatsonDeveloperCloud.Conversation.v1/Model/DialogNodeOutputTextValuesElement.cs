/**
* Copyright 2018 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using Newtonsoft.Json;

namespace IBM.WatsonDeveloperCloud.Conversation.v1.Model
{
    /// <summary>
    /// DialogNodeOutputTextValuesElement.
    /// </summary>
    public class DialogNodeOutputTextValuesElement : BaseModel
    {
        /// <summary>
        /// The text of a response. This can include newline characters (`
        /// `), Markdown tagging, or other special characters, if supported by the channel.
        /// </summary>
        /// <value>
        /// The text of a response. This can include newline characters (`
        /// `), Markdown tagging, or other special characters, if supported by the channel.
        /// </value>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }
    }

}
