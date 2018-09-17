function findProduct (args) {

   let counter = 0;

   let [x, y, z] = args.map(Number);

   if (x === 0 || y === 0 || z === 0) {
       console.log("Positive");
       return;
   }

   [x, y, z,].forEach(n => {
       if (n < 0) {
           counter++;
       }
   });
    if (counter % 2 === 0) {
        console.log("Positive");
    } else {
        console.log("Negative");
    }
}

findProduct([2, 3, -1]);
findProduct([5, 4, 3]);
findProduct([-3, -4, 5]);
findProduct([2, 1, -1]);