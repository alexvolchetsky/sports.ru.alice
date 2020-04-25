﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Yandex.Alice.Sdk.Models
{
    public class AliceImageResponseModel
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }
        [JsonPropertyName("tts")]
        public string Tts { get; set; }
        [JsonPropertyName("card")]
        public AliceImageCardModel Card { get; set; }
        [JsonPropertyName("buttons")]
        public AliceButtonModel[] Buttons { get; set; }
        [JsonPropertyName("end_session")]
        public bool EndSession { get; set; }
    }
}