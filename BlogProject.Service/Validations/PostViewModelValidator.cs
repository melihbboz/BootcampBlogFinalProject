using BlogProject.Core.ViewModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Service.Validations
{
    public class PostViewModelValidator: AbstractValidator<PostViewModel>
    {
        public PostViewModelValidator()
        {

            RuleFor(x => x.Title).NotNull().WithMessage("{PropertyName} boş kalamaz.").NotEmpty().WithMessage("{PropertyName} boş kalamaz.");

            RuleFor(x => x.Body).NotNull().WithMessage("{PropertyName} boş kalamaz.").NotEmpty().WithMessage("{PropertyName} boş kalamaz.");


        }

    }
}
