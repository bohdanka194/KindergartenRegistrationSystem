using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using RegistrationSystem.Common.Model;
using RegistrationSystem.Common.UnitOfWork;
using RegistrationSystem.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System;
using System.Windows;

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

        private string _login; 
        private UnitOfWork _unitOfWork;

        private List<int> _KindergartenNumber;

        private ICommand _addChildCommand;
        private ICommand _registrationChildCommand;
        private ICommand _deleteCommand;
        private ChildModel _childModel;
        private IEnumerable<ChildModel> _childrenModel;
        private bool _text;
        private bool _isVisibleAll = true;
        private bool _isVisibleAddChild = false;
        private KindergartenModel _kModel;
        private IEnumerable<StaffModel> _staffModels;

        
        public IEnumerable<KindergartenModel> KindergartensModels { get; set; }

        public string Login
        {
            get { return $"Hello " + _login; }
            set { _login = value; }
        }

        public ICommand DeleteChildCommand
        {
            get
            {
                return _deleteCommand ?? (_deleteCommand = new RelayCommand((() =>
                           {
                               _unitOfWork.Delete(_childModel);
                               MessageBoxResult message = MessageBox.Show("Delete");
                           }
                       )));
            }
            set { _deleteCommand = value; }
        }

        public ICommand RegistrationChildCommand
        {
            get
            {
                return _registrationChildCommand ?? (_registrationChildCommand = new RelayCommand((() =>
                           {
                               _unitOfWork.RegistredChild(_childModel, _login);
                               MessageBoxResult message = MessageBox.Show("Registred");
                               IsVisibleAddChild = false;
                               IsVisibleAll = true;
                               RaisePropertyChanged();
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
        public IEnumerable<ChildModel> ChildrenModel
        {
            get { return _childrenModel; }
            set
            {
                if (_childrenModel != value)
                {
                    _childrenModel = value;
                    RaisePropertyChanged();
                }
            }
        }

        public IEnumerable<StaffModel> StaffModels
        {
            get { return _staffModels; }
            set
            {
                if (_staffModels != value)
                {
                    _staffModels = value;
                    RaisePropertyChanged();
                }
            }
        }

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

        public bool Text
        {
            
            get { return _isVisibleAll; }
            set
            {
                if (_isVisibleAll != value)
                {
                    _isVisibleAll = value;
                    RaisePropertyChanged();
                }
            }
        }
      //

        public bool IsVisibleAll
        {
            get { return _isVisibleAll; }
            set
            {
                if (_isVisibleAll != value)
                {
                    _isVisibleAll = value;
                    RaisePropertyChanged("IsVisibleAll");
                }
            }
        }

        public ICommand AddRegPanelChildCommand
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
            get { return _isVisibleAddChild; }
            set
            {
                if (_isVisibleAddChild != value)
                {
                    _isVisibleAddChild = value;
                    RaisePropertyChanged("isVisibleAddChild");
                }
            }
        }

        public KindergartenModel KModel
        {
            get { return _kModel; }
            set
            {
                if (_kModel != value)
                {
                    _kModel = value;
                    StaffModels = _unitOfWork.GetStaffModel(_kModel.Number);
                    ChildrenModel = _unitOfWork.GetChildrenModel(_kModel.Number);
                    RaisePropertyChanged();
                }
            }
        }


        public MainViewModel(string login)
        {
            _unitOfWork = new UnitOfWork();
            KindergartensModels = _unitOfWork.GetKindergartenModels();
            GetgartenNumber();
            _login = login;

            RaisePropertyChanged();

        }
        public MainViewModel()
        { }
       

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