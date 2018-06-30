function elementGame(args) {

    let emptyArr = [];

    for (let obj of args) {

        let input = obj.split(" ");

        let command = input[0];
        let value = input[1];
        let indexToRemove = input[1];


        if (command === "add") {
            emptyArr.push(value);
        }
        if (command === "remove") {
            if (emptyArr.length < indexToRemove) {

            } else {
                emptyArr.splice(0, indexToRemove);
            }
        }
    }
        console.log(emptyArr.join('\n'));
}

// elementGame([
//     'add 3',
//     'add 5',
//     'add 7'
// ]);

elementGame([
    'add 3',
    'add 5',
    'remove 2',
    'remove 0',
    'add 7'
])