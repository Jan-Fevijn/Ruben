<?php
//  table tag opened
if (isset($_GET['rows']) && isset($_GET['coloms'])) {
    $string = "<table border='1'><tbody>" ;

    for ($row = 1; $row <= $_GET['rows']; $row++) {
        $string = $string . " <tr> ";


        for ($I = 1; $I <= $_GET['coloms']; $I++) {
            if ( isset($_GET['headerTop'])  && $row == 1 ) {
                 $string = $string . " 
            <th> 
            text in colom $I row $row
            </th>";
            } else {
            $string = $string . " 
            <td> 
            text in colom $I row $row
            </td>";
            }
        }


        $string = $string . "
   </tr>";
      }


// table tag closed
    $string = $string . "
</tbody>
</table>
    " ;
} else {
    $string = "nope" ;
}

?>