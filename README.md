# DM-PROJECT-PROPOSAL-.
RSA ALGORITHM
Group Members
Wajahat Ali Khalid
Faizan Sidd
Afroz Alam
Rahim Ahmed Khan

INTRODUCTION
 Introduction
RSA encryption and decryption algorithm talks about secrecy of messages between two users. Itinvolves a public key and a private key generation. The public key can be known to everyoneand is used for encrypting messages. Messages encrypted with the public key can only bedecrypted using the private key. The private key is not publicly known, it is only known toreceiver so that she / he can decrypt the encrypted message. These keys !public and private keys"for the RSA algorithm are generated using some mathematical operations. The principal goal of design of any encryption algorithm must be security against unauthori#edattacks. $ithin the last decade, there has been a vast increase in the accumulation andcommunication of digital computer data in both the private and public sectors. Much of thisinformation has a significant value, either directly or indirectly, which requires protection. RSAis an Asymmetric key cryptography which provides security against unauthori#ed attacks.&roblem 'efinition $hat is RSA Algorithm and mathematics behind it ( RSA Algorithm) Someidea of RSA algorithm has been given in abstract above. *ou may refer that again for moreinformation. The encryption and decryption in the RSA algorithm as follows) +irst, I had togenerate the key pair and then those keys were to be used for encryption and decryption. Key generation RSA involves a public key and a private key. The mathematics behind RSA algorithmis as follows

Project Description
In this class file, RSA algorithm related functions are available like calculating phi, n, square, and modulus. RSA algorithm is step in this project to encrypt and decrypt text. This algorithm encrypts and decrypts the plane text, i.e., each text gets encrypted and decrypted.
The Main Concepts In this project, takes as input, in console user section, , After taking input, HEX function extracts the text HEX code, HEX code is converted into cipher text depending on RSA settings. An opposite, Cipher text gets loaded, then apply RSA algorithm, then decipher the text, resultant string is converted .

Project Description about symmetric 
AES

The Advanced Encryption Standard (AES) is a symmetric block cipher chosen by the U.S. government to protect classified information. AES is implemented in software and hardware throughout the world to encrypt sensitive data. It is essential for government computer security, cybersecurity and electronic data protection.

AES includes three block ciphers: AES-128, AES-192 and AES-256.
AES-128 uses a 128-bit key length to encrypt and decrypt a block of messages, while AES-192 uses a 192-bit key length and AES-256 a 256-bit key length to encrypt and decrypt messages. Each cipher encrypts and decrypts data in blocks of 128 bits using cryptographic keys of 128, 192 and 256 bits, respectively.
Symmetric, also known as secret key, ciphers use the same key for encrypting and decrypting, so the sender and the receiver must both know -- and use -- the same secret key. The government classifies information in three categories: Confidential, Secret or Top Secret. All key lengths can be used to protect the Confidential and Secret level. Top Secret information requires either 192- or 256-bit key lengths.
There are 10 rounds for 128-bit keys, 12 rounds for 192-bit keys and 14 rounds for 256-bit keys. A round consists of several processing steps that include substitution, transposition and mixing of the input plaintext to transform it into the final output of ciphertext.

DES


The data encryption standard (DES) is a common standard for data encryption and a form of secret key cryptography (SKC), which uses only one key for encryption and decryption. Public key cryptography (PKC) uses two keys, i.e., one for encryption and one for decryption.
Encryption of a block of the message takes place in 16 stages or rounds. From the input key, sixteen 48 bit keys are generated, one for each round. In each round, eight so-called S-boxes are used. These S-boxes are fixed in the specification of the standard. Using the S-boxes, groups of six bits are mapped to groups of four bits. The contents of these S-boxes has been determined by the U.S. National Security Agency (NSA). The S-boxes appear to be randomly filled, but this is not the case. Recently it has been discovered that these S-boxes, determined in the 1970s, are resistant against an attack called differential cryptanalysis which was first known in the 1990s.
The block of the message is divided into two halves. The right half is expanded from 32 to 48 bits using another fixed table. The result is combined with the subkey for that round using the XOR operation. Using the S-boxes the 48 resulting bits are then transformed again to 32 bits, which are subsequently permutated again using yet another fixed table. This by now thoroughly shuffled right half is now combined with the left half using the XOR operation. In the next round, this combination is used as the new left half.

AES

The Advanced Encryption Standard (AES) is a symmetric block cipher chosen by the U.S. government to protect classified information. AES is implemented in software and hardware throughout the world to encrypt sensitive data. It is essential for government computer security, cybersecurity and electronic data protection.

AES includes three block ciphers: AES-128, AES-192 and AES-256.
AES-128 uses a 128-bit key length to encrypt and decrypt a block of messages, while AES-192 uses a 192-bit key length and AES-256 a 256-bit key length to encrypt and decrypt messages. Each cipher encrypts and decrypts data in blocks of 128 bits using cryptographic keys of 128, 192 and 256 bits, respectively.
Symmetric, also known as secret key, ciphers use the same key for encrypting and decrypting, so the sender and the receiver must both know -- and use -- the same secret key. The government classifies information in three categories: Confidential, Secret or Top Secret. All key lengths can be used to protect the Confidential and Secret level. Top Secret information requires either 192- or 256-bit key lengths.
There are 10 rounds for 128-bit keys, 12 rounds for 192-bit keys and 14 rounds for 256-bit keys. A round consists of several processing steps that include substitution, transposition and mixing of the input plaintext to transform it into the final output of ciphertext.

3DES


3DES works in much the same way as DES, except that goes through three cycles during the encryption process, using three keys: encryption, decryption, and another encryption. It has a key length of 192 bits (64 bits x 3 keys), but its actual strength is 168 bits (56 bits x 3 keys). This method is three times as strong as DES, yet it also means that it is three times slower because of the triple processing. (Strong Encryption Package, Triple DES Encryption)
