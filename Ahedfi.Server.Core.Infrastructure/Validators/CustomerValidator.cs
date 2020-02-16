using Ahedfi.Component.Communication.Domain.Entities;
using Ahedfi.Server.Core.Domain.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ahedfi.Server.Core.Infrastructure.Validators
{
    public class CustomerSaveRequestValidator : AbstractValidator<SaveRequest<CustomerDto>>
    {
        public CustomerSaveRequestValidator()
        {
            RuleFor(m => m.Value.Name)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(100)
                .WithMessage("custom message : the name's length should be enter 3 and 100 characters.");
        }
    }
}
