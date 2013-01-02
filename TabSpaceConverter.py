import sys

def main():
    action = "none"
    if len(sys.argv) > 1:
        action = sys.argv[1]

    action = action.lower()

    while True:
        try:
            line = sys.stdin.readline()
        except KeyboardInterrupt:
            break

        if not line:
            break

        if action == "makespaces":
            line = ReplaceBeginning(line, "\t", "    ")
        elif action == "maketabs":
            line = ReplaceBeginning(line, "    ", "\t")
    
        sys.stdout.write(line)

def ReplaceBeginning(text, match, newVal):
    res = ""
    i = 0

    while i < len(text):
        if Contains(text, match, i):
            res += newVal
            i += len(match)
        else:
            res += text[i:]
            break

    return res

def Contains(text, match, pos):
    i = pos
    while True:
        if i - pos >= len(match):
            return True
        if i >= len(text):
            break
        if text[i] != match[i - pos]:
            return False
        i += 1

    return False

if __name__ == '__main__':
    main()