using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CertificateManagementApi.Dtos;

namespace CertificateManagementApi.Service.EmailService
{
    public interface IMailService
    {
        public void SendEMailAsync(MailRequest mailRequest);
    }
}