/*
   Copyright 2022 Nils Kopal, CrypTool project

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
using static ASCIIEnigma.Util;

namespace ASCIIEnigma
{
    /// <summary>
    /// Plugboard of the Rotor Machine
    /// Replaces "plugged" letters, e.g. A <-> B, if A is plugged to B
    /// </summary>
    public class Plugboard
    {
        private readonly int[] _plugs;

        /// <summary>
        /// Creates a Plugboard with given plugs
        /// </summary>
        /// <param name="alphabet"></param>
        /// <param name="plugs"></param>
        public Plugboard(string alphabet, int[][] plugs)
        {
            _plugs = MapTextIntoNumberSpace(alphabet, alphabet);
            foreach (int[] plug in plugs)
            {
                _plugs[plug[0]] = plug[1];
                _plugs[plug[1]] = plug[0];
            }
        }

        public Plugboard(int[] alphabet, int[][] plugs)
        {
            _plugs = alphabet;
            foreach (int[] plug in plugs)
            {
                _plugs[plug[0]] = plug[1];
                _plugs[plug[1]] = plug[0];
            }
        }

        /// <summary>
        /// En- or decrypts the given letter
        /// </summary>
        /// <param name="letter"></param>
        /// <returns></returns>
        public int Crypt(int letter)
        {
            return _plugs[letter];
        }

    }
}
