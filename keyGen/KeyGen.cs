using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyGen {
    public static class KeyGen {


        public const String values = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static Random r = new Random();

        public static String generarKey() {
            String ret = "";
            int i = 16;
            while (i > 0) {
                if (i != 16 && i % 4 == 0) {
                    ret += "-";
                }
                int index = r.Next(0, values.Length);
                ret += values[index];
                i--;
            }
            return ret;
        }
        public static List<String> generarKey(int i) {
            List<String> ret = new List<string>();
            int j = 16;
            String key = "";
            while (i > 0) {
                while (j > 0) {
                    if (j != 16 && j % 4 == 0) {
                        key += "-";
                    }
                    int index = r.Next(0, values.Length);
                    key += values[index];
                    j--;
                }
                ret.Add(key);
                i--;
            }
            return ret;
        }
    }
}
