 
 // Problem: https://www.hackerrank.com/challenges/magic-square-forming/problem
 

function formingMagicSquare(s) {
    // for (let i = 0; i < s.length; i++) {
    //    for (let j = 0; j < s.length; j++) {

    //         if (i==1 && j==1) {
    //             //center   
    //         }
    //         else if(i+j % 2 == 0){
    //             //corners
    //         }
    //         else if(i+j % 2 !=0){
    //             //edge
    //         }

    //    }
        
    // }

    let pre = [
            [[8, 1, 6], [3, 5, 7], [4, 9, 2]],
            [[6, 1, 8], [7, 5, 3], [2, 9, 4]],
            [[4, 9, 2], [3, 5, 7], [8, 1, 6]],
            [[2, 9, 4], [7, 5, 3], [6, 1, 8]], 
            [[8, 3, 4], [1, 5, 9], [6, 7, 2]],
            [[4, 3, 8], [9, 5, 1], [2, 7, 6]], 
            [[6, 7, 2], [1, 5, 9], [8, 3, 4]], 
            [[2, 7, 6], [9, 5, 1], [4, 3, 8]]
    ]

    
    let costArr = [];
    
    pre.forEach(square => {
        let cost = 0;

        for (let i = 0; i < 3; i++) 
            for (let j = 0; j < 3; j++)    
               cost +=  Math.abs(square[i][j] - s[i][j]);
                    
         
        costArr.push(cost);
    })

    return Math.min(...costArr);
}