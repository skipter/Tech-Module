function reverseOrder(args) {

    args.reverse();
    for (let i=0; i < args.length; i++) {
        console.log(args[i]);
    }
}


reverseOrder([
    '10',
    '15',
    '20'
]);
reverseOrder([
    '5',
    '5.5',
    '24',
    '-3'
]);