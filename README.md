# ASCIIEnigma
Implementation of various (original and "new") Enigma machines: original Enigma 1, "Morse Enigma", "Enigma 64", "ASCIIEnigma".

The "ASCIIEnigma" is an Enigma machine, that does not only work on 26 letters, but on the complete ASCII code (=256 symbols).

The project implements these "Enigmas":
* Engima 1: original 3 rotor Enigma with its original rotors and reflectors.
* Morse Enigma: "new" Enigma, but with letters, digits, and some special symbols. The set would still allow to send the messages via morse code (thats why I named it Morse Enigma).
* Enigma 64: a "new" Enigma, but with 64 printable characters including lowercase, uppercase, digits, and special characters.
* ASCII Enigma: a "new" Enigma, but it is able to encrypt ASCII encoded messages

The code allows to easily modify and create new machines. You can (re-)define rotors, reflects, and plugboard. Also, the code does not limit you to 3 or 4 rotors. You could even create an Enigma with 100s of rotors :-)

I did not implement the "rings", since these do not add to the security and would only make the machines more complex :-)
For more details on the Enigma, have a look at the wikipedia article: https://en.wikipedia.org/wiki/Enigma_machine

I also created YouTube videos about Enigma, if you are interested in the details of the machine and its cryptanalysis:
- Enigma Machine – Part 1 of 2 – How does it work? -> https://www.youtube.com/watch?v=FG59my_HLtI
- Enigma Machine – Part 2 of 2 – Let's break it! -> https://www.youtube.com/watch?v=MqNgagh6qpY
- Enigma Cryptanalysis Revisited – New State-of-the-Art Attacks on the Enigma Machine in CrypTool 2 -> https://www.youtube.com/watch?v=kptQbcTUVyk
