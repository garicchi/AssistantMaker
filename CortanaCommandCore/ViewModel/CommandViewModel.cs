﻿using CortanaCommandCore.ViewModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CortanaCommand.ViewModel
{
    public class CommandViewModel:ViewModelBase
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                this.Set(ref _name, value);
            }
        }

        private int _currentStateNum;

        public int CurrentStateNum
        {
            get
            {
                return _currentStateNum;
            }

            set
            {
                this.Set(ref _currentStateNum,value);
            }
        }

        private string _uniqueId;

        public string UniqueId
        {
            get { return _uniqueId; }
            set { this.Set(ref _uniqueId, value); }
        }


        public ObservableCollection<StateViewModel> StateList
        {
            get
            {
                return _stateList;
            }

            set
            {
                this.Set(ref _stateList,value);
            }
        }

        private ObservableCollection<StateViewModel> _stateList;

        public RelayCommand AddSuccessStateCommand { get; set; }

        public RelayCommand AddScriptStateCommand { get; set; }

        public RelayCommand AddProtocolStateCommand { get; set; }

        public RelayCommand<StateViewModel> DeleteStateCommand { get; set; }

        

        public CommandViewModel()
        {
            this.StateList = new ObservableCollection<StateViewModel>();
            CurrentStateNum = 0;
            
            DeleteStateCommand = new RelayCommand<StateViewModel>((state)=>
            {
                StateList.Remove(state);
            });

            AddSuccessStateCommand = new RelayCommand(()=>
            {
                var vm = new SuccessStateViewModel();
                vm.Name = "State" + GetStateMaxNum();
                this.StateList.Add(vm);
            });

            AddScriptStateCommand = new RelayCommand(() =>
            {
                var vm = new ScriptStateViewModel();
                vm.Name = "State" + GetStateMaxNum();
                this.StateList.Add(vm);
            });

            AddProtocolStateCommand = new RelayCommand(() =>
            {
                var vm = new ProtocolStateViewModel();
                vm.Name = "State" + GetStateMaxNum();
                this.StateList.Add(vm);
            });

            UniqueId = Guid.NewGuid().ToString();

        }

        private int GetStateMaxNum()
        {
            var list = StateList.Where(q => q.Name.StartsWith("State")).ToList();
            int maxNum = 0;
            foreach (var cmd in list)
            {
                var numStr = cmd.Name.Replace("State", "");
                int result;
                bool isConvert = int.TryParse(numStr, out result);
                if (isConvert)
                {
                    if (maxNum < result)
                    {
                        maxNum = result;
                    }
                }
            }
            maxNum++;
            return maxNum;
        }

        
    }
}
