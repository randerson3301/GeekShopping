﻿using AutoMapper;
using GeekShopping.ProductApi.Data;
using GeekShopping.ProductApi.Model;

namespace GeekShopping.ProductApi.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mapConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductVO, Product>();
                config.CreateMap<Product, ProductVO>();
            });

            return mapConfig;
        }
    }
}
