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

## Enigma equations
For those, who are searching for the Enigma equation(s). Here they are:

Some definitions:

- P is our plaintext letter (as integer), and C is our ciphertext letter (as integer)
- We assume our rotors are int arrays from 0=A to 25=Z (of course ordered by the original rotor definitions)
- We have r1, r2, r3, ..., rn rotors
- r1^-1 is the inverse rotor 1
- We have a plugboard p1 that maps l1 -> l2, letter 1 is replaced by letter 2
- p^-1 is the inverse plugboard function
- rf is a reflector (an array, that maps any letter x to y and then also y to x)

The complete Enigma is then defined as: 

- C = p^-1(r1^-1(r2^-1(r3^-1(rf(r3(r2(r1(p(P)))))))))

![enigma_equation.png](https://github.com/n1k0m0/ASCIIEnigma/blob/main/images/enigma_equation.png)

The current first goes through the plugboard, then through the three rotors, then through the reflector, then through the (inverse) three rotors, and finally through the (inverse) plugboard.

A single rotor r is defined as (rotorarray is an int array defining the rotor mapping): 

- C = Mod(rotorarray[Mod(P + Rotation, rotorarray.Length)] - Rotation, rotorarray.Length)

Clearly, the inverse rotor is the inverse int array, meaning, if the original maps 5 to 3, then the inverse maps 3 to 5

## Some videos

I also created YouTube videos about Enigma, if you are interested in the details of the machine and its cryptanalysis:
- Enigma Machine – Part 1 of 2 – How does it work? -> https://www.youtube.com/watch?v=FG59my_HLtI
- Enigma Machine – Part 2 of 2 – Let's break it! -> https://www.youtube.com/watch?v=MqNgagh6qpY
- Enigma Cryptanalysis Revisited – New State-of-the-Art Attacks on the Enigma Machine in CrypTool 2 -> https://www.youtube.com/watch?v=kptQbcTUVyk
