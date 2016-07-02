'use strict';
function solve(params) {
     var lenghts = params[0].split(' ').map(Number),
         rows = lenghts[0],
         cols = lenghts[1],
         steps = [],
         matrix = [],
         count = 0,
         sum = 0;

     for (var i = 1; i <= rows; i++) {
         var currArr = params[i].split('');
         steps.push(currArr);
     }    

     for (var i = 0; i < rows; i++) {
         var num = Math.pow(2, i),
             currArr = []; 

         for (var j = 0; j < cols; j++) {
             currArr.push(num - j);
         }
         matrix.push(currArr);
     }
     var initialPossitionRow = rows - 1,
         initialPossitionCol = cols - 1;
     // steps
     // matrix  
     var code; 
     while (true) {
         
         if (initialPossitionRow < 0 || initialPossitionRow >= rows || initialPossitionCol < 0 || initialPossitionCol >= cols) {
             console.log('Go go Horsy! Collected ' + sum + ' weeds');
             break;
         }

         if (matrix[initialPossitionRow][initialPossitionCol] === undefined) {
             console.log('Sadly the horse is doomed in ' + count + ' jumps');
             break;
         }
         sum += matrix[initialPossitionRow][initialPossitionCol];
         matrix[initialPossitionRow][initialPossitionCol] = undefined;
         code = +steps[initialPossitionRow][initialPossitionCol];
         count++;
         switch (code) {
             case 1: initialPossitionRow -= 2;
                     initialPossitionCol += 1;
                     break;
             case 2: initialPossitionRow -= 1;
                     initialPossitionCol += 2;
                     break;
             case 3: initialPossitionRow += 1;
                     initialPossitionCol += 2;
                     break;
             case 4: initialPossitionRow += 2;
                     initialPossitionCol += 1;
                     break;
             case 5: initialPossitionRow += 2;
                     initialPossitionCol -= 1;
                     break;
             case 6: initialPossitionRow += 1;
                     initialPossitionCol -= 2;
                     break;
             case 7: initialPossitionRow -= 1;
                     initialPossitionCol -= 2;
                     break;
             case 8: initialPossitionRow -= 2;
                     initialPossitionCol -= 1;
                     break;
         
             default: console.log('error in the switch');
                 break;
         }
     }

     
     // let answer = printArr(matrix, rows, cols);
 // console.log(answer);
} 

function printArr(arr, rows, cols) {
    let result = '';
    for (var i = 0; i < rows; i++) {
        for (var j = 0; j < cols; j++) {
            result += arr[i][j];
            if (j < cols - 1) {
                result += ' ';
            }
        }
        result += '\n';
    }

    return result;
}

let args = [
 '3 5',
 '54561',
 '43328',
 '52388',
]; 

let args2 =  [
 '3 5',
 '54361',
 '43326',
 '52188',
];

solve(args);
solve(args2);
