﻿
// <auto-generated />
namespace AzCopy.Contract
{
    public class EnvOption : CommandArgsBase
    {
        /// <summary>
		/// Shows sensitive/secret environment variables.
        /// </summary>
		[CLIArgumentName("show-sensitive")]
		public bool? ShowSensitive { get; set; }

        /// <summary>
		/// Caps the transfer rate, in megabits per second. Moment-by-moment throughput might vary slightly from the cap. If this option is set to zero, or it is omitted, the throughput isn't capped.
        /// </summary>
		[CLIArgumentName("cap-mbps")]
		public float? CapMbps { get; set; }

        /// <summary>
		/// Format of the command's output. The choices include: text, json. The default value is 'text'. (default "text")
        /// </summary>
		[CLIArgumentName("output-type", true)]
		public string OutputType { get; set; }

        /// <summary>
		/// Specifies additional domain suffixes where Azure Active Directory login tokens may be sent.  The default is '*.core.windows.net;*.core.chinacloudapi.cn;*.core.cloudapi.de;*.core.usgovcloudapi.net'. Any listed here are added to the default. For security, you should only put Microsoft Azure domains here. Separate multiple entries with semi-colons.
        /// </summary>
		[CLIArgumentName("trusted-microsoft-suffixes", true)]
		public string TrustedMicrosoftSuffixes { get; set; }

	}
}