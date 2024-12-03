document.getElementById('btnConsultar').addEventListener('click', leerForm);


//document.querySelector('#Forms').preventDefault();

function leerForm(){
        let id = document.querySelector('#id').value;

    if(id == null || id == "" || id == " "){
        alert("Ingrese un ID por favor "+id);
    }else{
        //alert("id "+id);
        if(document.querySelector('#btnConsultar').value == "Consultar"){
            document.querySelector('#id').disabled= true;
            document.querySelector('#nombre').disabled= false;
            document.querySelector('#nombre').value = "Jose Emmanuel"
            document.querySelector('#edad').disabled= false;
            document.querySelector('#edad').value= "24 años";
            document.querySelector('#EstOri').disabled= false;
            document.querySelector('#EstaOriOpt').innerHTML= "VERACRUZ";
            document.querySelector('#EstaCheck').checked= true;
    
            document.querySelector('#btnConsultar').innerHTML = "Guardar";
            document.querySelector('#btnConsultar').value = "Guardar";

        }else{
            alert("Actualización Exitosa");
            location.reload();





            /*
            document.querySelector('#id').disabled= false;
            document.querySelector('#nombre').disabled= true;
            document.querySelector('#nombre').value = ""
            document.querySelector('#edad').disabled= true;
            document.querySelector('#edad').value= "";
            document.querySelector('#EstOri').disabled= true;
            document.querySelector('#EstaOriOpt').innerHTML= "";
            document.querySelector('#EstaCheck').checked= false;
    
            document.querySelector('#btnConsultar').innerHTML = "Consultar";
            document.querySelector('#btnConsultar').value = "Consultar";
            */
        }



    }

}
