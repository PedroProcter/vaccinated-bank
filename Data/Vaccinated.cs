using System;
using System.Collections.Generic;

namespace vaccinated_bank.Data
{
    public partial class Vaccinated
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Cedula { get; set; }
        public string? Phone { get; set; }
        public DateOnly? BirthDate { get; set; }
        public string? Vaccine { get; set; }
        public string? Province { get; set; }
        public string? ZodiacSign { get; set; }
        public DateOnly? DateVaccine { get; set; }
    }
}
