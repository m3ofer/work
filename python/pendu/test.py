import os, random, words 

word = random.choice(words.hw_words)
word = word.upper()
reveal =list(len(word)*'_')
lives = 7
won = False

def check_letter(letter,word):
        for i in range(0,len(word)):
            letter = word[i]
            if guess == letter:
                reveal[i] = guess
        if '_' not in reveal:
            return  True
        else:
            return  False

def status():
    os.system('clear')
    print(' '.join([str(e) for e in reveal]))

while won == False and lives > 0:

    status()
    guess = input('one letter or full: ')
    guess = guess.upper()
    if guess == word:
        won = True
    if len(guess) == 1 and guess in word:
        won = check_letter(guess,word)
    else:
        lives -= 1


if won:
    print('win')
else:
    print('lost and the word was: ',word)
    os.system("python3 game.py")
