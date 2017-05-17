using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using RegistrationSystem.Common.Model;
using RegistrationSystem.Common.UnitOfWork;
using RegistrationSystem.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System;

namespace RegistrationSystem.WPFUI.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>


    /// <summary>
    /// Initializes a new instance of the MainViewModel class.
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private string _login = "admin";
        private UnitOfWork _unitOfWork = new UnitOfWork();
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<KindergartenModel> KindergartensModels { get; set; }

        private List<int> _KindergartenNumber;

        private ICommand _addChildCommand;
        private ICommand _registrationChildCommand;
        private ChildModel _childModel;


        public ICommand RegistrationChildCommand
        {
            get
            {
                return _registrationChildCommand ?? (_registrationChildCommand = new RelayCommand((() =>
                           {
                               
                               _unitOfWork.RegistredChild(_childModel, _login);

                           }
                       )));
            }
            set { _registrationChildCommand = value; }
        }

        public ChildModel ChildModel
        {
            get { return _childModel; }
            set
            {
                if (_childModel != value)
                {
                    _childModel = value;
                    RaisePropertyChanged();
                }
            }
        }

        private bool isVisibleAll = true;
        private bool isVisibleAddChild = true;

        public List<int> KindergartenNumber
        {
            get { return _KindergartenNumber; }
            set
            {
                if (_KindergartenNumber != value)
                {
                    _KindergartenNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        

        private bool _text;

        public bool Text
        {
            
            get { return isVisibleAll; }
            set
            {
                if (isVisibleAll != value)
                {
                    isVisibleAll = value;
                    RaisePropertyChanged();
                }
            }
        }

        public bool IsVisibleAll
        {
            get { return isVisibleAll; }
            set
            {
                if (isVisibleAll != value)
                {
                    isVisibleAll = value;
                    RaisePropertyChanged("IsVisibleAll");
                }
            }
        }

        public ICommand AddRegPanelCommand
        {
            get
            {
                return _addChildCommand ?? (_addChildCommand = new RelayCommand((() =>
                           {
                               IsVisibleAll = false;
                               IsVisibleAddChild = true;
                           }
                       )));
            }
            set { _addChildCommand = value; }
        }

        public bool IsVisibleAddChild
        {
            get { return isVisibleAddChild; }
            set
            {
                if (isVisibleAddChild != value)
                {
                    isVisibleAddChild = value;
                    RaisePropertyChanged("isVisibleAddChild");
                }
            }
        }


        public MainViewModel()
        {
            Users = _unitOfWork.GetUser();
            KindergartensModels = _unitOfWork.GetKindergartenModels();
            GetgartenNumber();

               
            

            RaisePropertyChanged();

        }

        private void GetgartenNumber()
        {
            _childModel = new ChildModel();
            _KindergartenNumber = new List<int>();
            foreach (var garten in KindergartensModels)
            {
                _KindergartenNumber.Add(garten.Number);
            }
        }
    }
}