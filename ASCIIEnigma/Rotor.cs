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
    /// A single Rotor of the Rotor Machine
    /// A rotor can encrypt and decrypt letters
    /// </summary>
    public class Rotor
    {
        private readonly int[] _rotor;
        private readonly int[] _inverseRotor;
        private readonly int[] _notches;
        private int _rotation;

        /// <summary>
        /// Creates a rotor with the given parameters
        /// </summary>
        /// <param name="rotor"></param>
        /// <param name="notches"></param>
        /// <param name="rotation"></param>
        public Rotor(int[] rotor, int[] notches, int rotation)
        {
            _rotor = rotor;
            _notches = notches;
            _inverseRotor = GenerateInverseRotor(rotor);
            Rotation = Mod(rotation, _rotor.Length);
        }

        /// <summary>
        /// Current rotation of this rotor
        /// </summary>
        public int Rotation
        {
            get => _rotation;
            set => _rotation = Mod(value, _rotor.Length);
        }

        /// <summary>
        /// Creates the inverse rotor for decryption
        /// </summary>
        /// <param name="rotor"></param>
        /// <returns></returns>
        private int[] GenerateInverseRotor(int[] rotor)
        {
            int[] inverseRotor = new int[rotor.Length];
            for (int i = 0; i < rotor.Length; i++)
            {
                inverseRotor[i] = rotor.IndexOf(i);
            }
            return inverseRotor;
        }

        /// <summary>
        /// Move rotor one step
        /// </summary>
        public void Step()
        {
            Rotation = Mod(Rotation + 1, _rotor.Length);
        }

        /// <summary>
        /// Returns true, if rotor is currently at a notch position
        /// </summary>
        /// <returns></returns>
        public bool IsAtNotchPosition()
        {
            return _notches.Contains(Rotation);
        }

        /// <summary>
        /// Encrypts a single letter
        /// </summary>
        /// <param name="plaintextLetter"></param>
        /// <returns></returns>
        public int Encrypt(int plaintextLetter)
        {
            return Mod(_rotor[Mod(plaintextLetter + Rotation, _rotor.Length)] - Rotation, _rotor.Length);
        }

        /// <summary>
        /// Decrypts a single letter
        /// </summary>
        /// <param name="ciphertextLetter"></param>
        /// <returns></returns>
        public int Decrypt(int ciphertextLetter)
        {
            return Mod(_inverseRotor[Mod(ciphertextLetter + Rotation, _inverseRotor.Length)] - Rotation, _inverseRotor.Length);
        }
    }
}
