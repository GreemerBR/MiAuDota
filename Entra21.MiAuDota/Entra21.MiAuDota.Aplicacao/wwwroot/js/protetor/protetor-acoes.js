$('table').on('click', '.protetor-alterarStatus', (event) => {
    let element = event.target.tagName === 'I'
        ? event.target.parentElement
        : event.target;

    protetorAlterarStatus(element);
});

$('#animais').on('click', '.protetor-modalProtetor', (event) => {
    let element = event.target.tagName === 'I'
        ? event.target.parentElement
        : event.target;

    visualizarProtetorModal(element);
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

let visualizarProtetorModal = (botaoProtetor) => {
    let id = botaoProtetor.getAttribute('data-id');
    let statusResponse = 0;

    fetch(`/protetor/obterPorId?id=${id}`)
        .then((response) => {
            statusResponse = response.status;

            return response.json();
        })
        .then((data) => {
            if (statusResponse === 200) {
                let modal = new bootstrap.Modal(document.getElementById('modalProtetor'), {});
                
                document.getElementById('modalProtetorLabel').innerText = `Protetor: ${data.nome}`
                document.getElementById('modalProtetorId').value = data.id;
                document.getElementById('modalProtetorEndereco').value = data.endereco;
                document.getElementById('modalProtetorCelular').value = data.celular;
                document.getElementById('modalProtetorTelefone').value = data.telefone;
                document.getElementById('modalProtetorInstagram').value = data.instagram;
                document.getElementById('modalProtetorFacebook').value = data.facebook;

                modal.show();
            }
        })
        .catch((error) => console.log(error));
};