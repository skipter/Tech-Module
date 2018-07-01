function storingObjects(args) {

        let personInfo = [];

    for (let obj of args) {

        let input = obj.split(" -> ");

        let name = input[0];
        let age = input[1];
        let grade = input[2];

        let userInfo = {};

        userInfo['name'] = name;
        userInfo['age'] = age;
        userInfo['grade']= grade;

        personInfo.push(userInfo);
    }

    for (let person of personInfo) {
        console.log(`Name: ${person.name}`);
        console.log(`Age: ${person.age}`);
        console.log(`Grade: ${person.grade}`);
    }
}

storingObjects([
    'Pesho -> 13 -> 6.00',
    'Ivan -> 12 -> 5.57',
    'Toni -> 13 -> 4.90'
]);