// Problem: https://www.hackerrank.com/challenges/picking-numbers/problem

function pickingNumbers(a) {
    
    var subarray = [];

    for (let i = 0; i < a.length-1; i++) {

        let leftCount = 1;
        let rightCount = 1;

        for (let j = i+1; j < a.length; j++) {
            
            let difference = a[i] - a[j];

            if (difference == 0) {
                leftCount++;
                rightCount++;
                
            }
            else if(difference == 1) 
                leftCount++;
            
            else if(difference == -1) 
                rightCount++;
            
        }

        leftCount > rightCount ? subarray.push(leftCount) : subarray.push(rightCount);
        
    }

    return Math.max(...subarray);

}

// let longestSubarrayCount = 0;

//     for (let i = 0; i < a.length-1; i++) {

//         let subarray = [];
//         subarray.push(a[i]);

//         for (let j = i+1; j < a.length; j++) {
            
//             let difference = Math.abs(a[i] - a[j]);

//             if (difference == 0) {
//                 subarray.push(a[j]);
//                 subarray.splice(j, 1);
                
//             }
//             else if(difference == 1) {
//                 subarray.push(a[j]);
//             }
//         }

//         if(subarray.length > longestSubarrayCount)
//             longestSubarrayCount = subarray.length;
        
//     }

//     return longestSubarrayCount;