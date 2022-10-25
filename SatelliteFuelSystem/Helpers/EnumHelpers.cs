﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatelliteFuelSystem.Helpers
{
    public static class EnumHelpers
    {
        public static List<string> GetDescriptions(Type type)
        {
            var descs = new List<string>();
            var names = Enum.GetNames(type);
            foreach (var name in names)
            {
                var field = type.GetField(name);
                var fds = field.GetCustomAttributes(typeof(DescriptionAttribute), true);
                foreach (DescriptionAttribute fd in fds)
                {
                    descs.Add(fd.Description);
                }
            }
            return descs;
        }
    }
}
