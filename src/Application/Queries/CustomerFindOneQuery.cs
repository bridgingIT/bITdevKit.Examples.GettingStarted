﻿// MIT-License
// Copyright BridgingIT GmbH - All Rights Reserved
// Use of this source code is governed by an MIT-style license that can be
// found in the LICENSE file at https://github.com/bridgingit/bitdevkit/license

namespace BridgingIT.DevKit.Examples.GettingStarted.Application;

using BridgingIT.DevKit.Application.Queries;
using BridgingIT.DevKit.Common;
using BridgingIT.DevKit.Examples.GettingStarted.Domain.Model;
using FluentValidation;
using FluentValidation.Results;

public class CustomerFindOneQuery : QueryRequestBase<Result<Customer>>
{
    public CustomerFindOneQuery(string hostId)
    {
        this.CustomerId = hostId;
    }

    public string CustomerId { get; }

    public override ValidationResult Validate() =>
        new Validator().Validate(this);

    public class Validator : AbstractValidator<CustomerFindOneQuery>
    {
        public Validator()
        {
            this.RuleFor(c => c.CustomerId).NotNull().NotEmpty().WithMessage("Must not be empty.");
        }
    }
}
