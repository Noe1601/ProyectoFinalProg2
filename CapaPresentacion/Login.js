Correo = document.getElementById('correo');
Usuario = document.getElementById('usuario');
Password = document.getElementById('password');

function Validar(){
if(Correo.value == "" || Usuario.value == "" || Password.value == ""){
    alert("The email, username and password fields are mandatory")
    event.preventDefault();
}

}