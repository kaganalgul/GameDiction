﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.CQRS.Commands.Response
{
    public class CreateUserCommandResponse
    {
        public bool IsSuccess { get; set; }

        public string Username { get; set; }
    }
}
