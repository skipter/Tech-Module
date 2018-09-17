<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
<?php

    for ($i = 0; $i < 9; $i++) {
        for ($e = 0; $e < 5; $e++) {

            if ($i % 4 == 0) {
                echo "<button style = 'background-color: blue'>1</button>";
            } else if ($e == 0 && $i < 4) {
                echo "<button style = 'background-color: blue'>1</button>";
            } else if ($e == 4 && $i >= 4){
                echo "<button style = 'background-color: blue'>1</button>";
            } else {
                echo "<button> 0 </button>";
            }
        }
        echo "<br />";
    }
?>
</body>
</html>