﻿using System;

namespace UOStudio.Client.Core
{
    public class Project
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ClientVersion { get; set; }
    }
}
