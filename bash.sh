#!/usr/bin/env bash
mkdir {A..Z}

f="$(find ~/Desktop ~/Documents ~/Downloads ~/Music ~/Pictures ~/Public ~/Templates ~/Videos -name '*.py' -o -name '*.jpg' -o -name '*.png' -o -name '*.jpeg' -o -name '*.pdf' -o -name '*.ods' -o -name '*.odt' -o -name '*.odp' -o -name '*.deb' -o -name '*.mp3')"

echo -E "$f"

mv $f ~/Documents

mkdir Python Pictures Powerpoint Pdf Excel Word Videos Mp3 Deb

python3 manager.py

mv A* ~/Documents/A
mv B* ~/Documents/B
mv C* ~/Documents/C
mv D* ~/Documents/D
mv E* ~/Documents/E
mv F* ~/Documents/F
mv G* ~/Documents/G
mv H* ~/Documents/H
mv I* ~/Documents/I
mv J* ~/Documents/J
mv K* ~/Documents/K
mv L* ~/Documents/L
mv M* ~/Documents/M
mv N* ~/Documents/N
mv O* ~/Documents/O
mv P* ~/Documents/P
mv Q* ~/Documents/Q
mv R* ~/Documents/R
mv S* ~/Documents/S
mv T* ~/Documents/T
mv U* ~/Documents/U
mv V* ~/Documents/V
mv W* ~/Documents/W
mv X* ~/Documents/X
mv Y* ~/Documents/Y
mv Z* ~/Documents/Z
