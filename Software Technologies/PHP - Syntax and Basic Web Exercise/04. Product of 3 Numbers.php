<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        X: <input type="text" name="num1" />
		Y: <input type="text" name="num2" />
        Z: <input type="text" name="num3" />
		<input type="submit" />
    </form>
    <?php
    if (isset($_GET['num1']) && isset($_GET['num2']) && isset($_GET['num2'])) {

        $firstNum = $_GET['num1'];
        $secondNUm = $_GET['num2'];
        $thirdNum = $_GET['num3'];

        $positiveCounter = 0;
        $negativeCounter = 0;

        if ($firstNum == 0) {
            echo "Positive";
            return;
        } else if ($secondNUm == 0) {
            echo  "Positive";
            return;
        } else if ($thirdNum == 0) {
            echo "Positive";
            return;
        }

        if ($firstNum < 0) {
            $negativeCounter++;
        }

        if ($secondNUm < 0) {
            $negativeCounter++;
        }

        if ($thirdNum < 0) {
            $negativeCounter++;
        }

        if ($negativeCounter % 2 == 0) {
            echo "Positive";
        } else {
            echo "Negative";
        }
    }
    ?>
</body>
</html>