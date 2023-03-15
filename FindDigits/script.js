//Problem: https://www.hackerrank.com/challenges/find-digits/problem

function findDigits(n) {
    let digits = 0;

    [...n.toString()].forEach( (e, i) => {
        if(n % parseInt(e) == 0)
            digits++;
    });

    return digits;
}