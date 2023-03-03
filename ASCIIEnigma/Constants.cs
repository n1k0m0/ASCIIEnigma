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

namespace ASCIIEnigma
{
    /// <summary>
    /// Constants for various rotor encryption machines
    /// </summary>
    public static class Constants
    {
        ///Alphabets for the different Enigma models
        public static class Alphabets
        {
            public const string Alphabet26 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            public const string AlphabetM = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789.,!?";
            public const string Alphabet64 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789.,";

            //since a string can not contain all ASCII values, the alphabet for the ASCII enigma is an int array:
            public static readonly int[] AlphabetASCII = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 182, 183, 184, 185, 186, 187, 188, 189, 190, 191, 192, 193, 194, 195, 196, 197, 198, 199, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255 };
        }
        ///Enigma 1:
        ///This Enigma is the classical real Enigma with the original rotors and reflectors
        public static class Enigma1
        {
            public const string RotorI = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
            public const string RotorII = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
            public const string RotorIII = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
            public const string RotorIV = "ESOVPZJAYQUIRHXLNFTGKDCMWB";
            public const string RotorV = "VZBRGITYUPSDNHLXAWMJQOFECK";
            public const string RotorVI = "JPGVOUMFYQBENHZRDKASXLICTW";
            public const string RotorVII = "NZJHGRCXMYSWBOUFAIVLPEKQDT";
            public const string RotorVIII = "FKQHTLXOCBJSPDZRAMEWNIUYGV";

            public static readonly int[] RotorINotches = new int[] { 17 };   // Q
            public static readonly int[] RotorIINotches = new int[] { 5 };   // E
            public static readonly int[] RotorIIINotches = new int[] { 22 }; // V
            public static readonly int[] RotorIVNotches = new int[] { 10 };  // J
            public static readonly int[] RotorVNotches = new int[] { 0 };    // Z
            public static readonly int[] RotorVINotches = new int[] { 0, 13 };   // Z, M
            public static readonly int[] RotorVIINotches = new int[] { 0, 13 };  // Z, M
            public static readonly int[] RotorVIIINotches = new int[] { 0, 13 }; // Z, M

            public const string UKWA = "EJMZALYXVBWFCRQUONTSPIKHGD"; // UKW A
            public const string UKWB = "YRUHQSLDPXNGOKMIEBFZCWVJAT"; // UKW B
            public const string UKWC = "FVPJIAOYEDRZXWGCTKUQSBNMHL"; // UKW C
        }

        ///40 characters "morse" Enigma:
        ///This "new" Enigma allows the encryption of the standard uppercase alphabet + digits + some special characters
        ///All the characters are available in the morse alphabet, thus, can be sent using morse code
        public static class EnigmaMorse
        {
            public const string RotorA = "FIV?07J1Y9WHA64LOGC3NQ.X8TSK!ZBDPM,RUE25";
            public const string RotorB = "T,PZG!QUMJCEV?2LXIWF8DN509H6B.4AK7Y3SR1O";
            public const string RotorC = "ICUQPMBAY52Z79TSW6KFDHX,J43R?L08GVE1NO.!";
            public const string RotorD = "T2P,C!X.U5Q0D38NOZAK?41697ISJHLVEWGRMBYF";
            public const string RotorE = "U4MNYDK31P9VOHI7W,TGBERQ0?C58LXS2!Z6F.JA";
            public const string RotorF = "2GV7CNQ3,ZR69.UH14MO0IT!WLYAJD?FEPXKBS85";

            public static readonly int[] RotorANotches = new int[] { 16, 36 };
            public static readonly int[] RotorBNotches = new int[] { 1, 21 };
            public static readonly int[] RotorCNotches = new int[] { 7, 27 };
            public static readonly int[] RotorDNotches = new int[] { 12, 32 };
            public static readonly int[] RotorENotches = new int[] { 5, 25 };
            public static readonly int[] RotorFNotches = new int[] { 19, 39 };

            public const string Reflector = "?!,.9876543210ZYXWVUTSRQPONMLKJIHGFEDCBA";
        }

        ///64 character Enigma:
        ///This "new" Enigma allows the encryption of uppercase and lowercase letters, digits, and some special characters
        public static class Enigma64
        {
            public const string RotorA = "Iklmc,oLXWf3JPGeBvErjza64xZh1NtFMq8sCwT29b0HYigO.VdSyQU5KRADpn7u";
            public const string RotorB = "WlZKc6agurMRSiVvhQsbo,7YdPHJwmnjXp9GeLqt4zTB8.AFENyI512OxDC0kf3U";
            public const string RotorC = "XYCWFD1QT3ItR0niGlvBdUVqyJrHwep4L5johMm978ksbc.Sfag,Zx2ANPEzuO6K";
            public const string RotorD = "PidQEvHIahKTNj0cMrZRXnFsWmCxo7p6w4DlGq8u1tfJe,L3gVzb5y.2kU9ASOBY";
            public const string RotorE = "Trw1pJPnc97xWCy.bRt3fkXjL8vS4auHYo5AMq2NBUeV0Omz6ZilgI,hFDsdQKEG";
            public const string RotorF = "AO5bFVMzWrQJwv3.Guc2tPRKXEaDkZdflL0jg61eo4ICNBS7qpny,sTUhY9mixH8";

            public static readonly int[] RotorANotches = new int[] { 16, 48 };
            public static readonly int[] RotorBNotches = new int[] { 1, 33 };
            public static readonly int[] RotorCNotches = new int[] { 7, 39 };
            public static readonly int[] RotorDNotches = new int[] { 12, 34 };
            public static readonly int[] RotorENotches = new int[] { 5, 37 };
            public static readonly int[] RotorFNotches = new int[] { 19, 51 };

            public const string Reflector64 = ",.9876543210zyxwvutsrqponmlkjihgfedcbaZYXWVUTSRQPONMLKJIHGFEDCBA";
        }

        ///ASCII Enigma:
        ///This "new" Enigma allows the encryption of all ASCII characters
        public static class EnigmaASCII
        {
            public static readonly int[] RotorA = new int[] { 9, 175, 56, 16, 5, 201, 122, 121, 163, 190, 126, 183, 194, 161, 204, 197, 220, 38, 166, 68, 13, 128, 40, 144, 53, 90, 88, 61, 41, 63, 4, 149, 67, 109, 132, 195, 0, 80, 79, 94, 242, 97, 181, 225, 217, 235, 34, 54, 209, 140, 14, 99, 185, 135, 77, 243, 107, 129, 24, 87, 231, 117, 252, 52, 71, 240, 100, 83, 103, 18, 184, 48, 214, 51, 10, 25, 42, 151, 39, 137, 222, 32, 211, 179, 116, 189, 150, 246, 93, 198, 172, 215, 199, 223, 155, 36, 139, 152, 165, 6, 233, 75, 221, 143, 171, 168, 219, 8, 193, 74, 29, 26, 123, 110, 147, 81, 22, 196, 72, 105, 23, 21, 145, 60, 84, 127, 157, 248, 160, 130, 17, 118, 124, 106, 45, 208, 59, 134, 226, 141, 86, 247, 85, 125, 114, 210, 142, 249, 108, 119, 227, 167, 232, 55, 133, 30, 115, 206, 164, 73, 202, 82, 156, 31, 66, 76, 169, 7, 255, 188, 236, 57, 154, 224, 237, 146, 91, 28, 136, 92, 253, 35, 64, 44, 173, 112, 98, 27, 216, 120, 200, 47, 104, 89, 12, 162, 212, 1, 178, 2, 20, 58, 229, 250, 11, 78, 15, 102, 69, 207, 205, 228, 159, 192, 37, 46, 33, 158, 245, 96, 170, 131, 113, 203, 234, 230, 213, 174, 111, 70, 238, 3, 50, 239, 176, 187, 182, 148, 180, 65, 49, 138, 191, 254, 62, 101, 218, 177, 251, 43, 186, 153, 19, 241, 95, 244 };
            public static readonly int[] RotorB = new int[] { 27, 19, 173, 81, 73, 92, 108, 144, 46, 72, 35, 196, 47, 167, 179, 14, 74, 16, 120, 160, 157, 223, 9, 252, 68, 165, 139, 79, 226, 25, 45, 181, 217, 142, 38, 176, 124, 69, 209, 201, 43, 146, 80, 213, 33, 11, 148, 135, 220, 137, 5, 166, 28, 39, 205, 194, 152, 163, 40, 147, 67, 219, 172, 240, 0, 107, 140, 225, 54, 56, 37, 97, 15, 100, 51, 95, 249, 207, 242, 75, 246, 52, 221, 127, 245, 238, 48, 129, 229, 230, 91, 90, 34, 65, 13, 208, 7, 244, 189, 158, 231, 53, 253, 183, 70, 116, 94, 170, 145, 228, 200, 8, 188, 184, 191, 132, 168, 89, 202, 119, 105, 83, 251, 164, 110, 98, 85, 117, 197, 248, 206, 41, 59, 118, 177, 17, 149, 185, 239, 154, 58, 78, 187, 36, 214, 49, 99, 102, 44, 82, 86, 203, 241, 227, 60, 150, 182, 180, 3, 169, 222, 243, 210, 175, 57, 18, 224, 138, 123, 76, 216, 174, 233, 66, 71, 178, 109, 250, 204, 55, 156, 114, 113, 195, 193, 126, 211, 186, 199, 2, 50, 77, 215, 20, 29, 155, 115, 10, 161, 218, 12, 192, 22, 125, 103, 24, 31, 112, 255, 26, 106, 136, 143, 104, 96, 84, 234, 63, 42, 4, 88, 130, 162, 21, 232, 151, 171, 93, 128, 23, 159, 32, 190, 64, 122, 1, 198, 61, 111, 30, 134, 254, 62, 141, 153, 133, 121, 101, 247, 131, 87, 237, 6, 236, 235, 212 };
            public static readonly int[] RotorC = new int[] { 251, 227, 255, 111, 201, 142, 9, 18, 185, 108, 8, 70, 224, 214, 79, 137, 236, 123, 15, 234, 81, 120, 172, 89, 131, 95, 26, 114, 252, 97, 165, 46, 187, 25, 219, 33, 177, 40, 207, 42, 156, 38, 21, 109, 170, 90, 160, 119, 31, 4, 243, 37, 52, 91, 100, 129, 180, 58, 168, 28, 140, 148, 77, 193, 197, 212, 124, 76, 126, 220, 66, 195, 125, 92, 35, 107, 169, 0, 54, 78, 173, 161, 216, 245, 213, 150, 75, 88, 215, 99, 184, 194, 127, 230, 181, 61, 134, 231, 166, 159, 189, 1, 226, 55, 171, 116, 101, 106, 24, 203, 132, 59, 39, 82, 222, 200, 44, 5, 32, 105, 225, 36, 241, 208, 175, 164, 47, 29, 6, 254, 152, 53, 85, 30, 179, 49, 248, 244, 2, 133, 250, 155, 135, 209, 34, 162, 22, 228, 20, 128, 253, 12, 153, 138, 23, 246, 3, 237, 218, 104, 94, 43, 206, 145, 69, 229, 146, 48, 41, 149, 110, 13, 178, 80, 154, 139, 11, 16, 235, 121, 182, 186, 56, 57, 239, 249, 233, 86, 183, 144, 163, 221, 174, 198, 63, 238, 210, 196, 136, 115, 122, 240, 242, 117, 10, 211, 98, 93, 147, 190, 217, 188, 223, 84, 192, 130, 118, 158, 27, 157, 83, 73, 247, 17, 87, 62, 103, 19, 65, 167, 71, 68, 113, 232, 141, 7, 143, 74, 96, 50, 112, 191, 14, 199, 51, 45, 60, 151, 204, 72, 176, 67, 205, 202, 102, 64 };
            public static readonly int[] RotorD = new int[] { 60, 227, 217, 238, 235, 207, 72, 214, 84, 57, 167, 48, 141, 14, 1, 188, 40, 76, 10, 22, 255, 23, 16, 55, 93, 210, 112, 97, 109, 127, 17, 128, 134, 242, 52, 29, 59, 26, 194, 70, 225, 106, 142, 152, 24, 234, 117, 228, 165, 196, 69, 161, 92, 101, 99, 192, 31, 140, 198, 126, 94, 176, 159, 67, 129, 206, 104, 13, 89, 88, 53, 162, 137, 11, 158, 178, 250, 0, 240, 175, 108, 245, 28, 122, 58, 34, 68, 148, 83, 172, 171, 56, 96, 230, 95, 216, 202, 163, 102, 30, 146, 185, 35, 160, 115, 71, 173, 41, 204, 54, 75, 183, 62, 12, 80, 156, 25, 91, 145, 2, 164, 166, 131, 229, 77, 224, 86, 78, 32, 36, 231, 45, 253, 244, 61, 7, 37, 133, 211, 149, 233, 111, 51, 123, 155, 144, 47, 180, 79, 15, 195, 9, 168, 6, 3, 219, 169, 215, 66, 243, 226, 249, 82, 189, 42, 197, 136, 85, 110, 221, 116, 153, 205, 222, 208, 27, 38, 39, 203, 212, 190, 151, 248, 218, 65, 201, 135, 5, 236, 4, 200, 252, 187, 193, 114, 150, 237, 154, 232, 90, 170, 139, 241, 49, 105, 138, 100, 191, 174, 120, 43, 87, 239, 44, 132, 247, 157, 209, 33, 199, 251, 184, 143, 147, 74, 19, 213, 254, 121, 98, 107, 179, 177, 186, 246, 46, 220, 181, 182, 73, 125, 103, 223, 63, 64, 50, 113, 124, 20, 81, 8, 18, 119, 118, 130, 21 };
            public static readonly int[] RotorE = new int[] { 120, 227, 234, 103, 38, 145, 195, 121, 80, 25, 13, 126, 86, 10, 75, 136, 36, 232, 42, 213, 250, 254, 228, 218, 150, 57, 24, 125, 111, 153, 117, 187, 162, 93, 62, 159, 90, 222, 133, 50, 141, 185, 51, 7, 223, 33, 131, 23, 9, 100, 79, 135, 37, 0, 157, 43, 253, 143, 84, 44, 210, 170, 67, 181, 237, 96, 171, 110, 16, 209, 71, 113, 74, 246, 85, 32, 17, 178, 180, 225, 21, 109, 184, 40, 229, 28, 204, 172, 167, 55, 188, 112, 63, 199, 39, 98, 240, 41, 226, 59, 129, 202, 233, 105, 192, 101, 140, 183, 238, 182, 77, 224, 242, 217, 220, 8, 65, 27, 123, 49, 1, 144, 245, 114, 215, 156, 248, 137, 104, 18, 12, 191, 203, 249, 52, 169, 118, 30, 130, 11, 26, 91, 92, 154, 134, 46, 212, 48, 47, 102, 255, 163, 160, 176, 19, 138, 127, 128, 34, 186, 236, 200, 3, 78, 179, 115, 194, 190, 241, 166, 60, 76, 189, 148, 252, 152, 142, 221, 106, 193, 211, 124, 197, 165, 31, 5, 94, 239, 122, 69, 20, 207, 6, 175, 45, 83, 95, 198, 14, 230, 2, 108, 214, 164, 22, 146, 70, 58, 177, 155, 149, 99, 56, 29, 119, 205, 116, 147, 88, 73, 216, 132, 243, 66, 81, 196, 72, 89, 139, 173, 201, 107, 35, 231, 61, 53, 219, 87, 206, 68, 247, 64, 251, 158, 97, 174, 235, 82, 208, 244, 4, 151, 161, 54, 15, 168 };
            public static readonly int[] RotorF = new int[] { 12, 189, 251, 226, 208, 238, 102, 35, 164, 92, 52, 172, 241, 179, 159, 67, 38, 0, 215, 245, 195, 203, 79, 26, 22, 46, 56, 188, 210, 240, 162, 136, 228, 204, 98, 68, 118, 182, 217, 181, 81, 99, 73, 103, 27, 58, 13, 21, 19, 24, 74, 93, 117, 97, 128, 174, 44, 157, 61, 7, 82, 169, 4, 156, 77, 76, 11, 36, 147, 85, 124, 55, 196, 171, 234, 142, 62, 87, 139, 91, 89, 10, 197, 237, 255, 25, 112, 20, 185, 131, 43, 113, 5, 96, 144, 201, 1, 104, 41, 130, 198, 50, 129, 64, 47, 152, 151, 30, 143, 29, 71, 190, 175, 14, 138, 250, 3, 216, 48, 32, 23, 200, 161, 231, 63, 45, 212, 225, 60, 114, 214, 34, 100, 115, 218, 235, 166, 199, 95, 109, 173, 170, 17, 221, 94, 37, 243, 140, 149, 106, 54, 8, 80, 249, 15, 18, 155, 180, 205, 9, 40, 209, 59, 194, 134, 211, 227, 160, 86, 239, 57, 176, 69, 105, 222, 141, 53, 150, 145, 6, 28, 39, 16, 236, 70, 229, 187, 248, 2, 213, 165, 122, 123, 254, 202, 163, 116, 65, 183, 220, 184, 192, 252, 191, 230, 135, 49, 158, 232, 127, 75, 154, 78, 121, 193, 126, 101, 223, 66, 137, 153, 132, 242, 110, 111, 177, 88, 233, 107, 219, 133, 33, 246, 206, 119, 253, 51, 224, 42, 146, 178, 186, 244, 247, 31, 83, 72, 90, 207, 108, 148, 84, 168, 167, 125, 120 };

            public static readonly int[] RotorANotches = new int[] { 1, 33, 65, 97, 129, 161, 193 };
            public static readonly int[] RotorBNotches = new int[] { 5, 38, 70, 102, 134, 166, 198 };
            public static readonly int[] RotorCNotches = new int[] { 3, 35, 67, 99, 131, 163, 195 };
            public static readonly int[] RotorDNotches = new int[] { 2, 34, 66, 98, 130, 162, 194 };
            public static readonly int[] RotorENotches = new int[] { 4, 37, 69, 101, 133, 165, 197 };
            public static readonly int[] RotorFNotches = new int[] { 6, 39, 71, 103, 135, 167, 199 };

            public static readonly int[] Reflector = new int[] { 255, 254, 253, 252, 251, 250, 249, 248, 247, 246, 245, 244, 243, 242, 241, 240, 239, 238, 237, 236, 235, 234, 233, 232, 231, 230, 229, 228, 227, 226, 225, 224, 223, 222, 221, 220, 219, 218, 217, 216, 215, 214, 213, 212, 211, 210, 209, 208, 207, 206, 205, 204, 203, 202, 201, 200, 199, 198, 197, 196, 195, 194, 193, 192, 191, 190, 189, 188, 187, 186, 185, 184, 183, 182, 181, 180, 179, 178, 177, 176, 175, 174, 173, 172, 171, 170, 169, 168, 167, 166, 165, 164, 163, 162, 161, 160, 159, 158, 157, 156, 155, 154, 153, 152, 151, 150, 149, 148, 147, 146, 145, 144, 143, 142, 141, 140, 139, 138, 137, 136, 135, 134, 133, 132, 131, 130, 129, 128, 127, 126, 125, 124, 123, 122, 121, 120, 119, 118, 117, 116, 115, 114, 113, 112, 111, 110, 109, 108, 107, 106, 105, 104, 103, 102, 101, 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 90, 89, 88, 87, 86, 85, 84, 83, 82, 81, 80, 79, 78, 77, 76, 75, 74, 73, 72, 71, 70, 69, 68, 67, 66, 65, 64, 63, 62, 61, 60, 59, 58, 57, 56, 55, 54, 53, 52, 51, 50, 49, 48, 47, 46, 45, 44, 43, 42, 41, 40, 39, 38, 37, 36, 35, 34, 33, 32, 31, 30, 29, 28, 27, 26, 25, 24, 23, 22, 21, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
        }


        /// Typex "Cyberchef"
        /// Compatible to: https://gchq.github.io/CyberChef
        /// Also see: https://github.com/gchq/CyberChef/blob/master/src/core/lib/Typex.mjs
        public static class Typex_Cyberchef
        {
            public const string Entry = "AZYXWVUTSRQPONMLKJIHGFEDCB";

            public const string Rotor1 = "MCYLPQUVRXGSAOWNBJEZDTFKHI";
            public const string Rotor2 = "KHWENRCBISXJQGOFMAPVYZDLTU";
            public const string Rotor3 = "BYPDZMGIKQCUSATREHOJNLFWXV";
            public const string Rotor4 = "ZANJCGDLVHIXOBRPMSWQUKFYET";
            public const string Rotor5 = "QXBGUTOVFCZPJIHSWERYNDAMLK";
            public const string Rotor6 = "BDCNWUEIQVFTSXALOGZJYMHKPR";
            public const string Rotor7 = "WJUKEIABMSGFTQZVCNPHORDXYL";
            public const string Rotor8 = "TNVCZXDIPFWQKHSJMAOYLEURGB";

            public static readonly int[] Notches = new int[] { 1, 5, 7, 13, 16, 20, 22 }; //BFHNQUW          

            public const string Reflector = "NCBKIGFMEXDUHARYWOTSLZQJPV";
        }
    }
}
