<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
    <style>
        div {
            display: inline-block;
            margin: 5px;
            width: 20px;
            height: 20px;
        }
    </style> 
</head>
<body>
<?php
        for ($i = 0; $i < 5; $i++) {
            for ($j = 0; $j < 10; $j++) {

                $color = $i * 51;

                if ($i == 0) {
                    echo "<div style='background-color: rgb($color,$color,$color)'></div>";
                    $color += 5;

                } else if ($i == 1) {
                    echo "<div style='background-color: rgb($color,$color,$color)'></div>";
                    $color += 5;

                } else if ($i == 2) {
                    echo "<div style='background-color: rgb($color,$color,$color)'></div>";
                    $color += 5;

                } else if ($i == 3) {
                    echo "<div style='background-color: rgb($color,$color,$color)'></div>";
                    $color += 5;

                } else if ($i == 4) {
                    echo "<div style='background-color: rgb($color,$color,$color)'></div>";
                    $color += 5;

                } else if ($i == 5) {
                    echo "<div style='background-color: rgb($color,$color,$color)'></div>";
                    $color += 5;
                }
            }
            echo "<br />";
        }
?>
</body>
</html>