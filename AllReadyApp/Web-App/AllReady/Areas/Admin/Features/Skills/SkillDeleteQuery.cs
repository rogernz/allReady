﻿using AllReady.Areas.Admin.ViewModels.Skill;
using MediatR;

namespace AllReady.Areas.Admin.Features.Skills
{
    public class SkillDeleteQuery : IAsyncRequest<SkillDeleteViewModel>
    {
        public int Id { get; set; }
    }
}