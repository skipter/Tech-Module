function solve([n]) {

    n = Number(n);

    for (i = 1; i <= n; i++) {
        let numberAsString = '' + i;
        if (numberAsString == [...numberAsString].reverse().join('')) {
            console.log(i)
        }
    }
}

console.log(solve(['750']));