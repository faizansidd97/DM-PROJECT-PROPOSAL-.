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

Project Description about symmetric AES
The Advanced Encryption Standard (AES) is a symmetric block cipher chosen by the U.S. government to protect classified information. AES is implemented in software and hardware throughout the world to encrypt sensitive data. It is essential for government computer security, cybersecurity and electronic data protection.
AES includes three block ciphers: AES-128, AES-192 and AES-256. AES-128 uses a 128-bit key length to encrypt and decrypt a block of messages, while AES-192 uses a 192-bit key length and AES-256 a 256-bit key length to encrypt and decrypt messages. Each cipher encrypts and decrypts data in blocks of 128 bits using cryptographic keys of 128, 192 and 256 bits, respectively. Symmetric, also known as secret key, ciphers use the same key for encrypting and decrypting, so the sender and the receiver must both know -- and use -- the same secret key. The government classifies information in three categories: Confidential, Secret or Top Secret. All key lengths can be used to protect the Confidential and Secret level. Top Secret information requires either 192- or 256-bit key lengths. There are 10 rounds for 128-bit keys, 12 rounds for 192-bit keys and 14 rounds for 256-bit keys. A round consists of several processing steps that include substitution, transposition and mixing of the input plaintext to transform it into the final output of ciphertext.
DES
The data encryption standard (DES) is a common standard for data encryption and a form of secret key cryptography (SKC), which uses only one key for encryption and decryption. Public key cryptography (PKC) uses two keys, i.e., one for encryption and one for decryption. Encryption of a block of the message takes place in 16 stages or rounds. From the input key, sixteen 48 bit keys are generated, one for each round. In each round, eight so-called S-boxes are used. These S-boxes are fixed in the specification of the standard. Using the S-boxes, groups of six bits are mapped to groups of four bits. The contents of these S-boxes has been determined by the U.S. National Security Agency (NSA). The S-boxes appear to be randomly filled, but this is not the case. Recently it has been discovered that these S-boxes, determined in the 1970s, are resistant against an attack called differential cryptanalysis which was first known in the 1990s. The block of the message is divided into two halves. The right half is expanded from 32 to 48 bits using another fixed table. The result is combined with the subkey for that round using the XOR operation. Using the S-boxes the 48 resulting bits are then transformed again to 32 bits, which are subsequently permutated again using yet another fixed table. This by now thoroughly shuffled right half is now combined with the left half using the XOR operation. In the next round, this combination is used as the new left half.
AES
The Advanced Encryption Standard (AES) is a symmetric block cipher chosen by the U.S. government to protect classified information. AES is implemented in software and hardware throughout the world to encrypt sensitive data. It is essential for government computer security, cybersecurity and electronic data protection.
AES includes three block ciphers: AES-128, AES-192 and AES-256. AES-128 uses a 128-bit key length to encrypt and decrypt a block of messages, while AES-192 uses a 192-bit key length and AES-256 a 256-bit key length to encrypt and decrypt messages. Each cipher encrypts and decrypts data in blocks of 128 bits using cryptographic keys of 128, 192 and 256 bits, respectively. Symmetric, also known as secret key, ciphers use the same key for encrypting and decrypting, so the sender and the receiver must both know -- and use -- the same secret key. The government classifies information in three categories: Confidential, Secret or Top Secret. All key lengths can be used to protect the Confidential and Secret level. Top Secret information requires either 192- or 256-bit key lengths. There are 10 rounds for 128-bit keys, 12 rounds for 192-bit keys and 14 rounds for 256-bit keys. A round consists of several processing steps that include substitution, transposition and mixing of the input plaintext to transform it into the final output of ciphertext.
3DES
3DES works in much the same way as DES, except that goes through three cycles during the encryption process, using three keys: encryption, decryption, and another encryption. It has a key length of 192 bits (64 bits x 3 keys), but its actual strength is 168 bits (56 bits x 3 keys). This method is three times as strong as DES, yet it also means that it is three times slower because of the triple processing. (Strong Encryption Package, Triple DES Encryption)

DESCRIPTION OF MD5:
MD5 message digest algorithm is the 5th version of the Message Digest Algorithm developed by Ron Rivest to produce 128 bit message digest. MD5 is quite fast than other versions of message digest which takes the plain text of 512 bit blocks which is further divided into 16 blocks, each of 32 bit and produces the 128 bit message digest which is a set of four blocks, each of 32 bits. MD5 produces the message digest through five steps i.e.  padding, append length, divide input into 512 bit blocks, initialize chaining variables a process blocks and 4 rounds, uses different constant it in each iteration.

USES:

MD5 Algorithm was developed with the main motive of security as it takes an input of any size and produces an output if a 128-bit hash value. To be considered cryptographically secure MD5 should meet two requirements:

  1.  It is impossible to generate two inputs that cannot produce the same hash function.
  2.  It is impossible to generate a message having the same hash value.

Initially, MD5 was developed to store one way hash of a password and some file servers also provide pre-computed MD5 checksum of a file so that the user can compare the checksum of the downloaded file to it. Most Unix based Operating Systems include MD5 checksum utilities in their distribution packages.

WORKING:

As we all know that MD5 produces an output of 128-bit hash value. This encryption of input of any size into hash values undergoes 5 steps and each step has its a predefined task.
Step1: Append Padding Bits

  1. Padding means adding extra bits to the original message. So in MD5 original message is padded such that its length in bits is congruent to 448 modulo 512. Padding is done such that the total bits are 64 less being a multiple of 512 bits length.
  2.    Padding is done even if the length of the original message is already congruent to 448 modulo 512. In padding bits, the only first bit is 1 and the rest of the bits are 0.

Step 2: Append Length

After padding, 64 bits are inserted at the end which is used to record the length of the original input. Modulo 2^64. At this point, the resulting message has a length multiple of 512 bits.
Step 3: Initialize MD buffer

A four-word buffer (A, B, C, D) is used to compute the values for the message digest. Here A, B, C, D are 32- bit registers and are initialized in the following way

Step 4: Processing message in 16-word block

MD5 uses the auxiliary functions which take the input as three 32-bit number and produces a 32-bit output. These functions use logical operators like OR, XOR, NOR.

CONCLUSION:
Nowadays with the storage of all the data on cloud and internet, it is very important to keep the security of that data at the utmost priority. The most secure algorithm should be adopted to encrypt private data. Recent studies show that the SHA algorithm should be given paramount importance over MD5 as MD5 is more vulnerable to collision attacks. Although researchers are proposing new algorithms that are secure and least vulnerable to attacks like SHA256.

DESCRIPTION OF HMAC:

HMAC algorithm stands for Hashed or Hash based Message Authentication Code. It is a result of work done on developing a MAC derived from cryptographic hash functions. HMAC is a great resistant towards cryptanalysis attacks as it uses the Hashing concept twice. HMAC consists of twin benefits of Hashing and MAC, and thus is more secure than any other authentication codes. RFC 2104 has issued HMAC, and HMAC has been made compulsory to implement in IP security. The FIPS 198 NIST standard has also issued HMAC.
The working of HMAC starts with taking a message M containing blocks of length b bits. An input signature is padded to the left of the message and the whole is given as input to a hash function which gives us a temporary message digest MD’. MD’ again is appended to an output signature and the whole is applied a hash function again, the result is our final message digest MD.

DESCRIPTION HMACMD5:

Any cryptographic hash function, such as SHA-256 or SHA-3, may be used in the calculation of an HMAC; the resulting MAC algorithm is termed HMAC-X, where X is the hash function used (e.g. HMAC-SHA256 or HMAC-SHA3). The cryptographic strength of the HMAC depends upon the cryptographic strength of the underlying hash function, the size of its hash output, and the size and quality of the key.

HMAC uses two passes of hash computation. The secret key is first used to derive two keys – inner and outer. The first pass of the algorithm produces an internal hash derived from the message and the inner key. The second pass produces the final HMAC code derived from the inner hash result and the outer key. Thus the algorithm provides better immunity against length extension attacks.

An iterative hash function breaks up a message into blocks of a fixed size and iterates over them with a compression function. For example, SHA-256 operates on 512-bit blocks. The size of the output of HMAC is the same as that of the underlying hash function (e.g., 256 and 1600 bits in the case of SHA-256 and SHA-3, respectively), although it can be truncated if desired.

HMAC does not encrypt the message. Instead, the message (encrypted or not) must be sent alongside the HMAC hash. Parties with the secret key will hash the message again themselves, and if it is authentic, the received and computed hashes will match. 

DESCRIPTION OF HMACSHA-1:

HMACSHA1 is a type of keyed hash algorithm that is constructed from the SHA1 hash function and used as an HMAC, or hash-based message authentication code. The HMAC process mixes a secret key with the message data, hashes the result with the hash function, mixes that hash value with the secret key again, and then applies the hash function a second time. The output hash is 160 bits (20 bytes) in length.

This constructor uses a 64-byte, randomly generated key.

Due to collision problems with SHA1, Microsoft recommends SHA256.

HMAC uses two passes of hash computation. The secret key is first used to derive two keys – inner and outer. The first pass of the algorithm produces an internal hash derived from the message and the inner key. The second pass produces the final HMAC code derived from the inner hash result and the outer key. Thus the algorithm provides better immunity against length extension attacks.

An iterative hash function breaks up a message into blocks of a fixed size and iterates over them with a compression function. For example, SHA-256 operates on 512-bit blocks. The size of the output of HMAC is the same as that of the underlying hash function (e.g., 256 and 1600 bits in the case of SHA-256 and SHA-3, respectively), although it can be truncated if desired.

HMAC does not encrypt the message. Instead, the message (encrypted or not) must be sent alongside the HMAC hash. Parties with the secret key will hash the message again themselves, and if it is authentic, the received and computed hashes will match. 

Initializes a new instance of the HMACSHA1 class with a randomly generated key.
