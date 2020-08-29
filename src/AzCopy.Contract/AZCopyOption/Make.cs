﻿
// <auto-generated />
namespace AzCopy.Contract
{
    public class MakeOption : CommandArgsBase
    {
        /// <summary>
		/// 32   Specifies the maximum size of the share in gigabytes (GiB), 0 means you accept the file service's default quota.
        /// </summary>
		[CLIArgumentName("quota-gb")]
		public uint? QuotaGb { get; set; }

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