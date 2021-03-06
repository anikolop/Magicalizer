﻿// Copyright © 2020 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Magicalizer.Filters.Abstractions
{
  public class DecimalFilter : IFilter
  {
    new public decimal? Equals { get; set; }
    public decimal? From { get; set; }
    public decimal? To { get; set; }

    public DecimalFilter() { }

    public DecimalFilter(decimal? equals = null, decimal? from = null, decimal? to = null)
    {
      this.Equals = equals;
      this.From = from;
      this.To = to;
    }
  }
}