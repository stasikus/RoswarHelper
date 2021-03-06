﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoswarHelper
{
    class LoadList
    {
        public static List<string> accsList = new List<string>();
        public static Dictionary<string, string> userDictionary = new Dictionary<string, string>();

        public static void loadUsersList(string path)
        {
            accsList = new List<string>();
            using (var sr = new StreamReader(path))
            {
                while (sr.Peek() >= 0)
                {
                    accsList.Add(sr.ReadLine());
                    if (accsList.Contains(""))
                    {
                        accsList = accsList.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();
                    }
                }
            }
            splitList();
        }


        public static void splitList()
        {
            try
            {
                for (int i = 0; i < accsList.Count; i++)
                {
                    userDictionary.Add(accsList[i].Substring(0, accsList[i].IndexOf(",")), accsList[i].Substring(accsList[i].IndexOf(",") + 1));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Файл в неверном формате");
                accsList.Clear();
            }

        }

    }
}
