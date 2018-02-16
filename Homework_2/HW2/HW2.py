#!/usr/bin/env python3
#Spencer Fronberg
#CS 6635
import hashlib as h
import pyspark
import sys
import os
import time
import math as m

os.environ['PYTHONHASHSEED'] = '123'
#print(os.environ['PYTHONHASHSEED'])

def Get_Doc(doc):
    file = open(doc, "r")
    for line in file:
        return str(line)

def Calculate_Distinct_Kgrams(kgram, document, doc, char):
    list = set()
    if char:
        for i in range(len(document) - kgram + 1):
            list.add(document[i:i+kgram])
    else:
        words = document.split(" ")
        for i in range(len(words) - kgram + 1):
            list.add(words[i] + " " + words[i+1])
    #print(list)
    print("\t" + doc + ":\t" + str(len(list)))
    return list

def Jaccard(first, second):
    return len(first & second) / len(first | second)
def Jaccard_Special(first, second):
    same = 0
    for i in range(len(first)):
        if first[i] == second[i]:
            same += 1
    return same / len(first)
def Part1():
    print("Part 1(A):")
    print("When k-gram is 2 characters: ")
    G1 = []
    G1.append(Calculate_Distinct_Kgrams(2, Get_Doc("D1.txt"), "D1", char=True))
    G1.append(Calculate_Distinct_Kgrams(2, Get_Doc("D2.txt"), "D2", char=True))
    G1.append(Calculate_Distinct_Kgrams(2, Get_Doc("D3.txt"), "D3", char=True))
    G1.append(Calculate_Distinct_Kgrams(2, Get_Doc("D4.txt"), "D4", char=True))

    print("When k-gram is 3 characters: ")
    G2 = []
    G2.append(Calculate_Distinct_Kgrams(3, Get_Doc("D1.txt"), "D1", char=True))
    G2.append(Calculate_Distinct_Kgrams(3, Get_Doc("D2.txt"), "D2", char=True))
    G2.append(Calculate_Distinct_Kgrams(3, Get_Doc("D3.txt"), "D3", char=True))
    G2.append(Calculate_Distinct_Kgrams(3, Get_Doc("D4.txt"), "D4", char=True))

    print("When k-gram is 2 words: ")
    G3 = []
    G3.append(Calculate_Distinct_Kgrams(2, Get_Doc("D1.txt"), "D1", char=False))
    G3.append(Calculate_Distinct_Kgrams(2, Get_Doc("D2.txt"), "D2", char=False))
    G3.append(Calculate_Distinct_Kgrams(2, Get_Doc("D3.txt"), "D3", char=False))
    G3.append(Calculate_Distinct_Kgrams(2, Get_Doc("D4.txt"), "D4", char=False))

    print("\nPart 1(B):")
    print("When k-gram is 2 characters (G1): ")
    print("\tD1, D2 Jaccard similarity is:\t" + str(Jaccard(G1[0], G1[1])))
    print("\tD1, D3 Jaccard similarity is:\t" + str(Jaccard(G1[0], G1[2])))
    print("\tD1, D4 Jaccard similarity is:\t" + str(Jaccard(G1[0], G1[3])))
    print("\tD2, D3 Jaccard similarity is:\t" + str(Jaccard(G1[1], G1[2])))
    print("\tD2, D4 Jaccard similarity is:\t" + str(Jaccard(G1[1], G1[3])))
    print("\tD3, D4 Jaccard similarity is:\t" + str(Jaccard(G1[2], G1[3])))

    print("When k-gram is 3 characters (G2): ")
    print("\tD1, D2 Jaccard similarity is:\t" + str(Jaccard(G2[0], G2[1])))
    print("\tD1, D3 Jaccard similarity is:\t" + str(Jaccard(G2[0], G2[2])))
    print("\tD1, D4 Jaccard similarity is:\t" + str(Jaccard(G2[0], G2[3])))
    print("\tD2, D3 Jaccard similarity is:\t" + str(Jaccard(G2[1], G2[2])))
    print("\tD2, D4 Jaccard similarity is:\t" + str(Jaccard(G2[1], G2[3])))
    print("\tD3, D4 Jaccard similarity is:\t" + str(Jaccard(G2[2], G2[3])))

    print("When k-gram is 2 words (G3): ")
    print("\tD1, D2 Jaccard similarity is:\t" + str(Jaccard(G3[0], G3[1])))
    print("\tD1, D3 Jaccard similarity is:\t" + str(Jaccard(G3[0], G3[2])))
    print("\tD1, D4 Jaccard similarity is:\t" + str(Jaccard(G3[0], G3[3])))
    print("\tD2, D3 Jaccard similarity is:\t" + str(Jaccard(G3[1], G3[2])))
    print("\tD2, D4 Jaccard similarity is:\t" + str(Jaccard(G3[1], G3[3])))
    print("\tD3, D4 Jaccard similarity is:\t" + str(Jaccard(G3[2], G3[3])))

    #print("D3, D4:\t" + str(Jaccard_Special(Get_Vector(G2[2], 100), Get_Vector(G2[3], 100))))

    return G2
def Get_Vector(doc, t):
    vector = []
    #print(doc)
    for i in range(t):
        smallest = sys.maxsize
        for j in doc:
            #option 1
            h = bytes(j+str(i), 'utf-8')
            hsh = hash(j+str(i))
            #option 2
            """stri = j + str(i)
            st = bytes(stri, 'utf-8')
            hsh = int(h.md5(st).hexdigest(), 16)"""
            if hsh < smallest:
                smallest = hsh
        vector.append(smallest)
    return vector
def Part2(G2_D1, G2_D2):
    #print(Get_Vector(G2_D1, 20))
    #print(Get_Vector(G2_D2, 20))

    print("\nPart 2(A):")
    print("The Jaccard similarity for D1 and D2 using min-hash:")
    t0 = time.clock()
    j20 = Jaccard_Special(Get_Vector(G2_D1, 20), Get_Vector(G2_D2, 20))
    t1 = time.clock()
    print("\tt=20 is:\t" + str(j20) + "\n\tTime =\t" + str(t1 - t0), end="\n\n")

    t2 = time.clock()
    j60 = Jaccard_Special(Get_Vector(G2_D1, 60), Get_Vector(G2_D2, 60))
    t3 = time.clock()
    print("\tt=60 is:\t" + str(j60) + "\n\tTime =\t" + str(t3 - t2), end="\n\n")

    t4 = time.clock()
    j150 = Jaccard_Special(Get_Vector(G2_D1, 150), Get_Vector(G2_D2, 150))
    t5 = time.clock()
    print("\tt=150 is:\t" + str(j150) + "\n\tTime =\t" + str(t5 - t4), end="\n\n")

    t6 = time.clock()
    j300 = Jaccard_Special(Get_Vector(G2_D1, 300), Get_Vector(G2_D2, 300))
    t7 = time.clock()
    print("\tt=300 is:\t" + str(j300) + "\n\tTime =\t" + str(t7 - t6), end="\n\n")

    t8 = time.clock()
    j600 = Jaccard_Special(Get_Vector(G2_D1, 600), Get_Vector(G2_D2, 600))
    t9 = time.clock()
    print("\tt=600 is:\t" + str(j600) + "\n\tTime =\t" + str(t9 - t8), end="\n\n")

    t10 = time.clock()
    print("\tt=1000 is:\t" + str(Jaccard_Special(Get_Vector(G2_D1, 1000), Get_Vector(G2_D2, 1000))))
    t11 = time.clock()
    print("\tTime =\t" + str(t11-t10), end="\n\n")

    t12 = time.clock()
    print("\tt=2000 is:\t" + str(Jaccard_Special(Get_Vector(G2_D1, 2000), Get_Vector(G2_D2, 2000))))
    t13 = time.clock()
    print("\tTime =\t" + str(t13-t12), end="\n\n")

    t14 = time.clock()
    print("\tt=4000 is:\t" + str(Jaccard_Special(Get_Vector(G2_D1, 4000), Get_Vector(G2_D2, 4000))))
    t15 = time.clock()
    print("\tTime =\t" + str(t15-t14), end="\n\n")

    t16 = time.clock()
    print("\tt=10000 is:\t" + str(Jaccard_Special(Get_Vector(G2_D1, 10000), Get_Vector(G2_D2, 10000))))
    t17 = time.clock()
    print("\tTime =\t" + str(t17-t16), end="\n\n")


    return
def Get_br():
    t = 160  # Hash Functions
    T = 0.7  # Threshold
    b = m.floor(-m.log(t, T))
    r = m.floor(t / b)

    d = [sys.maxsize, r, b]
    for B in range(b - 6, b + 4):
        for R in range(r - 3, r + 7):
            temp_T = m.pow((1 / R), (1 / B))
            diff = temp_T - T
            if 150 < B * R < 170:
                print("b = " + str(B) + ",\tr = " + str(R) + ",\tT = " + str(round(temp_T, 3)) + " \\\\\nb * r = " + str(B * R) + " \\\\ \\\\")
            if abs(diff) < d[0] and 153 < B * R < 170:
                d = [diff, R, B]
    """print("T = " + str(T + d[0]))
    print("r = " + str(d[1]))
    print("b = " + str(d[2]))"""
    r = d[1]
    b = d[2]
    return b, r
def Probability(s, b, r):
    return 1 - m.pow(1 - m.pow(s, b), r)
def Part3(G2):
    b, r = Get_br()
    print("r = ", end="")
    print(r)
    print("b = ", end="")
    print(b)
    print("The following are the probabilities when k-gram is 3 characters (G2) from the Jaccard similarities from Part 1(B): ")
    print("\tD1, D2:\t" + str(Probability(Jaccard(G2[0], G2[1]), b, r)), end=" \\\\ \n")
    print("\tD1, D3:\t" + str(Probability(Jaccard(G2[0], G2[2]), b, r)), end=" \\\\ \n")
    print("\tD1, D4:\t" + str(Probability(Jaccard(G2[0], G2[3]), b, r)), end=" \\\\ \n")
    print("\tD2, D3:\t" + str(Probability(Jaccard(G2[1], G2[2]), b, r)), end=" \\\\ \n")
    print("\tD2, D4:\t" + str(Probability(Jaccard(G2[1], G2[3]), b, r)), end=" \\\\ \n")
    print("\tD3, D4:\t" + str(Probability(Jaccard(G2[2], G2[3]), b, r)), end=" \\\\ \n")
    return

def main():
    G2 = Part1()
    G2_D1 = G2[0]
    G2_D2 = G2[1]
    #Part2(G2_D1, G2_D2)
    Part3(G2)
    return

if __name__ == "__main__":
    main()
    exit(0)

