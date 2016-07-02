'use strict';
function solve(params) {
     var s = params[0], c1 = params[1], c2 = params[2], c3 = params[3],
         answer = 0;
         
     for (var i = 0; i < s / c1 + 1; i++) {
         for (var j = 0; j < s / c2 + 1; j++) {
             for (var k = 0; k < s / c3 + 1; k++) {
                 var smetkata = c1 * i + c2 * j + c3 * k;
                 if (smetkata <= s) {
                     answer = Math.max(answer, smetkata);
                 } else {
                     break;
                 }
             }
             
         }
         
     }
          
             


 console.log(answer);
} 

let par = [];
par.push('8');
par.push('4');
par.push('1 8 8 4 2 9 8 11');
solve(par);