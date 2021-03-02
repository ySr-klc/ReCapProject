﻿using Core.Entites.Concrete;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.ValidationRules
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.FirstName).NotNull();
            RuleFor(p => p.LastName).NotNull();
            RuleFor(p => p.PasswordHash).NotNull();
        }
    }
}
