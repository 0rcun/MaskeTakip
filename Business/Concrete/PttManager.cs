﻿using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        public IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)// Constructor new yapıldığında çalışır 
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {

            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.Firstname + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.Firstname +" "+person.LastName+ " için maske VERİLEMEDİ.");
            }
        }
    }
}
