﻿using API.Resources;
using FluentValidation;

namespace API.Validators
{
    public class SaveRoomResourceValidator : AbstractValidator<SaveRoomResource>
    {
        public SaveRoomResourceValidator()
        {
            RuleFor(m => m.Name)
                .NotEmpty()
                .MaximumLength(50);

            RuleFor(m => m.RoomId)
                .NotEmpty()
                .WithMessage("Room ID must not be 0.");

            RuleFor(m => m.CompanyId)
                .NotEmpty()
                .WithMessage("Company ID must not be 0.");
        }
    }
}
