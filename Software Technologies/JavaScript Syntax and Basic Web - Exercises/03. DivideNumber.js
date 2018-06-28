function solve(args) {

    let n = args[0];
    let x = args[1];

    if(x >= n) {
        console.log(x * n);
    } else {
       console.log(n / x);
    }
}

solve([2, 3]);
solve([13, 13]);
solve([3, 2]);
solve([144, 12]);
