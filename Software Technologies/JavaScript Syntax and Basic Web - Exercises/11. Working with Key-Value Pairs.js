function keyValuePairs(args){

    let key = args.pop();
    let map = new Map();

    for (let obj of args) {

        let input = obj.split(" ");

        let key = input[0];
        let value = input[1];

        if (!map.has()) {
            map.set(key, []);
        }
        map.get(key).push(value);
    }
    console.log(map.has(key) ? map.get(key).join('\n') : "None");

       // if (map.has(key)) {
       //     console.log(map.get(key))
       // } else {
       //     console.log("None");
       // }
}

keyValuePairs([
    'key value',
    'key eulav',
    'test tset',
    'key'
]);