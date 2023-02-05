// Problem: https://www.hackerrank.com/challenges/the-hurdle-race/problem

function hurdleRace(k, height) {
    
    // var minimumDoses = 0;

    // if(Math.max(...height) - k > 0)
    //     minimumDoses = Math.max(...height) - k ;

    // return minimumDoses;

    let needsToDrink = Math.max(...height) - k;

    return needsToDrink > 0 ? needsToDrink : 0;

}