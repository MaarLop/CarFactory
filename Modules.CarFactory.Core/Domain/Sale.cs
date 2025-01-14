﻿using System.ComponentModel.DataAnnotations;
using Modules.CarFactory.Core.Validators;

namespace Modules.CarFactory.Core.Domain
{
    public class Sale(int carId, int distributionCenterId)
    {
        public int Id { get; set; }

        [Required]
        [MustBePositiveAttribute]

        public int CarId { get; set; } = carId;

        [Required]
        [MustBePositiveAttribute]
        public int DistributionCenterId { get; set; } = distributionCenterId;
        public DateTime DateTime { get; set; } = DateTime.UtcNow;
    }
}
