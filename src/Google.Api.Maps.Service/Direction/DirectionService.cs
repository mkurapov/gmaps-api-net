﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
namespace Google.Api.Maps.Service.Direction
{
    public class DirectionService
    {
        public static readonly Uri ApiUrl =
            new Uri("http://maps.googleapis.com/maps/api/directions/");

        public DirectionResponse GetResponse(DirectionRequest request)
        {
            var url = new Uri(ApiUrl, request.ToUri());
            return Http.Get(url).As<DirectionResponse>();

          
        }
    }
}