using System;
using System.Collections.Generic;
using System.Linq;
using RegistrationSystem.Common.Model;
using RegistrationSystem.DAL.Concrete;
using RegistrationSystem.DAL.Interfaces;
using RegistrationSystem.DAL.Repositories;
using RegistrationSystem.Entities;

namespace RegistrationSystem.Common.UnitOfWork
{
    public class UnitOfWork
    {

        private AddressRepository addressRepository = new AddressRepository();

        private BirthCertificateRepository sertificateRepositoryrepository =
            new BirthCertificateRepository();

        private IRepository<Child> childRepository = new EfBaseRepositoty<Child, EfDataContext>();
        
        private KindergartenRepository kindergartenRepository = new KindergartenRepository();
        private IRepository<Order> orderRepository = new EfBaseRepositoty<Order, EfDataContext>();
        private IRepository<Staff> staffRepository = new EfBaseRepositoty<Staff, EfDataContext>();



        private IRepository<StaffPosition> positionRepository = new EfBaseRepositoty<StaffPosition, EfDataContext>();
        private IRepository<User> userRepository = new EfBaseRepositoty<User, EfDataContext>();


        public IEnumerable<User> GetUser()
        {
            return new List<User>();
        }

        public void AddUser(User user)
        {
            userRepository.Add(user);
            userRepository.Save();
        }

        public void RegistredChild(ChildModel childModel, string login)
        {
            ChildModel model = new ChildModel();

            model.Number = 12345;
            model.Apartment = 19;
            model.DateOfBirth = DateTime.Now;
            model.Description = "Залізничним РВЦМВС";
            model.FirstName = "Diana";
            model.LastName = "Cher";
            model.MiddleName = "Sergeevna";
            model.Series = "aa";
            model.Street = "vigovskogo";
            model.City = "Lvov";
            model.House = 3;
            model.KindergartenNumber = 128;

            Child child = new Child();
            child.FirstName = model.FirstName;
            child.LastName = model.LastName;
            child.MiddleName = model.MiddleName;
            child.DateOfBirth = model.DateOfBirth;
            

            Address address = new Address();
            address.City = model.City;
            address.House = model.House;
            address.Street = model.Street;
            address.Apartment = model.Apartment;

            BirthCertificate birthCertificate = new BirthCertificate();
            birthCertificate.Number = model.Number;
            birthCertificate.Description = model.Description;
            birthCertificate.Series = model.Series;
            birthCertificate.Child = new Child();

            Kindergarten kindergarten = new Kindergarten();

            child.Address = address;
            child.BirthCertificate = birthCertificate;
            
            address.Children = new List<Child>() {child};
            kindergarten.Children = new List<Child>() {child};
            birthCertificate.Child = child;

            childRepository.Add(child);
            addressRepository.Add(address);
            sertificateRepositoryrepository.Add(birthCertificate);

            //kindergartenRepository.Save();
            sertificateRepositoryrepository.Save();
            addressRepository.Save();

            




            //  Address address = new Address();
            //  address.City = childModel.City;
            //  address.House = childModel.House;
            //  address.Street = childModel.Street;
            //  address.Apartment = childModel.Apartment;

            //  Child child = new Child();
            ////  child.BirthCertificate.Number = childModel.Number;
            //  child.BirthCertificate.Description = childModel.Description;
            //  child.BirthCertificate.Series = childModel.Series;
            //  child.FirstName = childModel.FirstName;
            //  child.LastName = childModel.LastName;
            //  child.MiddleName = childModel.MiddleName;
            //  child.DateOfBirth = childModel.DateOfBirth;



            //  childRepository.Add(child);

        }

        public IEnumerable<KindergartenModel> GetKindergartenModels()
        {
            List<KindergartenModel> modelsList = new List<KindergartenModel>();
            var result = kindergartenRepository.GetKindergartens().ToList();
            

            foreach (var garten in result)
            {
                modelsList.Add(new KindergartenModel()
                {
                    Number = garten.Number,
                    Description = garten.Description,
                    AddressModel = new AddressModel()
                    {
                        City = garten.Address.City,
                        Street = garten.Address.Street,
                        House = garten.Address.House
                    }
                });
                
            }
            return modelsList;
        }
    }
}