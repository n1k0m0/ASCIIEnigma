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
using System;
using static ASCIIEnigma.Constants;
using static ASCIIEnigma.Util;

namespace ASCIIEnigma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //
            // Enigma machines
            //

            Console.WriteLine("Test Enigma 1:");
            TestEnigma1();
            Console.WriteLine();

            Console.WriteLine("Test Enigma Morse:");
            TestMorseEnigma();
            Console.WriteLine();

            Console.WriteLine("Test Enigma 64:");
            Test64Enigma();
            Console.WriteLine();

            Console.WriteLine("Test Enigma ASCII:");
            TestASCIIEnigma();
            Console.WriteLine();            


            //
            // Typex machines
            //

            Console.WriteLine("Test Typex Cyberchef:");
            TestTypexCyberchef();
            Console.WriteLine();

            Console.ReadLine(); //forces the console application to stay open until user presses enter
        }

        /// <summary>
        /// Tests the original Enigma M1
        /// </summary>
        private static void TestEnigma1()
        {
            int[] key = new int[] { 0, 1, 2 }; // A B C

            //create plugboard
            int[][] plugs = new int[3][];
            plugs[0] = new int[] { 0, 1 }; // plug A <-> B
            plugs[1] = new int[] { 2, 3 }; // plug C <-> D
            plugs[2] = new int[] { 4, 5 }; // plug E <-> F

            //create rotors for machine
            Rotor rotor1 = new Rotor(MapTextIntoNumberSpace(Enigma1.RotorI, Alphabets.Alphabet26), Enigma1.RotorINotches, 0);
            Rotor rotor2 = new Rotor(MapTextIntoNumberSpace(Enigma1.RotorII, Alphabets.Alphabet26), Enigma1.RotorIINotches, 0, hasAnomaly:true);
            Rotor rotor3 = new Rotor(MapTextIntoNumberSpace(Enigma1.RotorIII, Alphabets.Alphabet26), Enigma1.RotorIIINotches, 0);        
            Rotor reflector = new Rotor(MapTextIntoNumberSpace(Enigma1.UKWA, Alphabets.Alphabet26), null, 0);

            //create machine
            RotorMachine enigma1 = new RotorMachine(new Rotor[] { rotor1, rotor2, rotor3 }, reflector, new Plugboard(Alphabets.Alphabet26, plugs), Alphabets.Alphabet26)
            {
                //reset machine key
                Key = key
            };

            string text = "HELLOXWORLDXTHISXISXAXTESTXTEXT";

            //encrypt/decrypt and print all to console
            Console.WriteLine(text);
            int[] plaintext = MapTextIntoNumberSpace(text, Alphabets.Alphabet26);
            int[] ciphertext = enigma1.CryptText(plaintext);
            //ciphertext should be: "NRSMMUYWCPHIKQPONAIKRDPUJYFGIMS"
            Console.WriteLine(MapNumbersIntoTextSpace(ciphertext, Alphabets.Alphabet26));
            //reset machine key
            enigma1.Key = key;
            int[] decrypted = enigma1.CryptText(ciphertext);
            Console.WriteLine(MapNumbersIntoTextSpace(decrypted, Alphabets.Alphabet26));
        }        

        /// <summary>
        /// Tests the "Enigma Morse"
        /// </summary>
        private static void TestMorseEnigma()
        {
            int[] key = new int[] { 18, 11, 8, 6 };

            //create rotors for machine
            Rotor rotor1 = new Rotor(MapTextIntoNumberSpace(EnigmaMorse.RotorA, Alphabets.AlphabetM), EnigmaMorse.RotorANotches, 0);
            Rotor rotor2 = new Rotor(MapTextIntoNumberSpace(EnigmaMorse.RotorB, Alphabets.AlphabetM), EnigmaMorse.RotorBNotches, 0, hasAnomaly: true);
            Rotor rotor3 = new Rotor(MapTextIntoNumberSpace(EnigmaMorse.RotorC, Alphabets.AlphabetM), EnigmaMorse.RotorCNotches, 0);
            Rotor rotor4 = new Rotor(MapTextIntoNumberSpace(EnigmaMorse.RotorD, Alphabets.AlphabetM), EnigmaMorse.RotorDNotches, 0);
            Rotor reflectorM = new Rotor(MapTextIntoNumberSpace(EnigmaMorse.Reflector, Alphabets.AlphabetM), null, 0);

            //create machine
            RotorMachine morseEnigma = new RotorMachine(new Rotor[] { rotor1, rotor2, rotor3, rotor4 }, reflectorM, null, Alphabets.AlphabetM)
            {
                //reset machine key
                Key = key
            };

            string text = "HELLO,WORLD,THIS,IS,A,TEST,TEST";
            //encrypt/decrypt and print all to console
            Console.WriteLine(text);
            int[] plaintext = MapTextIntoNumberSpace(text, Alphabets.AlphabetM);
            int[] ciphertext = morseEnigma.CryptText(plaintext);
            //ciphertext should be: "WDTYYI4U84KA6KF1W90ME!ILR8IP.8?"
            Console.WriteLine(MapNumbersIntoTextSpace(ciphertext, Alphabets.AlphabetM));
            //reset machine key
            morseEnigma.Key = key;
            int[] decrypted = morseEnigma.CryptText(ciphertext);
            Console.WriteLine(MapNumbersIntoTextSpace(decrypted, Alphabets.AlphabetM));
        }

        /// <summary>
        /// Tests the "Enigma 64"
        /// </summary>
        private static void Test64Enigma()
        {
            int[] key = new int[] { 12, 3, 8, 4 };

            //create rotors for machine
            Rotor rotor1 = new Rotor(MapTextIntoNumberSpace(Enigma64.RotorF, Alphabets.Alphabet64), Enigma64.RotorFNotches, 0);
            Rotor rotor2 = new Rotor(MapTextIntoNumberSpace(Enigma64.RotorB, Alphabets.Alphabet64), Enigma64.RotorBNotches, 0, hasAnomaly: true);
            Rotor rotor3 = new Rotor(MapTextIntoNumberSpace(Enigma64.RotorE, Alphabets.Alphabet64), Enigma64.RotorENotches, 0);
            Rotor rotor4 = new Rotor(MapTextIntoNumberSpace(Enigma64.RotorD, Alphabets.Alphabet64), Enigma64.RotorDNotches, 0);
            Rotor reflector64 = new Rotor(MapTextIntoNumberSpace(Enigma64.Reflector64, Alphabets.Alphabet64), null, 0);

            //create machine
            RotorMachine enigma64 = new RotorMachine(new Rotor[] { rotor1, rotor2, rotor3, rotor4 }, reflector64, null, Alphabets.Alphabet64)
            {
                //reset machine key
                Key = key
            };

            string text = "Hello,world,this,is,a,test,text";
            //encrypt/decrypt and print all to console
            Console.WriteLine(text);
            int[] plaintext = MapTextIntoNumberSpace(text, Alphabets.Alphabet64);
            int[] ciphertext = enigma64.CryptText(plaintext);
            //ciphertext should be: "VM7Eb7g2Ssm.5DtyBQeVrZkMll81f.."
            Console.WriteLine(MapNumbersIntoTextSpace(ciphertext, Alphabets.Alphabet64));
            //reset machine key
            enigma64.Key = key;
            int[] decrypted = enigma64.CryptText(ciphertext);
            Console.WriteLine(MapNumbersIntoTextSpace(decrypted, Alphabets.Alphabet64));
        }

        /// <summary>
        /// Tests the "Enigma ASCII"
        /// </summary>
        private static void TestASCIIEnigma()
        {
            int[] key = new int[] { 1, 2, 3 };

            //create rotors for machine
            Rotor rotor1 = new Rotor(EnigmaASCII.RotorA, EnigmaASCII.RotorANotches, 0);
            Rotor rotor2 = new Rotor(EnigmaASCII.RotorB, EnigmaASCII.RotorBNotches, 0);
            Rotor rotor3 = new Rotor(EnigmaASCII.RotorC, EnigmaASCII.RotorCNotches, 0);
            Rotor reflectorASCII = new Rotor(EnigmaASCII.Reflector, null, 0);

            //Create plugboard (no plugs set)
            Plugboard plugboard = new Plugboard(Alphabets.AlphabetASCII, new int[0][]);

            //create machine
            RotorMachine asciiEnigma = new RotorMachine(new Rotor[] { rotor1, rotor2, rotor3 }, reflectorASCII, plugboard, null)
            {
                //reset machine key
                Key = key
            };

            string text = "Hello world!This is a test text";
            //encrypt/decrypt and print all to console
            Console.WriteLine(text);
            int[] plaintext = text.ToIntArray();
            int[] ciphertext = asciiEnigma.CryptText(plaintext);
            //ciphertext should be: "166, 16, 20, 227, 193, 134, 246, 247, 187, 225, 86, 40, 106, 32, 208, 201, 117, 216, 9, 105, 67, 201, 200, 38, 112, 56, 13, 140, 38, 91, 85"
            Console.WriteLine(ciphertext.ToIntString());
            //reset machine key
            asciiEnigma.Key = key;
            int[] decrypted = asciiEnigma.CryptText(ciphertext);
            Console.WriteLine(decrypted.GetString());
        }

        /// <summary>
        /// Tests the original Enigma M1
        /// </summary>
        private static void TestTypexCyberchef()
        {
            int[] key = new int[] { 0, 0, 0, 0, 0, 0 }; // A A A A A 
           
            //create rotors for machine
            Stator entry = new Stator(MapTextIntoNumberSpace(Typex_Cyberchef.Entry, Alphabets.Alphabet26), null, 0);
            Stator stator1 = new Stator(MapTextIntoNumberSpace(Typex_Cyberchef.Rotor5, Alphabets.Alphabet26), null, 0);
            Stator stator2 = new Stator(MapTextIntoNumberSpace(Typex_Cyberchef.Rotor4, Alphabets.Alphabet26), null, 0);
            Rotor rotor1 = new Rotor(MapTextIntoNumberSpace(Typex_Cyberchef.Rotor3, Alphabets.Alphabet26), Typex_Cyberchef.Notches, 0);
            Rotor rotor2 = new Rotor(MapTextIntoNumberSpace(Typex_Cyberchef.Rotor2, Alphabets.Alphabet26), Typex_Cyberchef.Notches, 0, hasAnomaly: true);
            Rotor rotor3 = new Rotor(MapTextIntoNumberSpace(Typex_Cyberchef.Rotor1, Alphabets.Alphabet26), Typex_Cyberchef.Notches, 0);
            Rotor reflector = new Rotor(MapTextIntoNumberSpace(Typex_Cyberchef.Reflector, Alphabets.Alphabet26), null, 0);

            Rotor[] rotors = new Rotor[] { entry, stator1, stator2, rotor1, rotor2, rotor3 };

            //create machine
            RotorMachine typex = new RotorMachine(rotors, reflector, null, Alphabets.Alphabet26)
            {
                //reset machine key
                Key = key
            };

            string text = "HELLOXWORLDXTHISXISXAXTESTXTEXT";

            //encrypt/decrypt and print all to console
            Console.WriteLine(text);
            int[] plaintext = MapTextIntoNumberSpace(text, Alphabets.Alphabet26);
            int[] ciphertext = typex.CryptText(plaintext);
            //ciphertext should be: PDEBFQXSVRWJCZZFSJYWELDTTMFPPVA
            Console.WriteLine(MapNumbersIntoTextSpace(ciphertext, Alphabets.Alphabet26));
            //reset machine key
            typex.Key = key;
            int[] decrypted = typex.CryptText(ciphertext);
            Console.WriteLine(MapNumbersIntoTextSpace(decrypted, Alphabets.Alphabet26));
        }
    }
}
