<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>
    <?php
    if (isset($_GET['num'])) {
        $f1 = 1;
        $f2 = 1;
        $fib = $f1 + $f2;

        $num = $_GET['num'];

        $numbers = array(1,1,2);

        echo $f1 . " ";
        echo $f2 . " ";
        echo $fib . " ";

        for ($i = 3; $i < $num; $i++) {
            $f1 = $f2;
            $f2 = $fib;
            $fib = $f1 + $f2;
            echo $fib . " ";
        }
    }
    ?>
</body>
</html>