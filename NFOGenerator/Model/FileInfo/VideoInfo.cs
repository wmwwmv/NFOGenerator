﻿/// Copyright 2017 Jevenski C. Woodsmann. All Rights Reserved
/// 
/// Licensed under the Apache License, Version 2.0 (the "License");
/// you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at
/// 
///     http://www.apache.org/licenses/LICENSE-2.0
/// 
/// Unless required by applicable law or agreed to in writing, software
/// distributed under the License is distributed on an "AS IS" BASIS,
/// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
/// See the License for the specific language governing permissions and
/// limitations under the License.

using System;
using System.Collections.Generic;
using System.Text;

namespace NFOGenerator.Model.FileInfo
{
    public class VideoInfo
    {
        public string width { get; set; }
        public string height { get; set; }
        public string displayAR { get; set; }
        public string framerate { get; set; }
        public string bitrate { get; set; }
        public string codec { get; set; }
    }
}
