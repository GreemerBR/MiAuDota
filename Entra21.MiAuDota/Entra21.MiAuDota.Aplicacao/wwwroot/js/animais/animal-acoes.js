$('table').on('click', '.animal-modalEditar', (event) => {
    let element = event.target.tagName === 'I'
        ? event.target.parentElement
        : event.target;

    editarPreencherModal(element);
});

$('table').on('click', '.animal-modalVisualizar', (event) => {
    let element = event.target.tagName === 'I'
        ? event.target.parentElement
        : event.target;

    visualizarPreencherModal(element);
});

$('#animais').on('click', '.animal-modalAnimal', (event) => {
    let element = event.target.tagName === 'I'
        ? event.target.parentElement
        : event.target;

    visualizarAnimalModal(element);
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
                document.getElementById('editarModalFotoCampoImg').src = "/Uploads/Animais/" + data.foto;
                document.getElementById('editarModalIdade').value = data.idade;
                document.getElementById('editarModalPeso').value = data.peso;
                document.getElementById('editarModalAltura').value = data.altura;
                document.getElementById('editarModalDataAdocao').value = data.dataAdocao;
                document.getElementById('editarModalStatus').value = data.status;
                document.getElementById('editarModalUsuarioId').value = data.usuarioId;
                document.getElementById('editarModalGenero').value = data.genero;
                if (data.cadastro === 0)
                    document.getElementById('editarModalCastradoS').checked = true;
                else
                    document.getElementById('editarModalCastradoN').checked = true;

                modal.show();
            }
        })
        .catch((error) => console.log(error));
};

let visualizarPreencherModal = (botaoVisualizar) => {
    let id = botaoVisualizar.getAttribute('data-id');
    let statusResponse = 0;

    fetch(`/protetores/animal/obterPorId?id=${id}`)
        .then((response) => {
            statusResponse = response.status;

            return response.json();
        })
        .then((data) => {
            if (statusResponse === 200) {
                let modal = new bootstrap.Modal(document.getElementById('visualizarModal'), {});
                debugger;

                document.getElementById('visualizarModalLabel').innerText = `Animal: ${data.nome}`
                document.getElementById('visualizarModalId').value = data.id;
                document.getElementById('visualizarModalRaca').value = data.raca;
                document.getElementById('visualizarModalEspecie').value = data.especie;
                document.getElementById('visualizarModalSobre').value = data.sobre;
                document.getElementById('visualizarModalFotoCampoImg').src = "/Uploads/Animais/" + data.foto;
                document.getElementById('visualizarModalIdade').value = data.idade;
                document.getElementById('visualizarModalPeso').value = data.peso;
                document.getElementById('visualizarModalAltura').value = data.altura;
                document.getElementById('visualizarModalDataAdocao').value = data.dataAdocaoFormatada;
                if (data.genero === 0)
                    document.getElementById('visualizarModalDataGeneroF').checked = true;
                else
                    document.getElementById('visualizarModalDataGeneroM').checked = true;
                if (data.castrado == 1)
                    document.getElementById('visualizarModalCastradoS').checked = true;
                else
                    document.getElementById('visualizarModalCastradoN').checked = true;

                modal.show();
            }
        })
        .catch((error) => console.log(error));
};

let visualizarAnimalModal = (botaoAnimal) => {
    let id = botaoAnimal.getAttribute('data-id');
    let statusResponse = 0;

    fetch(`/animal/obterPorId?id=${id}`)
        .then((response) => {
            statusResponse = response.status;

            return response.json();
        })
        .then((data) => {
            if (statusResponse === 200) {
                let modal = new bootstrap.Modal(document.getElementById('modalAnimal'), {});

                document.getElementById('modalAnimalLabel').innerText = `Animal: ${data.nome}`
                document.getElementById('modalAnimalId').value = data.id;
                document.getElementById('modalAnimalRaca').value = data.raca;
                document.getElementById('modalAnimalEspecie').value = data.especie;
                document.getElementById('modalAnimalSobre').value = data.sobre;
                document.getElementById('modalAnimalFotoCampoImg').src = "/Uploads/Animais/" + data.foto;
                document.getElementById('modalAnimalIdade').value = data.idade;
                document.getElementById('modalAnimalPeso').value = data.peso;
                document.getElementById('modalAnimalAltura').value = data.altura;
                if (data.genero === 0)
                    document.getElementById('modalAnimalDataGeneroF').checked = true;
                else
                    document.getElementById('modalAnimalDataGeneroM').checked = true;
                if (data.castrado == 1)
                    document.getElementById('modalAnimalCastradoS').checked = true;
                else
                    document.getElementById('modalAnimalCastradoN').checked = true;

                modal.show();
            }
        })
        .catch((error) => console.log(error));
};