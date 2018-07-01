function parseJsonObject(args) {

    for (let obj of args) {
        let input = JSON.parse(obj);

        console.log(`Name: ${input.name}`);
        console.log(`Age: ${input.age}`);
        console.log(`Date: ${input.date}`);
    }
}

parseJsonObject([
    '{"name":"Gosho","age":10,"date":"19/06/2005"}',
    '{"name":"Tosho","age":11,"date":"04/04/2005"}'
]);