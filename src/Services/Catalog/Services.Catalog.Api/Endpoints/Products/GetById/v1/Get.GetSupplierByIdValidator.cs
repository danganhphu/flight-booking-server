﻿namespace Services.Catalog.Api.Endpoints.Products.GetById.v1;

internal sealed class GetSupplierByIdValidator : Validator<GetSupplierByIdRequest>
{
    public GetSupplierByIdValidator()
    {
        RuleFor(x => x.Id)
            .NotNull().WithMessage("Supplier id cannot null!").WithErrorCode("S001");
    }
}
