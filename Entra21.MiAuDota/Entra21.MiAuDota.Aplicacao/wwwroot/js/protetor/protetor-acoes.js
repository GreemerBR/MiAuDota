$('table').on('click', '.protetor-alterarStatus', (event) => {
    let element = event.target.tagName === 'I'
        ? event.target.parentElement
        : event.target;

    protetorAlterarStatus(element);
});

let protetorAlterarStatus = (element) => {
    debugger;
    let id = element.getAttribute("data-id");

    let formData = new FormData();
    formData.append("id", id);

    fetch('/administradores/protetor/alterarStatus', {
        method: "POST",
        body: formData
    })
        .then((data) => {
            console.log(data);

            $('#tabela-protetores').DataTable().ajax.reload();

            toastr.success('Conta do protetor ativada com sucesso');
        })
        .catch((error) => {
            console.error(error);

            toastr.error('Não foi possível ativar a conta do protetor');
        })
}