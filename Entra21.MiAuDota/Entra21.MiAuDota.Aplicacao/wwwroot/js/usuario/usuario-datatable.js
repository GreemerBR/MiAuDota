$('#tabela-usuarios').DataTable({
    language: {
        url: 'https://raw.githubusercontent.com/DataTables/Plugins/master/i18n/pt-BR.json'
    },
    ajax: {
        url: '/usuario/ObterTodosComFiltro',
        dataSrc: ''
    },
    processing: true,
    columns: [
        { data: 'nome' },
        { data: 'celular' },
        { data: 'email' }
    ],
});