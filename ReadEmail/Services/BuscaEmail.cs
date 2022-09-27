using OpenPop.Mime;
using OpenPop.Mime.Header;
using OpenPop.Pop3;
using ELEmail.Models;

namespace ELEmail.Services
{
    public class BuscaEmail
    {
        public async Task<List<CorpoEmail>> Buscar(string nome_servidor_pop, int porta, string email, string senha)
        {
            var emailT = new List<CorpoEmail>();
            string text = "";
            // A instrução using faz a desconexão do servidor de email
            // e libera corretamente o objeto
            using (Pop3Client cliente_pop = new Pop3Client())
            {
                // Faz a conexão com o servidor
                cliente_pop.Connect(nome_servidor_pop, porta, true);

                // Faz a autenticação no servidor
                cliente_pop.Authenticate(email, senha,
                    AuthenticationMethod.UsernameAndPassword);

                // Obtêm o número total de emails da caixa de entrada
                int numero_emails = cliente_pop.GetMessageCount();

                // Faz a leitura dos 10 emails mais recentes da caixa de entrada,
                // iniciando a partir do último email recebido.
                for (int i = 0; i < numero_emails; i++)
                {
                    CorpoEmail corpoEmail = new CorpoEmail();

                    // Cabeçalho da mensagem
                    MessageHeader headers = cliente_pop.GetMessageHeaders(numero_emails);

                    // Email De:
                    RfcMailAddress emailDe = headers.From;

                    // Email Para:
                    // Faz a leitura de todos os emails Para, mas exibe somente o primeiro.
                    List<RfcMailAddress> emailParaList = headers.To;
                    string emailPara = string.Empty;
                    if (emailParaList != null && emailParaList.Count() > 0)
                    {
                        emailPara = emailParaList.First().Address;
                    }

                    // Assunto
                    string assunto = headers.Subject;

                    // Data de envio
                    DateTime data_envio = headers.DateSent;

                    // Verifica se o endereço de email De é válido
                    if (emailDe.HasValidMailAddress)
                    {
                        // Corpo do email
                        Message mensagem = cliente_pop.GetMessage(numero_emails);
                        MessagePart corpo_email = mensagem.FindFirstPlainTextVersion();
                        if (corpo_email != null)
                        {
                            text = corpo_email.GetBodyAsText();
                        }

                        // Imprime as informações do email
                        corpoEmail.De = emailDe.ToString();
                        corpoEmail.Para = emailPara;
                        corpoEmail.Assunto = assunto;
                        corpoEmail.DataEnvio = data_envio;
                        corpoEmail.Body =  text;

                        emailT.Add(corpoEmail);
                        // Decrementa o número de emails
                        numero_emails--;
                    }
                }
            }

            return emailT;
        }
    }
}
