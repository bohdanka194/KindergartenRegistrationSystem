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
        


        public IEnumerable<User> GetUser()
        {
            return new List<User>();
        }

        public void AddUser(User user)
        {
            _userRepository.Add(user);
            _userRepository.Save();
        }

        public void RegistredChild(ChildModel model, string login)
        {
            //ChildModel model = new ChildModel();

            //model.Number = 8888;
            //model.Apartment = 12;
            //model.DateOfBirth = DateTime.Now;
            //model.Description = "франківським РВЦМВС 13";
            //model.FirstName = "Sergey";
            //model.LastName = "Barina";
            //model.MiddleName = "Sergeevna";
            //model.Series = "aa";
            //model.Street = "gorodocka";
            //model.City = "Lvov";
            //model.House = 3;
           

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
                    Apartment = model.Apartment,
                     
                },
                BirthCertificate = new BirthCertificate()
                {
                    Number = model.Number,
                    Description = model.Description,
                    Series = model.Series
                },
                

        };

            _childRepository.AddChild(child,login,model.KindergartenNumber);
            

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

        public IEnumerable<KindergartenModel> GetKindergartenModels()
        {
            List<KindergartenModel> modelsList = new List<KindergartenModel>();
            using

            (_kindergartenRepository = new KindergartenRepository())
            {
                var result = _kindergartenRepository.GetKindergartens().ToList();

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
}

