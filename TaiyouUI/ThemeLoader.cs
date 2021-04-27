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
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiyouUI
{
    public class ThemeLoader
    {
        public static Dictionary<string, Color> ThemeData = new Dictionary<string, Color>();
        public static string CurrentThemeFile = "";
        public static bool ThemeLoaded = false;

        public static Color GetThemeData(string Key)
        {
            if (!ThemeData.ContainsKey(Key))
            {
                throw new KeyNotFoundException("Cannot find key '" + Key + "' at theme '" + CurrentThemeFile + "'");
            }

            return ThemeData[Key];
        }

        public static void LoadDictData(string ThemeName, BackgroundWorker bgWorker = null)
        {
            ThemeData.Clear();
            CurrentThemeFile = Environment.CurrentDirectory + "\\themes\\" + ThemeName + ".txt";

            //DicData should be located at (./lang_bank/en-us)
            if (!File.Exists(CurrentThemeFile))
            {
                Console.WriteLine("Cannot locate theme file.");
                Console.WriteLine(CurrentThemeFile);
                throw new FileNotFoundException("Cannot locate theme file.");
            }

            string[] FileRead = File.ReadAllLines(CurrentThemeFile);


            int Wax = -1;
            foreach (string Line in FileRead)
            {
                Wax++;
                if (Line.StartsWith("#"))
                {
                    continue;
                }
                if (Line.Length < 10) { continue; }
                string[] LineSplit = Line.Split(';');
                string Key = "";
                string Data = "";

                foreach (string LineSplitData in LineSplit)
                {
                    if (Key == "")
                    {
                        Key = LineSplitData;
                        continue;
                    }
                    Data = LineSplitData.Replace("%n", "\n");
                }


                try
                {
                    try
                    {
                        string[] ColorComponentsSplit = Data.Split(',');
                        int ColorA = Convert.ToInt32(ColorComponentsSplit[0]);
                        int ColorR = Convert.ToInt32(ColorComponentsSplit[1]);
                        int ColorG = Convert.ToInt32(ColorComponentsSplit[2]);
                        int ColorB = Convert.ToInt32(ColorComponentsSplit[3]);

                        ThemeData.Add(Key, Color.FromArgb(ColorA, ColorR, ColorG, ColorB));

                    }
                    catch (IndexOutOfRangeException) { Console.WriteLine("Error while parsing theme data for {" + Key + "}."); continue; }
                }
                catch (ArgumentException) { Console.WriteLine("Duplicate entry found, ignoring..."); continue; }
                Console.WriteLine("ThemeLoader: Added '" + Key + "' with value '" + Data.Replace(" ", "") + "'");

                if (bgWorker != null)
                {
                    var progress = (int)Math.Ceiling(((float)Wax / FileRead.Length) * 100);
                    bgWorker.ReportProgress(progress);
                }

            }

            // Set ThemeLoaded Variable
            ThemeLoaded = true;

        }

    }

}
