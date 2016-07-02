'use strict';
function solve(params) {
    let arr = params[0].split(' ').map(Number),
        peaks = [],
        valleys = [],
        maxStones = 0,
        currentStones = 0,
        result;
    
        let len = arr.length;
        for (var i = 0; i < len; i++) {
            var element = arr[i];
            if (i === 0) {
                if (element > arr[i + 1]) {
                    peaks.push(i);
                } else if (element < arr[i + 1]) {
                    valleys.push(i);
                }
            } else if (i === len - 1) {
                if (element > arr[i - 1]) {
                    peaks.push(i);
                } else if (element < arr[i - 1]) {
                    valleys.push(i);
                }
            } else {
                if (element > arr[i - 1] && element > arr[i+1]){
                    peaks.push(i);
                } else if (element < arr[i - 1] && element < arr[i+1]) {
                    valleys.push(i);
                }
            }    
        }

        for (var i = 0; i < valleys.length; i++) {
            let currentValley = valleys[i];
            for (var j = 0; j < peaks.length - 1; j++) {
                let currentPeak = peaks[j],
                    oneMorePeak = peaks[j + 1];
                if (currentValley > currentPeak && currentValley < oneMorePeak) {
                    currentStones = (currentValley - currentPeak) + (oneMorePeak - currentValley);
                    break;
                }
            }

            if (currentStones > maxStones) {
                maxStones = currentStones;
            }
        }

    console.log(maxStones);    
}

solve(['5 1 7 4 8']);