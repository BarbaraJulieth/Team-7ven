$(document).ready( function () {
    $('#tablaCoaches').DataTable();
    $('#tablaNutris').DataTable();
    $('#tablaPacientes').DataTable();
    $('#tableRegiNutri').DataTable();
    $('#tablaSeguiNutri').DataTable();
    
    var pathname = window.location.pathname;

    alert(pathname);

    if(pathname=="/"){
        $("#headerPrincipal").hide();
    }else{
        $("#footerPrincipal").hide();
    }

    
  
    
} );