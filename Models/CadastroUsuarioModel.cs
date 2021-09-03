using System;

namespace exemploMVC.Models
{
    public class CadastroUsuarioModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}