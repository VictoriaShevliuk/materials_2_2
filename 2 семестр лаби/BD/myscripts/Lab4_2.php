<form method="get">
  Lastdays:<br>
  <input type="text" name="lastdays"><br>
  <br>
  <input type="submit" value="GO">
</form>
<br> <br>

<?php
mysqli_report(MYSQLI_REPORT_ERROR | MYSQLI_REPORT_STRICT);
if(isset($_GET['lastdays']))
{
include ("config.php");
$query = "call proc1_6 ('$_GET[lastdays]')";
echo "<br><br>";

$ver=mysqli_query($dbcon,$query);

if(!$ver){
echo "<P>Не вдалося виконати запит</P>";
exit(mysqli_error($dbcon));
}

echo "<P><B> Запит 1.6 </B></P>";
echo "<table border=1>";
while(list($fullTechName, $fullProdName, $KIL, $DATAOPL, $DATAPROPL) = mysqli_fetch_row($ver))
{
echo "<tr>
         <td> $fullTechName </td>
         <td> $fullProdName </td>
         <td> $KIL </td>
         <td> $DATAOPL </td>
         <td> $DATAPROPL </td>
         </td>";
}

echo "</table>";
echo "<P>   </P>";

}
?>

<a href = 'Lab3_2.php'>Повернутись</a><br>