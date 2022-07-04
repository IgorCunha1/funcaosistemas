$(document).ready(function () {
    $('#cpf').mask('000.000.000-00');

});

 $('#cpf').blur(function(){
     var cpf = $('#cpf').val();
     var msg_error = $('#msg_error');
    
     if(cpf.length < 14){
        msg_error.html('<div class="alert alert-danger" role="alert">Cpf precisa ter 11 digitos</div>');
    }else{
        msg_error.html('')
     }
    
 });
