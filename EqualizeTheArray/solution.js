function equalizeArray(arr) {

    return arr.length - mostRepeatedNumber(arr);

}


function mostRepeatedNumber(arr) {

    const arrLength = arr.length;
    let repeatedCounts = {};

    for (let i = 0; i < arrLength-1; i++) {
        let repeatedCount = 1;

        if(repeatedCounts[arr[i]] == undefined){
            for (let j = i+1; j < arrLength; j++) {
                if(arr[i] == arr[j]){
                    repeatedCount++;
                }
            }

            repeatedCounts[arr[i]] = repeatedCount;
        }    
    }

    return Object.entries(repeatedCounts).reduce((a, b) => a[1] > b[1] ? a : b)[1];
}

let arr = [3, 3, 2, 1, 3];
let arr1 = [1, 2, 2, 3]
console.log(equalizeArray(arr1));