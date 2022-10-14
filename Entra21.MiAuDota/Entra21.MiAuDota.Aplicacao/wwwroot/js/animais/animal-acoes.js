$('table').on('click', '.animal-editar', (event) => {
    let element = event.target.tagName === 'I'
        ? event.target.parentElement
        : event.target;

    animalEditar(element);
});

$('table').on('click', '.animal-obterPorId', (event) => {
    let element = event.target.tagName === 'I'
        ? event.target.parentElement
        : event.target;

    animalObterPorId(element);
});

let animalEditar = (element) => {
    debugger;
    let id = element.getAttribute("data-id");

    let formData = new FormData();
    formData.append("id", id);

    fetch('/protetores/animal/editar', {
        method: "POST",
        body: formData
    })
        .then((data) => {
            console.log(data);

            $('#tabela-animais').DataTable().ajax.reload();

            toastr.success('Animal editado com sucesso');
        })
        .catch((error) => {
            console.error(error);

            toastr.error('Não foi possível editar o animal');
        })
}

let animalObterPorId = (element) => {
    debugger;
    let id = element.getAttribute("data-id");

    let formData = new FormData();
    formData.append("id", id);

    fetch('/protetores/animal/obterPorId', {
        method: "GET",
        body: formData
    })
        .then((data) => {
            console.log(data);

            $('#tabela-animais').DataTable().ajax.reload();

            toastr.success('Abrindo a tela de dados do animal');
        })
        .catch((error) => {
            console.error(error);

            toastr.error('Não foi possível abrir a tela de dados do animal');
        })
}