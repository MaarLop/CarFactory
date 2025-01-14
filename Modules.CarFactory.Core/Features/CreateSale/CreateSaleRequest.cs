﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Modules.CarFactory.Core.Features.CreateSale
{
    public class CreateSaleRequest(int carId, int distributionCenterId) : IRequest<CreateSaleResponse>
    {
        public int CarId { get; set; } = carId;
        public int DistributionCenterId { get; set; } = distributionCenterId;
    }
}