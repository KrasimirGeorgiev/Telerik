'use strict';
function solve(params) {
     var n = parseInt(params[0]),
        k = parseInt(params[1]),
        numbers = params[2].split(' ').map(Number),
        result = [],
        stop = false;

       for (var i = 0; i < n; i++) {
           var currentMin = 1000000000,
               currentMax = -1000000000;
           for (var j = i; j < i + k; j++) {
               var currentElement = numbers[j];
               if (i + k > n) {
                   stop = true;
                   break;
               }

               if (currentMax < currentElement) {
                   currentMax = currentElement;
               }

               if (currentMin > currentElement) {
                   currentMin = currentElement;
               }
           }

           if (stop) {
               break;
           }

           result.push(currentMin + currentMax);
       }
     console.log(result.join(','));   
} 

let par = [];
par.push('8');
par.push('4');
par.push('1 8 8 4 2 9 8 11');
solve(par);