﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDoisInterface
{
    internal class EnviarNotificacaoWhatsapp : IEnviarNotificacao
    {
        public void EnviarMensagemCliente()
        {
            Console.WriteLine("Estou enviando uma mensagem no WhatsApp do Cliente!");
        }
    }
}
