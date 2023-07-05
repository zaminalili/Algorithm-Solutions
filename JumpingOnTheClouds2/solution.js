function jumpingOnClouds(c) {
    
    let jumpNumber = 0;
    let minNumberofJumps = 0;

    while(jumpNumber < c.length-1){

        if(c[jumpNumber+2] == 0){
            jumpNumber += 2;
            minNumberofJumps++;
        }
        else if(c[jumpNumber+1] == 0){
            jumpNumber += 1;
            minNumberofJumps++;
        }

    }

    return minNumberofJumps;

}

let c = [0, 0, 1, 0, 0, 1, 0];
let c2 = [0, 0, 0, 0, 1, 0];
let c3 = [0, 1, 0, 0, 0, 1, 0];

console.log(jumpingOnClouds(c3));