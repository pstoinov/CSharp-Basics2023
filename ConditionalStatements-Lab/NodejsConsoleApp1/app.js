'use strict';

function kursovaZadacha(input) {
    let n = input[0];
    let sumEven = 0;
    for (i = 0; i < n.length; i++) {
        if (i % 2 === 0) {
            sumEven += Number(n[i]); //sum = sum + i

        }
    }
    //for (let i = 0; i < n.length; i++){
    //     sumNum = sumNum + Number(n[i]);
    // }
    console.log(sumEven);
}
kursovaZadacha(["221518123456"]);
