/*
   Copyright 2021 Aragubas/Paulo Otávio de Lima

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License. 
  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TaiyouUI
{
    public static class Version
    {
        static DateTime BuildDate = new DateTime(2000, 1, 1);

        /// <summary>
        /// Get version without Build Number
        /// </summary>
        /// <returns></returns>
        public static string GetVersion()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version.Major + "." + Assembly.GetExecutingAssembly().GetName().Version.Minor;


            return version.ToString();
        }

        /// <summary>
        /// Get Version with Build Number
        /// </summary>
        /// <returns></returns>
        public static string GetVersionWithBuild()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;

            return version.ToString();
        }

        /// <summary>
        /// Get Build Date of TaiyouUI
        /// </summary>
        /// <returns></returns>
        public static string GetBuildDate()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;

            var buildDate = BuildDate.AddDays(version.Build).AddSeconds(version.Revision * 2);

            return buildDate.ToString();

        }

        /// <summary>
        /// Get the BuildNumber of TaiyouUI
        /// </summary>
        /// <returns></returns>
        public static string GetBuildNumber()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version.Revision;

            return version.ToString();

        }


    }
}
