﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.SystemCenter.Orchestrator.Integration.Administration
{
    public class GuidUtilities
    {
        public static string RemoveBracesFromGuid(string guid)
        {
            return guid.Replace("{", "").Replace("}", "");
        }

        public static string AddBracesToGuid(string guid)
        {
            if (!guid.Contains("{"))
            {
                return "{" + guid + "}";
            }
            return guid;
        }

    }
}
