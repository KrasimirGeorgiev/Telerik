'use strict';
function solve(params) {
    let nk = params[0].split(' ').map(Number),
        s = params[1].split(' ').map(Number),
        result,
        count = 0;
    while (count < nk[1]) {
        let arr = [];
        for (var i = 0; i < nk[0]; i++) {
            let element = +s[i],
                min = i - 1,
                max = i + 1;
               
            if (max === nk[0]) {
                max = 0;
            }    

            if (min < 0) {
                min = nk[0] - 1;
            }    

            if (element === 0) { // absolute difference of neighbours
                element = Math.abs(s[min] - s[max]);
            } else if (element === 1) { // sum of neighbours
                element = s[min] + s[max];
            } else if (element % 2 === 0) { // max of neighbours
                element = Math.max(s[min], s[max]);
            } else if (element % 2 !== 0){ // min of neighbours
                element = Math.min(s[min], s[max]);
            }

            arr.push(element);
        }
        s = [];
        s = arr.slice();
        count++;
    }

    result = s.reduce(function(a, b) { return a + b; }, 0);
    console.log(result);    
} 

let par = [];
par.push('5 1');
par.push('9 0 2 4 1');
solve(par);