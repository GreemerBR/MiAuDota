$('table').on('click', '.animal-obterPorId', (event) => {
    let element = event.target.tagName === 'I'
        ? event.target.parentElement
        : event.target;

    animalObterPorId(element);
});

$('table').on('click', '.animal-modalEditar', (event) => {
    let element = event.target.tagName === 'I'
        ? event.target.parentElement
        : event.target;

    editarPreencherModal(element);
});

let editarPreencherModal = (botaoEditar) => {
    let id = botaoEditar.getAttribute('data-id');
    let statusResponse = 0;

    fetch(`/protetores/animal/obterPorId?id=${id}`)
        .then((response) => {
            statusResponse = response.status;

            return response.json();
        })
        .then((data) => {
            if (statusResponse === 200) {
                let modal = new bootstrap.Modal(document.getElementById('editarModal'), {});

                document.getElementById('editarModalLabel').innerText = `Editar animal: ${data.nome}`
                document.getElementById('editarModalId').value = data.id;
                document.getElementById('editarModalNome').value = data.nome;
                document.getElementById('editarModalRaca').value = data.raca;
                document.getElementById('editarModalEspecie').value = data.especie;
                document.getElementById('editarModalSobre').value = data.sobre;
                document.getElementById('editarModalVacinas').value = data.vacinas;
                document.getElementById('editarModalAlergias').value = data.alergias;
                document.getElementById('editarModalOutrasInformacoes').value = data.outrasInformacoesMedicas;                
                document.getElementById('editarModalFotoCampoImg').src = "/Uploads/Animais/" + data.foto;
                document.getElementById('editarModalIdade').value = data.idade;
                document.getElementById('editarModalPeso').value = data.peso;
                document.getElementById('editarModalAltura').value = data.altura;
                document.getElementById('editarModalDataAdocao').value = data.dataAdocao;
                document.getElementById('editarModalStatus').value = data.status;
                document.getElementById('editarModalUsuarioId').value = data.usuarioId;
                if (data.genero === 0)
                    document.getElementById('editarModalDataGeneroF').checked = true;
                else
                    document.getElementById('editarModalDataGeneroM').checked = true;
                if (data.cadastro === 0)
                    document.getElementById('editarModalCastradoS').checked = true;
                else
                    document.getElementById('editarModalCastradoN').checked = true;

                modal.show();
            }
        })
        .catch((error) => console.log(error));
};

let animalObterPorId = (botaoObterPorId) => {
    let id = botaoObterPorId.getAttribute('data-id');
    let statusResponse = 0;

    fetch(`/protetores/animal/obterPorId?id=${id}`)
        .then((response) => {
            statusResponse = response.status;

            return response.json();
        })
        .then((data) => {
            if (statusResponse === 200) {
                let modal = new bootstrap.Modal(document.getElementById('visualizarModal'), {});

                document.getElementById('editarModalLabel').innerText = `Editar animal: ${data.nome}`
                document.getElementById('editarModalId').value = data.id;
                document.getElementById('editarModalNome').value = data.nome;
                document.getElementById('editarModalRaca').value = data.raca;
                document.getElementById('editarModalEspecie').value = data.especie;
                document.getElementById('editarModalSobre').value = data.sobre;
                document.getElementById('editarModalVacinas').value = data.vacinas;
                document.getElementById('editarModalAlergias').value = data.alergias;
                document.getElementById('editarModalOutrasInformacoes').value = data.outrasInformacoesMedicas;
                document.getElementById('editarModalFotoCampoImg').src = "/Uploads/Animais/" + data.foto;
                document.getElementById('editarModalIdade').value = data.idade;
                document.getElementById('editarModalPeso').value = data.peso;
                document.getElementById('editarModalAltura').value = data.altura;
                document.getElementById('editarModalDataAdocao').value = data.dataAdocao;
                document.getElementById('editarModalStatus').value = data.status;
                document.getElementById('editarModalPorte').value = data.porte;
                document.getElementById('editarModalUsuarioId').value = data.usuarioId;
                if (data.genero === 0)
                    document.getElementById('editarModalDataGeneroF').checked = true;
                else
                    document.getElementById('editarModalDataGeneroM').checked = true;
                if (data.cadastro === 0)
                    document.getElementById('editarModalCastradoS').checked = true;
                else
                    document.getElementById('editarModalCastradoN').checked = true;

                modal.show();
            }
        })
        .catch((error) => console.log(error));
};