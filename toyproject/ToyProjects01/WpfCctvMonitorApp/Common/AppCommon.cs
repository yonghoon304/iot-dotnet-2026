using System;
using System.Collections.Generic;
using System.Text;

namespace WpfCctvMonitorApp.Common
{
    internal class AppCommon
    {
        // 구버전 서비스 URL
        public const string ApiUrl = "https://openapi.its.go.kr:9443/cctvInfo";

        public static string ApiType { get; set; } = "cctvInfo";

        public static string ItsOpenApiKey { get; set; } = "OPENAPI_KEY";

        public const string HighwayType = "ex";

        public static string GetType { get; set; } = "json";

        public static string StreamType { get; set; } = "1";

        public static double MinX { get; set; } = 33.100000;
        public static double MaxY { get; set; } = 39.000000;
        public static double MInX { get; set; } = 126.000000;
        public static double MaxX { get; set; } = 129.660000;

        public static string BuildGetQueryString(string type)
        {
            return "";
        }
    }
}
