

<form method="get">
  MONTHL:<br>
  <input type="text" name="month"><br>
  <br>
  YEAR:<br>
  <input type="text" name="year"><br>
  <br>
  <input type="submit" value="GO">
</form>
<br> <br>

<?php
mysqli_report(MYSQLI_REPORT_ERROR | MYSQLI_REPORT_STRICT);
if(isset($_GET['month'], $_GET['year']))
{
include ("config.php");
$query = "call proc2_2 ('$_GET'month]', '$_GET[year]')";
echo "<br><br>";

$ver=mysqli_query($dbcon,$query);

if(!$ver){
echo "<P>Не вдалося виконати запит</P>";
exit(mysqli_error($dbcon));
}

echo "<P><B> Запит 1.4 </B></P>";
echo "<table border=1>";
while(list($NAME, $sec, $third, $forth) = mysqli_fetch_row($ver))
{
echo "<tr>
         <td> $NAME </td>
         <td> $sec </td>
         <td> $third </td>
         <td> $forth </td>
         </td>";
}

echo "</table>";
echo "<P>   </P>";

}
?>

<a href = 'Lab3_2.php'>Повернутись</a><br>