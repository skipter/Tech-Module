function print(args) {

    let number = Number(args[0]);

    for (let i = number; i >= 1; i--) {
        console.log(i);
    }
}

print(['5']);
print(['2']);