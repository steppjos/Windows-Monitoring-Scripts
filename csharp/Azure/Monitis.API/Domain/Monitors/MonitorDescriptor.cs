﻿using System;

namespace Monitis.API.Domain.Monitors
{
    /// <summary>
    /// Class reprsents info about Monitor configuration
    /// </summary>
    public class MonitorDescriptor
    {
        /// <summary>
        /// Monitor name
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Tag formonitor
        /// </summary>
        public String Tag { get; set; }

        /// <summary>
        /// Monitor type
        /// </summary>
        public String Type { get; set; }

        /// <summary>
        /// All monitors parameters
        /// </summary>
        public ResultParameterDescriptor[] ResultParams { get; set; }

        public Func<Double,String> Convert { get; set; }
    }
}