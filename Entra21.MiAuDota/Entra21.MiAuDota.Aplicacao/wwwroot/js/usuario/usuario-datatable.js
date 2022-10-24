$('#tabela-usuarios').DataTable({
    language: {
        url: 'https://raw.githubusercontent.com/DataTables/Plugins/master/i18n/pt-BR.json'
    },
    ajax: {
        url: '/usuario/ObterTodos',
        dataSrc: ''
    },
    processing: true,
    columns: [
        { data: 'id' },
        { data: 'nome' },
        { data: 'celular' },
        { data: 'email' },
        {
            data: null,
            render: function (data, type, usuario) {
                let cor = '';
                let status = '';
                if (usuario.ehVoluntario === false) {
                    status = "Não";
                    cor = "danger";
                } else {
                    status = "Sim";
                    cor = "success";
                }
                return `<h5><span class="badge bg-${cor}">${status}</span></h5>`;
            },
        }
    ],
});