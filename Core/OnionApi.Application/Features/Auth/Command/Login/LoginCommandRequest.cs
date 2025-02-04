using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApi.Application.Features.Auth.Command.Login
{
    public class LoginCommandRequest:IRequest<LoginCommandResponse>
    {
        [DefaultValue("deneme1@gmail.com")]
        public string Email { get; set; }

        [DefaultValue("123456")]
        public string Password { get; set; }
    }
}
