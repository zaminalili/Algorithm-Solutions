function repeatedString(s, n) {
    const characterCount = s.split('a').length - 1;
    const sLength = s.length;

    let countA = (Math.floor(n/sLength)) * characterCount;

    for (let i = 0; i < n % sLength; i++) {
        if(s[i] == 'a')
            countA++;
    }

    return countA;
}

s = 'aba';
n = 1;

repeatedString(s, n);