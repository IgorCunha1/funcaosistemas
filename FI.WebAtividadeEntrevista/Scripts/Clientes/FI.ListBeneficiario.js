
$(document).ready(function () {

    if (document.getElementById("gridBeneficiarios"))
        $('#gridBeneficiarios').jtable({
            title: 'Beneficiario',
            paging: true, //Enable paging
            pageSize: 5, //Set page size (default: 10)
            sorting: true, //Enable sorting
            defaultSorting: 'Nome ASC', //Set default sorting
            actions: {
                listAction: urlBeneficiarioList,
            },
            fields: {
                Nome: {
                    title: 'Nome',
                    width: '50%'
                },
                CPF: {
                    title: 'CPF',
                    width: '50%'
                },
                Alterar: {
                    title: '',
                    display: function (data) {
                        return '<button data-target="#alterarBeneficiario" onclick="editarBeneficiario('+data.record.Id+')" class="btn btn-primary btn-sm">Alterar</button>';
                }
                },
                Deletar: {
                    title: '',
                    display: function (data) {
                        return '<button id="btnDeletar" onclick="DeletarBeneficiario('+data.record.Id+')" class="btn btn-primary btn-sm">Deletar</button>';
                    }
                }
        }});

    //Load student list from server
    if (document.getElementById("gridBeneficiarios"))
        $('#gridBeneficiarios').jtable('load');
            
})

function editarBeneficiario(id) {
    
    $('#alterarBeneficiario').modal('show');
    $.ajax({
        url: urlAlteracao,
        method: "POST",
        data: {
           "id":id
        },
        error:
        function (r) {
            if (r.status == 400)
                ModalDialog("Ocorreu um erro", r.responseJSON);
            else if (r.status == 500)
                ModalDialog("Ocorreu um erro", "Ocorreu um erro interno no servidor.");
        },
        success:
        function (r) {
            console.log(r);
             $('#formAlterarBeneficiario #Nome').val(r.Records.Nome);
             $('#formAlterarBeneficiario #cpf').val(r.Records.CPF);
             $('#formAlterarBeneficiario #id').val(r.Records.Id);
    }});
}

function DeletarBeneficiario(id) {
    console.log(urlDeletarBeneficiario+'/'+id);
     $.ajax({
         url: urlDeletarBeneficiario,
         method: "POST",
         data: {
            "id":id
         },
         error:
         function (r) {
             if (r.status == 400)
                 ModalDialog("Ocorreu um erro", r.responseJSON);
             else if (r.status == 500)
                 ModalDialog("Ocorreu um erro", "Ocorreu um erro interno no servidor.");
         },
         success:
         function (r) {
             ModalDialog("Sucesso!", r)
                $("#formAlterarBeneficiario")[0].reset();
                window.location.href = urlBeneficiarioList;
         
     }});

     
};
