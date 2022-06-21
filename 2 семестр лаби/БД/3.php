

<?php
mysqli_report(MYSQLI_REPORT_ERROR | MYSQLI_REPORT_STRICT);

{
include ("config1.php");
$query = "SELECT dovid_distr.NAME_DISTR 
from dovid_distr
left join zamov_tovar on dovid_distr.KOD_DISTR = zamov_tovar.KOD_DISTR
where dovid_distr.NAME_DISTR not in (
  select dovid_distr.NAME_DISTR 
    from dovid_distr, dovid_tovar, vmist_zamov, zamov_tovar
    where(
    dovid_tovar.NAME_TOVAR like'%Calligaris%'
    and dovid_distr.KOD_DISTR = zamov_tovar.KOD_DISTR
  and zamov_tovar.NUM_ZAMOV = vmist_zamov.NUM_ZAMOV
  and vmist_zamov.KOD_TOVAR = dovid_tovar.KOD_TOVAR
    )
)
group by dovid_distr.NAME_DISTR;";
echo "<br><br>";

$ver=mysqli_query($dbcon,$query);

if(!$ver){
echo "<P>Не вдалося виконати запит</P>";
exit(mysqli_error($dbcon));
}

echo "<P><B> Завдання 3 </B></P>";
echo "<table border=1>";
while(list($NAME_DISTR) = mysqli_fetch_row($ver))
{
echo "<tr>
         <td> $NAME_DISTR </td>
         </td>";
}

echo "</table>";
echo "<P>   </P>";

}
?>

