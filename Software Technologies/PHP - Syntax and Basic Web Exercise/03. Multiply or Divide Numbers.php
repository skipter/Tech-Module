<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        N: <input type="text" name="num1" />
		M: <input type="text" name="num2" />
        <input type="submit" />
    </form>
	<?php
    $result = 0;
    if (isset($_GET['num1']) && isset($_GET['num2'])) {
        $firstNum = $_GET['num1'];
        $secondNum = $_GET['num2'];
        if ($_GET['num1'] <= $_GET['num2']) {
            $result = $firstNum * $secondNum;
            echo $result;
        } else {
            $result = $firstNum / $secondNum;
            echo $result;
        }
    }
    ?>
</body>
</html>