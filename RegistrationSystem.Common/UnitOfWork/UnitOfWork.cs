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
        private AddressRepository _addressRepository = new AddressRepository();
        private BirthCertificateRepository _sertificateRepositoryrepository = new BirthCertificateRepository();
        private ChildRepository _childRepository = new ChildRepository();
        private KindergartenRepository _kindergartenRepository = new KindergartenRepository();
        private StaffRepository _staffRepository = new StaffRepository();
        private UserRepository _userRepository = new UserRepository();
        private IRepository<Staff> staffRepository;
        private IRepository<StaffPosition> positionRepository;



        public bool IsUserExistInBase(string login, string password)
        {
            return _userRepository.IsUserExist(login, password);
        }

        public bool IsAvailableLogin(string login)
        {
            return _userRepository.IsLoginAvailable(login);
        }

        public void AddUser(User user)
        {
            _userRepository.Add(user);
            _userRepository.Save();
        }

        public void RegistredChild(ChildModel model, string login)
        {
            Child child = new Child()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                MiddleName = model.MiddleName,
                DateOfBirth = model.DateOfBirth,
                Address = new Address()
                {
                    City = model.City,
                    House = model.House,
                    Street = model.Street,
                    Apartment = model.Apartment
                },
                BirthCertificate = new BirthCertificate()
                {
                    Number = model.Number,
                    Description = model.Description,
                    Series = model.Series
                },
            };

            _childRepository.AddChild(child, login, model.KindergartenNumber);

        }

        public void Delete(ChildModel _childModel)
        {
            using (_childRepository = new ChildRepository())
            {
                Child child = (_childRepository.FindBy(child1 => child1.Id == 1)).First();

                _childRepository.Delete(child);
                _childRepository.Save();
            }
        }
        public IEnumerable<StaffModel> GetStaffModel(int number)
        {
            var modelsList = new List<StaffModel>();
            foreach (var model in _staffRepository.GetCurrentStaff(number))
            {
                modelsList.Add(new StaffModel()
                {
                   FirstName = model.FirstName,
                   LastNAme = model.LastName,
                   Position = model.Position
                });
            }
            return modelsList;
        }
        public List<ChildModel> GetChildrenModel(int number)
        {
            var modelsList = new List<ChildModel>();
            //_childRepository.GetCurrentChildren(number);
            foreach (var model in _childRepository.GetCurrentChildren(number))
            {
                modelsList.Add(new ChildModel()
                {
                    FirstName = model.FirstName,
                    Apartment = model.Address.Apartment,
                    City = model.Address.City,
                    DateOfBirth = model.DateOfBirth,
                    House = model.Address.House,
                    LastName = model.LastName,
                    MiddleName = model.MiddleName,
                    Street = model.Address.Street,
                    Series = model.BirthCertificate.Series,
                    Number = model.BirthCertificate.Number,
                    RegistrationTime = model.RegistrationTime
                });
            }
            return modelsList;
        }
        public IEnumerable<KindergartenModel> GetKindergartenModels()
        {
            var modelsList = new List<KindergartenModel>();

            foreach (var model in _kindergartenRepository.GetKindergartens())
            {
                modelsList.Add(new KindergartenModel()
                {
                    Number = model.Number,
                    Description = model.Description,
                    AddressModel = new AddressModel()
                    {
                        Apartment = model.Address.Apartment,
                        City = model.Address.City,
                        House = model.Address.House,
                        Street = model.Address.Street
                    }
                });
            }
            return modelsList;
        }
    }
}
