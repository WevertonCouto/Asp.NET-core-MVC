using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Alura.ListaLeitura.App.Logica
{
    public class HtmlUtils
    {
        public static string CarregaArquivoHtml(string v)
        {
            var nomeCompleto = $"View/{v}.html";
            using (var arquivo = File.OpenText(nomeCompleto))
            {
                return arquivo.ReadToEnd();
            }
        }
    }
}
