namespace Entra21.MiAuDota.Servico.Helpers;

public static class ArquivoHelper
{
    private const string PastaPai = "Uploads";
    private const string PastaImagens = "Animais";

    public static string ObterCaminhoPastas() =>
        Path.Join(PastaPai, PastaImagens);

    public static string ObterCaminhoArquivo(string nomeArquivo) =>
        Path.Join(ObterCaminhoPastas(), nomeArquivo);

    public static string ObterCaminhoArquivoServidor(string nomeArquivo, string caminhoServidor) =>
        Path.Join(caminhoServidor, ObterCaminhoPastas(), nomeArquivo);
}