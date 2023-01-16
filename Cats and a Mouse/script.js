// Problem: https://www.hackerrank.com/challenges/cats-and-a-mouse/problem


// Complete the catAndMouse function below.
function catAndMouse(x, y, z) {

    let positionDifferenceCatA = Math.abs(z-x);
    let positionDifferenceCatB = Math.abs(z-y);

    if (positionDifferenceCatA > positionDifferenceCatB)
        return "Cat B";
    
    else if(positionDifferenceCatA < positionDifferenceCatB)
        return "Cat A";
    
    else
        return "Mouse C";
    
}