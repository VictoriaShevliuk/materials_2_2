<form method="get">
  Production_name:<br>
  <input type="text" name="myprod"><br>
  <br>
  <input type="submit" value="GO">
</form>
<br> <br>

<?php
mysqli_report(MYSQLI_REPORT_ERROR | MYSQLI_REPORT_STRICT);
if(isset($_GET['myprod']))
{
include ("config.php");
$query = "call proc2_1 ('$_GET[myprod]')";
echo "<br><br>";

$ver=mysqli_query($dbcon,$query);

if(!$ver){
echo "<P>Не вдалося виконати запит</P>";
exit(mysqli_error($dbcon));
}

echo "<P><B> Запит 2.1 </B></P>";
echo "<table border=1>";
while(list($NAME, $fullAMOUNT, $fullREALISATION) = mysqli_fetch_row($ver))
{
echo "<tr>
         <td> $NAME </td>
         <td> $fullAMOUNT </td>
         <td> $fullREALISATION </td>
         </td>";
}

echo "</table>";
echo "<P>   </P>";

}
?>

<a href = 'Lab3_2.php'>Повернутись</a><br>