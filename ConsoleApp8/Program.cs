using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContext<ERPDbContext>(o =>
            {
                o.UseSqlServer("Server=localhost;Database=ERP;User Id=sa;Password=Str0ngPassword;");
            });
            var provider = serviceCollection.BuildServiceProvider();

            var pacoElConductor = new Entities.Entity
            {
                IdChannel = 1,
                Properties = new List<Entities.Property>
                {
                    new Entities.Property
                    {
                        Title = "Nombre",
                        Values = new List<Entities.PropertyValues>
                        {
                            new Entities.PropertyValues
                            {
                                IdUnderlyingCause = 1,
                                Value = "manuel"
                            },
                            new Entities.PropertyValues
                            {
                                IdUnderlyingCause = 2,
                                Value = "jose"
                            }
                        }
                    },
                                        new Entities.Property
                    {
                        Title = "Apeliidos",
                        Values = new List<Entities.PropertyValues>
                        {
                            new Entities.PropertyValues
                            {
                                IdUnderlyingCause = 1,
                                Value = "Fernandez"
                            },
                            new Entities.PropertyValues
                            {
                                IdUnderlyingCause = 2,
                                Value = "Montes"
                            }
                        }
                    }
                }
            };


            var componnentPropertyBlock1 = new Entities.ComponentPropertiesContainer()
            {
                Container = new Entities.Container
                {
                    IdChannel = 1,
                    Title = "Grid Conductores"
                },
                Component = new Entities.Component
                {
                    Type = "array",
                    Format = "kendogrid",
                },
                Property = pacoElConductor.Properties.First()
            };

            var componnentPropertyBlock2 = new Entities.ComponentPropertiesContainer()
            {
                Container = new Entities.Container
                {
                    IdChannel = 1,
                    Title = "Grid Conductores"
                },
                Component = new Entities.Component
                {
                    Type = "array",
                    Format = "kendogrid",
                },
                Property = pacoElConductor.Properties.Last()
            };


            var componnentPropertyBlock3 = new Entities.ComponentPropertiesContainer()
            {
                Container = new Entities.Container
                {
                    IdChannel = 1,
                    Title = "Grid Conductores"
                },
                Component = new Entities.Component
                {
                    Type = "string",
                },
                Property = pacoElConductor.Properties.First()
            };


        }
    }
}
