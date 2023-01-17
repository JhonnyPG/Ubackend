using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace LinqSnipets
{
    public class Snipets
    {
        static public void BasicLinq()
        {
            string[] cars =
            {
                "Spark GT",
                "Sail",
                "Captiva",
                "Mazda 3",
                "Seat Ibiza",
                "Seat Leon"
            };

            // Select * todos los coches 
            var carlist = from car in cars select car;
            foreach (var car in carlist)
            {
                Console.WriteLine(car);
            }

            // Select coche especifico 
            var coche = from car in cars where car.Contains("Mazda 3") select car; 
            foreach(var mazda in coche)
            {
                Console.WriteLine(mazda);
            }
        }

        // trabajar con numeros
        static public void LinqNumbers()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var listaNumeros = numbers.Select(x => x * 3).Where(x => x != 9).OrderBy(x => x);

        }

        static public void SearchN()
        {
            List<string> listText = new List<string> { "a", "bx", "c", "d", "e", "cj", "f" };
            // primer elemento

            var Primero = listText.First();

            // primer elemento que sea igual a 
            var PrimeraC = listText.First(text => text.Equals("c"));

            // primer elemento que contenca una palabrao letra 
            var containj = listText.First(text => text.Contains("cj"));
            // primer elemento o default

            var firstord = listText.FirstOrDefault(text => text.Contains("Z"));

            var enterprises = new[]
            {
                new Enterprise()
                {
                    Id = 1,
                    Name ="empresa1",
                    Employees = new[]
                    {
                        new Employee()
                        {
                            Id = 1,
                            Name ="empleado1",
                            Email = "empleado1@gmail.com",
                            Salary= 10000
                        },
                        new Employee()
                        {
                            Id = 2,
                            Name ="empleado2",
                            Email = "empleado2@gmail.com",
                            Salary= 20000
                        },
                        new Employee()
                        {
                            Id = 3,
                            Name ="empleado3",
                            Email = "empleado3@gmail.com",
                            Salary= 30000
                        },
                        new Employee()
                        {
                            Id=4,
                            Name ="empleado4",
                            Email = "empleado4@gmail.com",
                            Salary = 40000
                        }
                    }
                },

                new Enterprise()
                {
                    Id = 2,
                    Name = "empresa2",
                    Employees = new[]
                    {
                            new Employee()
                            {
                                Id = 8,
                                Name ="empleado8",
                                Email = "empleado4@gmail.com",
                                Salary= 80000
                            },
                            new Employee()
                            {
                                Id = 5,
                                Name ="empleado5",
                                Email = "empleado5@gmail.com",
                                Salary= 50000
                            },
                            new Employee()
                            {
                                Id = 6,
                                Name ="empleado6",
                                Email = "empleado6@gmail.com",
                                Salary= 60000
                            },
                            new Employee()
                            {
                                Id=7,
                                Name ="empleado7",
                                Email = "empleado7@gmail.com",
                                Salary = 70000
                            }
                    }
                }


            };
            var listaempleado = enterprises.SelectMany(enterprise => enterprise.Employees);
        
        }
    }
}
