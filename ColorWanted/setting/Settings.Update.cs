﻿
using System;

namespace ColorWanted.setting
{
    partial class Settings
    {
        public static class Update
        {
            private const string section = "update";
            private static void Set(string key, string value)
            {
                SetValue(section, key, value);
            }

            private static string Get(string key)
            {
                return GetValue(section, key);
            }

            /// <summary>
            /// 要忽略的版本
            /// </summary>
            public static string IgnoreVersion
            {
                get { return Get("ignoreversion"); }
                set
                {
                    Set("ignoreversion", value);
                }
            }

            /// <summary>
            /// 是否在启动时检查更新
            /// </summary>
            public static bool CheckOnStartup
            {
                get { return Get("checkonstartup") != "0"; }
                set
                {
                    Set("checkonstartup", value ? "1" : "0");
                }
            }

            /// <summary>
            /// 最后一次检查更新的日期
            /// </summary>
            public static DateTime LastUpdate
            {
                get
                {
                    DateTime date;
                    if (!DateTime.TryParse(Get("lastupdate"), out date))
                    {
                        date = DateTime.MinValue;
                    }
                    return date;
                }
                set
                {
                    Set("lastupdate", value.ToString("yyyy-MM-dd"));
                }
            }
        }
    }
}