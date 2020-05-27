# DM 103347: RSA CRYPTOGRAPHY

### PROJECT MEMBERS

StdID | Name
------------ | -------------
**61869** | **Wajahat Ali Khalid**
61877 | Rahim Ahmed Khan
61870 | Afroz Alam
61913 | Faizan Siddiqui

## Project Description
**RSA (Rivest, Shamir Adleman)** is an algorithm for public key cryptography.RSA based on extra ordinary integer factorization It is the first algorithm referred to be suitable for marking just as encryption, and was one of the first extraordinary advances out in the public key cryptography. RSA is generally utilized in electronic trade conventions, and is accepted to be secure given adequately long keys and the utilization of updated executions.RSA encryption and decoding computation algorithm talks about mystery of messages between two person. It includes a public key and a private key generation. The public key can be known to each one and is used for reassembling messages. Messages mixed with the public key must be unscrambled using the private key. The private key isn't openly known,it is simply known to beneficiary and the one who is going to recieve it. In this Project, functions of RSA algorithm are performed like figuring phi, n, square, and modulus. RSA computation is step in this dare to encrypt and decode content. This computation encrypt and decode the plane text, i.e.each content gets encoded and decoded. In this project,user takes as input, in console user section, After taking input, HEX function extracts the text HEX code, HEX code is converted into cipher text depending on RSA settings. An opposite, Cipher text gets loaded, then apply RSA algorithm, then decipher the text, resultant string is converted. In this project we have implemented RSA completely as well and we have covered other algorithms as well which are Extended Euclidean Algorithm, DES, SDES and Hashing.
**The project has been made on C# platfrom which is also known as .net**

## Discrete Math Concepts Used.
RSA, Modulo calculation, Extended Euclidean Algorithm has been marking an impact in helping us from discreete mathmatics concepts as they have been used in our project.

### Example 1: Learn to use RSA more efficiently and easier for implementation
* Discrete mathmatics has advanced public key implementation schemes
* It has provided a better version of algorithm which is easy to use over to speed up things.
* It has been factoring method convinient.
* Using this we can measure other attacks as well which is based on statistical and problistic apporaches.
* Here, In support I am including code of RSA encyption and decryption parameters which might eleborate some idea.
```C#
Encryption:

using (var rsa = new RSACryptoServiceProvider((int) KeySizes.SIZE_2048, cspParameters))
		{
                encrypted = rsa.Encrypt(plain, true);
		}

		return encrypted;
		}

Decryption:
using (var rsa = new RSACryptoServiceProvider((int) KeySizes.SIZE_2048, cspParameters))
		{
                decrypted = rsa.Decrypt(encrypted, true);
		}

		return decrypted;
```
### Example 2: Better undestanding for implementation of Euclidean Algorithm
Extended Euclidean Algorithm has been used to generate private key and we have leanrt this algorithm as it is an extension of euclidean algorithm.
Below I am posting a code snippet of out eulicidean extension which helped us out in our project.
```C# 
public EuclideanExtendedSolution operation()
        {
            long x0 = 1, xn = 1;
            long y0 = 0, yn = 0;
            long x1 = 0;
            long y1 = 1;
            long q;
            long r = a % b;
            while (r > 0)
            {
                q = a / b;
                xn = x0 - q * x1;
                yn = y0 - q * y1;
                x0 = x1;
                y0 = y1;
                x1 = xn;
                y1 = yn;
                a = b;
                b = r;
                r = a % b;
            }
            return new ExtendedEuclideanSolution(xn, yn, b);
        }
```

## Problems Faced

### Problem 1: Syncronization.
It was so hard for members to be on same page as everyone is at their home and neither we can visit each other.
* **Solution:**
We have used zoom sessions, skype and whatsapp to over come this and came much far so we could contribute and help each other out.

### Problem 2: Understanding github and managing work flow
We have deleted around 500 files and you could see it in Ali khalid contribution, it was alot difficult to let everyone understand how to manage github repository. 
First Ali have contributed his part of project and left us all then he deleted his part and afroz was not able to submit snippets, Ali was repository owner and he was without internet before the day of project and we have been in a hault condition for over 10 hours as our pull request was not accepted untill he do that. (he forget his password of gmail account too). It was quite difficult in managing all in directly without compressing it into a rar or zip file as this is what we have been doing in other courses projects. It was totally out of the box. Afroz looked many ways to upload snippets of the console of running code to provide more understanding platform to learn better or to understand better whats going on inside the code and how it is running, but the upload snippets is too hard , i have no contributer access of uploading on master section and did try many ways to upload it but every time i found myself on an end.
* **Solution:**
The first solution was tutorials which we have seen to how to manage github professional repository and work flow and how to contribute accordingly. 
We have teached each other in a manner so that everyone could gather on a same page.
Rather than merging or making files difficult to understand we did some self learning, Learnt how to use github properly, how to contribute accordingly and how to manage it as well. I believe it is definately far better than having a compressed file or zip folder. It was a lot good thing to learn. The most proficient benifit we got ***We learnt to contribute in an open source project***. 

### Problem 3:Project Specification was not enough.
We have found that as we are more than 2 members in a group so it would not be relevant enough to go and search out and came us with RSA only.
* **Solution:**
We have increased our circle of learning, we had very little idea about other cryptographic algorithms. We managed to go ahead and tried our best to include other cryptographic tools in our project as well.

## References
I am breaking down references and dividing them in sub groups.

### To understand Github:
[Learnt to contribute in github](https://www.youtube.com/watch?v=waEb2c9NDL8)

[Learnt how to create folder in github](https://stackoverflow.com/questions/12258399/how-do-i-create-a-folder-in-a-github-repository)

[Learnt about contribution graph](https://stackoverflow.com/questions/38346919/what-does-the-two-number-mean-in-github-contributor-graph-page)

### To Learn Markdown:
[Learnt Markdown](https://learn-the-web.algonquindesign.ca/topics/markdown/)

[Learnt Markdown by guides on github](https://guides.github.com/features/mastering-markdown/)

[To understand markdown syntax more](https://daringfireball.net/projects/markdown/syntax)

### To Learn and understand RSA and implement it in project:
[Basic concept of RSA](https://en.wikipedia.org/wiki/RSA_(cryptosystem))

[RSA Encryption on Brilliant Org](https://brilliant.org/wiki/rsa-encryption/)

[Learnt RSA and Discrete Mathematic relation](https://www.youtube.com/watch?v=iojw59KBRgc)

[Learnt public key cryptography in RSA with relation to discrete mathematics](https://www.youtube.com/watch?v=reH9zrGcXXM)

[Encrypt/Decrypt RSA in .net](https://www.youtube.com/watch?v=sYGS80-Joi8)

### To Learn RSA with relation to Euclidian Algorithm/Extended Euclidian Algorithm:
[Basic idea](https://math.stackexchange.com/questions/1226742/rsa-and-extended-euclidian-algorithm)

[A PDF guide to understand it in a better way](https://www.cs.ucy.ac.cy/courses/EPL674/labs/lab3/Lab3-RSA.pdf)

[To learn private key generation using extended euclidian algorithm](https://crypto.stackexchange.com/questions/5889/calculating-rsa-private-exponent-when-given-public-exponent-and-the-modulus-fact)

### To learn other cryptographic algorithm:
[To understand asymmetric and symmetric encryption](https://www.youtube.com/watch?v=AQDCe585Lnc)

[TO learn how to implement them in .net](https://www.youtube.com/watch?v=ysxC6-AFEYg)

